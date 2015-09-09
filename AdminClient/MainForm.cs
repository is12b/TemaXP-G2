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
        RunActionForm RunAuctionFormShow;

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
            if (RunAuctionFormShow == null)
            {

                //RunAuctionFormShow = new RunActionForm();
                RunAuctionFormShow.MdiParent = this;
                RunAuctionFormShow.FormClosed += RunAuctionFormShow_FormClosed;
                RunAuctionFormShow.Show();
            }
        }

        void CreateAuctionFormShow_FormClosed(object sender, FormClosedEventArgs e) {
            //throw new NotImplementedException();
            CreateAuctionFormShow = null;
        }

        void RunAuctionFormShow_FormClosed(object sender, FormClosedEventArgs e)
        {
            //throw new NotImplementedException();
            RunAuctionFormShow = null;
        }



    }
}

