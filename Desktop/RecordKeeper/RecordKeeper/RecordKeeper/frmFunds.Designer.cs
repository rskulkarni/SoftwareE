namespace RecordKeeper
{
    partial class frmFunds
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
            this.dataGridFunds = new System.Windows.Forms.DataGridView();
            this.addFund = new System.Windows.Forms.Button();
            this.deleteFund = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.showFundGrid = new System.Windows.Forms.Button();
            this.editFund = new System.Windows.Forms.Button();
            this.txtFilterFunds = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintFunds = new System.Windows.Forms.Button();
            this.printFunds = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFunds)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridFunds
            // 
            this.dataGridFunds.AllowUserToAddRows = false;
            this.dataGridFunds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFunds.Location = new System.Drawing.Point(3, 12);
            this.dataGridFunds.Name = "dataGridFunds";
            this.dataGridFunds.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFunds.Size = new System.Drawing.Size(515, 164);
            this.dataGridFunds.TabIndex = 0;
            // 
            // addFund
            // 
            this.addFund.Location = new System.Drawing.Point(92, 177);
            this.addFund.Name = "addFund";
            this.addFund.Size = new System.Drawing.Size(75, 45);
            this.addFund.TabIndex = 1;
            this.addFund.Text = "Add";
            this.addFund.UseVisualStyleBackColor = true;
            this.addFund.Click += new System.EventHandler(this.addFund_Click);
            // 
            // deleteFund
            // 
            this.deleteFund.Location = new System.Drawing.Point(321, 177);
            this.deleteFund.Name = "deleteFund";
            this.deleteFund.Size = new System.Drawing.Size(87, 40);
            this.deleteFund.TabIndex = 3;
            this.deleteFund.Text = "Delete";
            this.deleteFund.UseVisualStyleBackColor = true;
            this.deleteFund.Click += new System.EventHandler(this.deleteFund_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrintFunds);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.showFundGrid);
            this.panel1.Controls.Add(this.editFund);
            this.panel1.Controls.Add(this.dataGridFunds);
            this.panel1.Controls.Add(this.addFund);
            this.panel1.Controls.Add(this.deleteFund);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 238);
            this.panel1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 177);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(63, 43);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // showFundGrid
            // 
            this.showFundGrid.Location = new System.Drawing.Point(3, 177);
            this.showFundGrid.Name = "showFundGrid";
            this.showFundGrid.Size = new System.Drawing.Size(83, 45);
            this.showFundGrid.TabIndex = 7;
            this.showFundGrid.Text = "show funds";
            this.showFundGrid.UseVisualStyleBackColor = true;
            this.showFundGrid.Click += new System.EventHandler(this.showFundGrid_Click);
            // 
            // editFund
            // 
            this.editFund.Location = new System.Drawing.Point(173, 177);
            this.editFund.Name = "editFund";
            this.editFund.Size = new System.Drawing.Size(73, 45);
            this.editFund.TabIndex = 6;
            this.editFund.Text = "Edit";
            this.editFund.UseVisualStyleBackColor = true;
            this.editFund.Click += new System.EventHandler(this.editFund_Click);
            // 
            // txtFilterFunds
            // 
            this.txtFilterFunds.Location = new System.Drawing.Point(539, 41);
            this.txtFilterFunds.Name = "txtFilterFunds";
            this.txtFilterFunds.Size = new System.Drawing.Size(188, 20);
            this.txtFilterFunds.TabIndex = 5;
            this.txtFilterFunds.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilterFunds_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(536, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filter Grid by fund names";
            // 
            // btnPrintFunds
            // 
            this.btnPrintFunds.Location = new System.Drawing.Point(415, 183);
            this.btnPrintFunds.Name = "btnPrintFunds";
            this.btnPrintFunds.Size = new System.Drawing.Size(75, 34);
            this.btnPrintFunds.TabIndex = 9;
            this.btnPrintFunds.Text = "Print";
            this.btnPrintFunds.UseVisualStyleBackColor = true;
            this.btnPrintFunds.Click += new System.EventHandler(this.btnPrintFunds_Click);
            // 
            // printFunds
            // 
            this.printFunds.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printFunds_PrintPage);
            // 
            // frmFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(753, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilterFunds);
            this.Controls.Add(this.panel1);
            this.Name = "frmFunds";
            this.Text = "frmFunds";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFunds)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dataGridFunds;
        public System.Windows.Forms.Button addFund;
        public System.Windows.Forms.Button deleteFund;
        public System.Windows.Forms.Button editFund;
        public System.Windows.Forms.Button showFundGrid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtFilterFunds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintFunds;
        private System.Drawing.Printing.PrintDocument printFunds;
    }
}