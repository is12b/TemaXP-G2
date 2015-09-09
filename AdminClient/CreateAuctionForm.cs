using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminClient.ServiceReference1;
using WCFBusinessLogic.Helper;

namespace AdminClient {
    public partial class CreateAuctionForm : Form {
        private List<ArtPiece> ArtPieces { get; set; }
        private IAuctionService _auctionClient;
        private IArtPieceService _artPieceClient;
        private ILotService _lotClient;
        public CreateAuctionForm() {

            InitializeComponent();
            _auctionClient = new AuctionServiceClient();
            _artPieceClient = new ArtPieceServiceClient();
            _lotClient = new LotServiceClient();

            List<ArtPiece> ArtPieces = new List<ArtPiece>();
            this.BindArtPieces();
        }

        private void BindArtPieces() {
            //if (this._artPieces == null) {
            //    this.FakeArtPieces();
            //}

            ArtPieces = _artPieceClient.GetAllAvilableArtPieces();
            

            foreach (ArtPiece ap in this.ArtPieces) {
                Console.WriteLine("Item:" + ap.ArtPieceId);
            }
            this.dataGridView1.DataSource = this.ArtPieces;
        }

        private void MoveDown(int index) {
            try {
                if (index + 1 < dataGridView1.RowCount) {
                    int selectedIndex = index;
                    int swapIndex = selectedIndex + 1;
                    ArtPiece selectedAP = this.ArtPieces[selectedIndex];
                    ArtPiece swapAP = this.ArtPieces[swapIndex];

                    this.ArtPieces[swapIndex] = selectedAP;
                    this.ArtPieces[selectedIndex] = swapAP;
                    dataGridView1.Rows[swapIndex].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[swapIndex].Cells[0];

                }
            }
            catch (ArgumentOutOfRangeException) { }
        }

        private void MoveUp(int index) {
            try {
                if (index > 0) {
                    int selectedIndex = index;
                    int swapIndex = selectedIndex - 1;
                    ArtPiece selectedAP = this.ArtPieces[selectedIndex];
                    ArtPiece swapAP = this.ArtPieces[swapIndex];

                    this.ArtPieces[swapIndex] = selectedAP;
                    this.ArtPieces[selectedIndex] = swapAP;
                    dataGridView1.Rows[swapIndex].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[swapIndex].Cells[0];

                }
            }
            catch (ArgumentOutOfRangeException) { }
            //if (index > -1 && index != null) {

            //    int toSwapIndex = index - 1;
            //    int toSwapWithIndex = toSwapIndex - 1;

            //    ArtPiece toSwap = this._artPieces[index - 1];
            //    ArtPiece toSwapWith = this._artPieces[toSwapWithIndex];

            //    this._artPieces[toSwapWithIndex] = toSwap;
            //    this._artPieces[toSwapIndex] = toSwapWith;

            //    Console.WriteLine("to swap/toswapwith:" + toSwapIndex + "/" + toSwapWithIndex);

            //}

        }



        private void button_Up(object sender, EventArgs e) {
            int countRows = this.dataGridView1.SelectedRows.Count;
            int index = 0;
            if (countRows == 1) {
                //ataGridViewRow row = this.dataGridView1.SelectedRows[0];
                //id = Convert.ToInt32(row.Cells["artPieceIdDataGridViewTextBoxColumn"].Value);
                index = dataGridView1.SelectedRows[0].Index;
                //dataGridView1.ClearSelection();
                MoveUp(index);

                this.dataGridView1.Update();
                this.dataGridView1.Refresh();
            }

        }

        private void button_Down(object sender, EventArgs e) {
            int countRows = this.dataGridView1.SelectedRows.Count;
            int index = 0;
            if (countRows == 1) {
                //ataGridViewRow row = this.dataGridView1.SelectedRows[0];
                //id = Convert.ToInt32(row.Cells["artPieceIdDataGridViewTextBoxColumn"].Value);
                index = dataGridView1.SelectedRows[0].Index;
                //dataGridView1.ClearSelection();
                MoveDown(index);

                this.dataGridView1.Update();
                this.dataGridView1.Refresh();


            }
        }

        private void button_Save(object sender, EventArgs e) {
            //Gem auktion
            try {
                if (AuctionNameTextBox.Text.Length == 0) {
                    MessageBox.Show("Giv auktionen et navn!");
                    throw new Exception();
                }

                if (AuctionMultipler.Value < 1) {
                    MessageBox.Show("Angiv en multiplier!");
                    throw new Exception();
                }

                if (AuctionTimePerArtPiece.Value < 1) {
                    MessageBox.Show("Angiv en tid pr kunstværk!");
                    throw new Exception();
                }

                bool found = false;
                int count = 0;
                while (!found && count < ArtPieces.Count) {
                    if (ArtPieces[count].Checked == true) {
                        found = true;
                    }
                    count ++;
                }

                if (found != true) {
                    MessageBox.Show("Vælg kunst!");
                    throw new Exception();
                }

                TimeSpan ts = new TimeSpan(0, Int32.Parse(AuctionTimePerArtPiece.Value.ToString()), 0);

                List<ArtPiece> selectedArtPieces = (from artpiece in ArtPieces where artpiece.Checked == true select (artpiece)).ToList();

                int count1 = 0;
                List<Lot> lots = new List<Lot>();
                foreach (var artpiece in selectedArtPieces) {
                    Lot l = new Lot() {
                        Position = count1,
                        MinBid = artpiece.PurchasePrice/2,
                        ArtPiece = artpiece,
                    };
                    lots.Add(l);
                    count1 ++;
                }

                Auction a = new Auction() {
                    AuctionName = AuctionNameTextBox.Text,
                    LotDuration = ts,
                    Multiplier = Int32.Parse(AuctionMultipler.Value.ToString()),
                    Lots = lots,
                    Status = Status.Ready,
                };
                try {
                    _auctionClient.AddAuction(a);
                    MessageBox.Show("Auktionen blev oprettet!");
                    this.Close();
                } catch (Exception ex) {
                    ex.DebugGetLine();
                    MessageBox.Show("Der opstod en fejl, prøv igen!");
                }

            } catch (Exception ex) {
                ex.DebugGetLine();
            }
        }

        private void button_SelectAll(object sender, EventArgs e) {
            //check alle bokse
            foreach (ArtPiece ap in ArtPieces) {
                ap.Checked = true;
            }
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }


}
