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

namespace AdminClient
{
    public partial class RunActionForm : Form {

        private IAuctionService _auctionClient;
        private Auction _auction;
        private int _timeLeft;
        private int _lotCount;
        public RunActionForm(Auction auction)
        {
            InitializeComponent();
            this._auction = auction;
            _auctionClient = new AuctionServiceClient();
            dataGridView1.DataSource = auction.Lots;
            _lotCount = 0;
            NextLot();
        }

        private void TimerStart() {
            _timeLeft = Int32.Parse(_auction.LotDuration.TotalSeconds.ToString());
            timerLot.Start();
        }

        private void NextLot() {
            if (_lotCount < _auction.Lots.Count) {
                Lot l = _auction.Lots[_lotCount];
                ArtPieceArtistLbl.Text = l.ArtPiece.Artist;
                ArtPieceNumberLbl.Text = l.ArtPiece.Number.ToString();
                ArtPiecePriceLbl.Text = l.ArtPiece.PurchasePrice.ToString();
                txtDescription.Text = l.ArtPiece.Description;
                TimerStart();
            }
            else {
                //Auktion er færdig
                FinishAuction();
            }
        }

        private void CancelLotButton_Click(object sender, EventArgs e) {
            _timeLeft = 30;
        }

        private void CancelAuctionButton_Click(object sender, EventArgs e)
        {
            // cancel auction
            FinishAuction();
        }

        private void FinishAuction() {
            _auction.Status = Status.Complete;
            _auctionClient.UpdateAuction(_auction);
            this.Close();
        }
        private void timerLot_Tick(object sender, EventArgs e) {
            if (_timeLeft > 0) {
                _timeLeft --;
                LotTimeLeftLbl.Text = _timeLeft/60 + ":" + _timeLeft%60;
            }
            else {
                timerLot.Stop();
                if (_auction.Lots[_lotCount].Bids.Count > 0) {
                    Bid b = _auction.Lots[_lotCount].Bids[_auction.Lots[_lotCount].Bids.Count - 1];
                    MessageBox.Show("Kunstværk købt af " + b.Bidder.Name + " for" + b.Amount + " points!");
                }
                else {
                    MessageBox.Show("Kunstværk ikke købt!");
                }
                _lotCount ++;
                NextLot();
            }
        }
    }
}
