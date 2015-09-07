using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WCFBusinessLogic.Model;

namespace AdminClient
{
    public partial class CreateAuctionForm : Form
    {
        public List<ArtPiece> _artPieces { get; set; }
        public CreateAuctionForm()
        {
            
            InitializeComponent();
            this.BindArtPieces();
        }

        private void FakeArtPieces() {

            List<ArtPiece> ArtPieces = new List<ArtPiece>();

            ArtPiece ap1 = new ArtPiece();
            ap1.ArtPieceId = 1;
            ap1.Name = "Arpiece 1";
            ap1.Number = 1234;
            ap1.Artist = "Artist1";
            ap1.PurchasePrice = 125;
            ap1.PictureUrl = "";
            ap1.Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In eu tincidunt quam, ut gravida orci. Donec tincidunt dictum molestie. Integer quis cursus ex. Nulla imperdiet lorem nibh, non pulvinar nunc facilisis ut. Phasellus fermentum sapien interdum sapien elementum pulvinar sed varius leo. Sed id arcu erat. Sed eu congue libero, id malesuada felis. Nullam tempor, tellus id porta varius, eros est dictum turpis, a luctus libero tellus mattis mi. Aliquam ultrices lorem ac odio consequat vehicula. Suspendisse eu sollicitudin metus, in eleifend odio. ";


            ArtPiece ap2 = new ArtPiece();
            ap2.ArtPieceId = 2;
            ap2.Name = "Arpiece 2";
            ap2.Number = 1234;
            ap2.Artist = "Artist2";
            ap2.PurchasePrice = 125;
            ap2.PictureUrl = "";
            ap2.Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In eu tincidunt quam, ut gravida orci. Donec tincidunt dictum molestie. Integer quis cursus ex. Nulla imperdiet lorem nibh, non pulvinar nunc facilisis ut. Phasellus fermentum sapien interdum sapien elementum pulvinar sed varius leo. Sed id arcu erat. Sed eu congue libero, id malesuada felis. Nullam tempor, tellus id porta varius, eros est dictum turpis, a luctus libero tellus mattis mi. Aliquam ultrices lorem ac odio consequat vehicula. Suspendisse eu sollicitudin metus, in eleifend odio. ";

            ArtPiece ap3 = new ArtPiece();
            ap3.ArtPieceId = 3;
            ap3.Name = "Arpiece 3";
            ap3.Number = 1234;
            ap3.Artist = "Artist3";
            ap3.PurchasePrice = 125;
            ap3.PictureUrl = "";
            ap3.Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In eu tincidunt quam, ut gravida orci. Donec tincidunt dictum molestie. Integer quis cursus ex. Nulla imperdiet lorem nibh, non pulvinar nunc facilisis ut. Phasellus fermentum sapien interdum sapien elementum pulvinar sed varius leo. Sed id arcu erat. Sed eu congue libero, id malesuada felis. Nullam tempor, tellus id porta varius, eros est dictum turpis, a luctus libero tellus mattis mi. Aliquam ultrices lorem ac odio consequat vehicula. Suspendisse eu sollicitudin metus, in eleifend odio. ";

            ArtPiece ap4 = new ArtPiece();
            ap4.ArtPieceId = 4;
            ap4.Name = "Arpiece 4";
            ap4.Number = 1234;
            ap4.Artist = "Artist4";
            ap4.PurchasePrice = 125;
            ap4.PictureUrl = "";
            ap4.Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In eu tincidunt quam, ut gravida orci. Donec tincidunt dictum molestie. Integer quis cursus ex. Nulla imperdiet lorem nibh, non pulvinar nunc facilisis ut. Phasellus fermentum sapien interdum sapien elementum pulvinar sed varius leo. Sed id arcu erat. Sed eu congue libero, id malesuada felis. Nullam tempor, tellus id porta varius, eros est dictum turpis, a luctus libero tellus mattis mi. Aliquam ultrices lorem ac odio consequat vehicula. Suspendisse eu sollicitudin metus, in eleifend odio. ";

            ArtPiece ap5 = new ArtPiece();
            ap5.ArtPieceId = 5;
            ap5.Name = "Arpiece 5";
            ap5.Number = 1234;
            ap5.Artist = "Artist5";
            ap5.PurchasePrice = 125;
            ap5.PictureUrl = "";
            ap5.Description = @"Lorem ipsum dolor sit amet, consectetur adipiscing elit. In eu tincidunt quam, ut gravida orci. Donec tincidunt dictum molestie. Integer quis cursus ex. Nulla imperdiet lorem nibh, non pulvinar nunc facilisis ut. Phasellus fermentum sapien interdum sapien elementum pulvinar sed varius leo. Sed id arcu erat. Sed eu congue libero, id malesuada felis. Nullam tempor, tellus id porta varius, eros est dictum turpis, a luctus libero tellus mattis mi. Aliquam ultrices lorem ac odio consequat vehicula. Suspendisse eu sollicitudin metus, in eleifend odio. ";

            ArtPieces.Add(ap1);
            ArtPieces.Add(ap2);
            ArtPieces.Add(ap3);
            ArtPieces.Add(ap4);
            ArtPieces.Add(ap5);

            this._artPieces = ArtPieces; 
        }

        private void BindArtPieces() {
            if (this._artPieces==null) {
                this.FakeArtPieces();
            }
            foreach (ArtPiece ap in this._artPieces) {
                Console.WriteLine("Item:" + ap.ArtPieceId);
            }
            this.dataGridView1.DataSource = this._artPieces;
        }

        private void MoveUp(int index) {
            
            int toSwapIndex = index - 1;
            int toSwapWithIndex = toSwapIndex - 1;

            ArtPiece toSwap = this._artPieces[index - 1];
            ArtPiece toSwapWith = this._artPieces[toSwapWithIndex];

            this._artPieces[toSwapWithIndex] = toSwap;
            this._artPieces[toSwapIndex] = toSwapWith;

            Console.WriteLine("to swap/toswapwith:" + toSwapIndex + "/" + toSwapWithIndex);


            this.BindArtPieces();

        }

        private void button3_Click(object sender, EventArgs e) {
            int countRows = this.dataGridView1.SelectedRows.Count;
            int id = 0;
            if (countRows == 1) {
                DataGridViewRow row = this.dataGridView1.SelectedRows[0];
                id = Convert.ToInt32(row.Cells["artPieceIdDataGridViewTextBoxColumn"].Value);
                
                
            }
            dataGridView1.ClearSelection();
            MoveUp(id);
         
            this.dataGridView1.Update();
            this.dataGridView1.Refresh();
        }
    }

    
}
