using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient
{
    public partial class SelectSavedAuctionForm : Form
    {
        public SelectSavedAuctionForm()
        {
            InitializeComponent();
        }

        private void CancelRunAuctionButton_Click(object sender, EventArgs e)
        {
            // close window
        }

        private void RunAuctionButton_Click(object sender, EventArgs e) {

            int selectedAuction = SavedAuctionsDataGridView.SelectedRows[0];

            if (selectedAuction > -1) {
                
                SavedAuctionsDataGridView.Data
            }
        }
    }
}
