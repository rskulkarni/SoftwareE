namespace RecordKeeper
{
    partial class AddUpdateFunds
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
            this.lblFundNumber = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFundName = new System.Windows.Forms.TextBox();
            this.cmbFundNumber = new System.Windows.Forms.ComboBox();
            this.btnOKAddfunds = new System.Windows.Forms.Button();
            this.btnCancelAddfunds = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFundNumber
            // 
            this.lblFundNumber.AutoSize = true;
            this.lblFundNumber.Location = new System.Drawing.Point(25, 38);
            this.lblFundNumber.Name = "lblFundNumber";
            this.lblFundNumber.Size = new System.Drawing.Size(71, 13);
            this.lblFundNumber.TabIndex = 6;
            this.lblFundNumber.Text = "Fund Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fund Name";
            // 
            // txtFundName
            // 
            this.txtFundName.Location = new System.Drawing.Point(27, 143);
            this.txtFundName.Name = "txtFundName";
            this.txtFundName.Size = new System.Drawing.Size(165, 20);
            this.txtFundName.TabIndex = 9;
            this.txtFundName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFundName_KeyPress);
            // 
            // cmbFundNumber
            // 
            this.cmbFundNumber.FormattingEnabled = true;
            this.cmbFundNumber.Location = new System.Drawing.Point(28, 64);
            this.cmbFundNumber.Name = "cmbFundNumber";
            this.cmbFundNumber.Size = new System.Drawing.Size(164, 21);
            this.cmbFundNumber.TabIndex = 10;
            // 
            // btnOKAddfunds
            // 
            this.btnOKAddfunds.Location = new System.Drawing.Point(27, 196);
            this.btnOKAddfunds.Name = "btnOKAddfunds";
            this.btnOKAddfunds.Size = new System.Drawing.Size(75, 41);
            this.btnOKAddfunds.TabIndex = 11;
            this.btnOKAddfunds.Text = "OK";
            this.btnOKAddfunds.UseVisualStyleBackColor = true;
            this.btnOKAddfunds.Click += new System.EventHandler(this.btnOKAddfunds_Click);
            // 
            // btnCancelAddfunds
            // 
            this.btnCancelAddfunds.Location = new System.Drawing.Point(117, 196);
            this.btnCancelAddfunds.Name = "btnCancelAddfunds";
            this.btnCancelAddfunds.Size = new System.Drawing.Size(75, 41);
            this.btnCancelAddfunds.TabIndex = 12;
            this.btnCancelAddfunds.Text = "Cancel";
            this.btnCancelAddfunds.UseVisualStyleBackColor = true;
            // 
            // AddUpdateFunds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCancelAddfunds);
            this.Controls.Add(this.btnOKAddfunds);
            this.Controls.Add(this.cmbFundNumber);
            this.Controls.Add(this.txtFundName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFundNumber);
            this.Name = "AddUpdateFunds";
            this.Text = "AddUpdateFunds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblFundNumber;
        public System.Windows.Forms.ComboBox cmbFundNumber;
        public System.Windows.Forms.Button btnOKAddfunds;
        public System.Windows.Forms.TextBox txtFundName;
        public System.Windows.Forms.Button btnCancelAddfunds;
    }
}