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
    public partial class SelectSavedAuctionForm : Form {
        private ServiceReference1.IAuctionService auctionService = new AuctionServiceClient();
        public SelectSavedAuctionForm()
        {
            InitializeComponent();
        }

        private void CancelRunAuctionButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RunAuctionButton_Click(object sender, EventArgs e) {
            
            var selectedAuction = SavedAuctionsDataGridView.CurrentRow;

            if (selectedAuction > -1 && selectedAuction != null) {
                Auction a = selectedAuction.DataBoundItem as Auction;

                // call the run auction window
                
                
            }
        }
    }
}
