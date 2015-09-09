namespace AdminClient
{
    partial class SelectSavedAuctionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SavedAuctionsGroupBox = new System.Windows.Forms.GroupBox();
            this.SavedAuctionsDataGridView = new System.Windows.Forms.DataGridView();
            this.auctionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.CancelRunAuctionButton = new System.Windows.Forms.Button();
            this.RunAuctionButton = new System.Windows.Forms.Button();
            this.auctionNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.multiplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.SavedAuctionsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SavedAuctionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SavedAuctionsGroupBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 350);
            this.panel1.TabIndex = 0;
            // 
            // SavedAuctionsGroupBox
            // 
            this.SavedAuctionsGroupBox.Controls.Add(this.SavedAuctionsDataGridView);
            this.SavedAuctionsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SavedAuctionsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SavedAuctionsGroupBox.Name = "SavedAuctionsGroupBox";
            this.SavedAuctionsGroupBox.Size = new System.Drawing.Size(663, 285);
            this.SavedAuctionsGroupBox.TabIndex = 1;
            this.SavedAuctionsGroupBox.TabStop = false;
            this.SavedAuctionsGroupBox.Text = "Gemte Auktioner";
            // 
            // SavedAuctionsDataGridView
            // 
            this.SavedAuctionsDataGridView.AutoGenerateColumns = false;
            this.SavedAuctionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SavedAuctionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.auctionNameDataGridViewTextBoxColumn,
            this.creationDateDataGridViewTextBoxColumn,
            this.lotDurationDataGridViewTextBoxColumn,
            this.multiplierDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.SavedAuctionsDataGridView.DataSource = this.auctionBindingSource;
            this.SavedAuctionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SavedAuctionsDataGridView.Location = new System.Drawing.Point(3, 16);
            this.SavedAuctionsDataGridView.MultiSelect = false;
            this.SavedAuctionsDataGridView.Name = "SavedAuctionsDataGridView";
            this.SavedAuctionsDataGridView.ReadOnly = true;
            this.SavedAuctionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SavedAuctionsDataGridView.Size = new System.Drawing.Size(657, 266);
            this.SavedAuctionsDataGridView.TabIndex = 0;
            // 
            // auctionBindingSource
            // 
            this.auctionBindingSource.DataSource = typeof(AdminClient.ServiceReference1.Auction);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CancelRunAuctionButton);
            this.panel2.Controls.Add(this.RunAuctionButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 285);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 65);
            this.panel2.TabIndex = 0;
            // 
            // CancelRunAuctionButton
            // 
            this.CancelRunAuctionButton.Location = new System.Drawing.Point(352, 15);
            this.CancelRunAuctionButton.Name = "CancelRunAuctionButton";
            this.CancelRunAuctionButton.Size = new System.Drawing.Size(92, 38);
            this.CancelRunAuctionButton.TabIndex = 1;
            this.CancelRunAuctionButton.Text = "Annullere";
            this.CancelRunAuctionButton.UseVisualStyleBackColor = true;
            this.CancelRunAuctionButton.Click += new System.EventHandler(this.CancelRunAuctionButton_Click);
            // 
            // RunAuctionButton
            // 
            this.RunAuctionButton.Location = new System.Drawing.Point(195, 15);
            this.RunAuctionButton.Name = "RunAuctionButton";
            this.RunAuctionButton.Size = new System.Drawing.Size(92, 38);
            this.RunAuctionButton.TabIndex = 0;
            this.RunAuctionButton.Text = "Kør Auktion";
            this.RunAuctionButton.UseVisualStyleBackColor = true;
            this.RunAuctionButton.Click += new System.EventHandler(this.RunAuctionButton_Click);
            // 
            // auctionNameDataGridViewTextBoxColumn
            // 
            this.auctionNameDataGridViewTextBoxColumn.DataPropertyName = "AuctionName";
            this.auctionNameDataGridViewTextBoxColumn.HeaderText = "AuctionName";
            this.auctionNameDataGridViewTextBoxColumn.Name = "auctionNameDataGridViewTextBoxColumn";
            this.auctionNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creationDateDataGridViewTextBoxColumn
            // 
            this.creationDateDataGridViewTextBoxColumn.DataPropertyName = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.HeaderText = "CreationDate";
            this.creationDateDataGridViewTextBoxColumn.Name = "creationDateDataGridViewTextBoxColumn";
            this.creationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lotDurationDataGridViewTextBoxColumn
            // 
            this.lotDurationDataGridViewTextBoxColumn.DataPropertyName = "LotDuration";
            this.lotDurationDataGridViewTextBoxColumn.HeaderText = "LotDuration";
            this.lotDurationDataGridViewTextBoxColumn.Name = "lotDurationDataGridViewTextBoxColumn";
            this.lotDurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // multiplierDataGridViewTextBoxColumn
            // 
            this.multiplierDataGridViewTextBoxColumn.DataPropertyName = "Multiplier";
            this.multiplierDataGridViewTextBoxColumn.HeaderText = "Multiplier";
            this.multiplierDataGridViewTextBoxColumn.Name = "multiplierDataGridViewTextBoxColumn";
            this.multiplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SelectSavedAuctionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 350);
            this.Controls.Add(this.panel1);
            this.Name = "SelectSavedAuctionForm";
            this.Text = "SelectSavedAuctionForm";
            this.panel1.ResumeLayout(false);
            this.SavedAuctionsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SavedAuctionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox SavedAuctionsGroupBox;
        private System.Windows.Forms.DataGridView SavedAuctionsDataGridView;
        private System.Windows.Forms.BindingSource auctionBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CancelRunAuctionButton;
        private System.Windows.Forms.Button RunAuctionButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn auctionNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn multiplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}