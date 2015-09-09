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

        private RunActionForm _runActionForm;
        public SelectSavedAuctionForm()
        {
            InitializeComponent();
            LoadTable();
        }

        private void LoadTable() {
            SavedAuctionsDataGridView.DataSource = auctionService.GetAllReady();
        }

        private void CancelRunAuctionButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RunAuctionButton_Click(object sender, EventArgs e) {
            
            var selectedAuction = SavedAuctionsDataGridView.CurrentRow;

            if (selectedAuction != null) {
                Auction a = selectedAuction.DataBoundItem as Auction;
                a = auctionService.GetAuctionById(a.AuctionId);
                a.Status = Status.Ongoing;
                auctionService.UpdateAuction(a);
                // call the run auction window
                _runActionForm = new RunActionForm(a);
                _runActionForm.MdiParent = this.ParentForm;
                //_runActionForm.FormClosed += _runActionForm_FormClosed;
                _runActionForm.Show();
                
            }
        }
    }
}
