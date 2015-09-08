﻿using System;
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

        void CreateAuctionFormShow_FormClosed(object sender, FormClosedEventArgs e) {
            //throw new NotImplementedException();
            CreateAuctionFormShow = null;
        }

    }
}