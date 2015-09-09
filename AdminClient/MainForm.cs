using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient {
    public partial class MainForm : Form {

        CreateAuctionForm CreateAuctionFormShow;
        SelectSavedAuctionForm selectSavedAuctionForm;

        public MainForm() {

            InitializeComponent();
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e) {
            if (CreateAuctionFormShow == null) {

                CreateAuctionFormShow = new CreateAuctionForm();
                CreateAuctionFormShow.MdiParent = this;
                CreateAuctionFormShow.FormClosed += CreateAuctionFormShow_FormClosed;
                CreateAuctionFormShow.Show();
            } else {
                CreateAuctionFormShow.Activate();
            }
        }
        private void RunAuctionMenuItem_Click(object sender, EventArgs e)
        {
            if (selectSavedAuctionForm == null) {

                selectSavedAuctionForm = new SelectSavedAuctionForm();
                selectSavedAuctionForm.MdiParent = this;
                selectSavedAuctionForm.FormClosed += SelectedSavedAuctionForm_FormClosed;
                selectSavedAuctionForm.Show();
            }
        }

        void CreateAuctionFormShow_FormClosed(object sender, FormClosedEventArgs e) {
            //throw new NotImplementedException();
            CreateAuctionFormShow = null;
        }

        void SelectedSavedAuctionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            selectSavedAuctionForm = null;
        }


    }
}

