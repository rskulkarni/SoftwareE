namespace RecordKeeper
{
    partial class AddDonation
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
            this.txtDonationEnvNum = new System.Windows.Forms.TextBox();
            this.txtDonationsFundNum = new System.Windows.Forms.TextBox();
            this.txtDonationsSpecDesc = new System.Windows.Forms.TextBox();
            this.txtDonationsFundAmt = new System.Windows.Forms.TextBox();
            this.txtDonMoneyType = new System.Windows.Forms.TextBox();
            this.AddDonations = new System.Windows.Forms.Button();
            this.cancelDonations = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDonationEnvNum
            // 
            this.txtDonationEnvNum.Location = new System.Drawing.Point(12, 46);
            this.txtDonationEnvNum.Name = "txtDonationEnvNum";
            this.txtDonationEnvNum.Size = new System.Drawing.Size(130, 20);
            this.txtDonationEnvNum.TabIndex = 0;
            // 
            // txtDonationsFundNum
            // 
            this.txtDonationsFundNum.Location = new System.Drawing.Point(190, 46);
            this.txtDonationsFundNum.Name = "txtDonationsFundNum";
            this.txtDonationsFundNum.Size = new System.Drawing.Size(135, 20);
            this.txtDonationsFundNum.TabIndex = 1;
            // 
            // txtDonationsSpecDesc
            // 
            this.txtDonationsSpecDesc.Location = new System.Drawing.Point(12, 152);
            this.txtDonationsSpecDesc.Name = "txtDonationsSpecDesc";
            this.txtDonationsSpecDesc.Size = new System.Drawing.Size(135, 20);
            this.txtDonationsSpecDesc.TabIndex = 2;
            // 
            // txtDonationsFundAmt
            // 
            this.txtDonationsFundAmt.Location = new System.Drawing.Point(12, 99);
            this.txtDonationsFundAmt.Name = "txtDonationsFundAmt";
            this.txtDonationsFundAmt.Size = new System.Drawing.Size(117, 20);
            this.txtDonationsFundAmt.TabIndex = 3;
            // 
            // txtDonMoneyType
            // 
            this.txtDonMoneyType.Location = new System.Drawing.Point(190, 99);
            this.txtDonMoneyType.Name = "txtDonMoneyType";
            this.txtDonMoneyType.Size = new System.Drawing.Size(117, 20);
            this.txtDonMoneyType.TabIndex = 4;
            // 
            // AddDonations
            // 
            this.AddDonations.Location = new System.Drawing.Point(24, 194);
            this.AddDonations.Name = "AddDonations";
            this.AddDonations.Size = new System.Drawing.Size(75, 43);
            this.AddDonations.TabIndex = 5;
            this.AddDonations.Text = "Add";
            this.AddDonations.UseVisualStyleBackColor = true;
            this.AddDonations.Click += new System.EventHandler(this.AddDonations_Click);
            // 
            // cancelDonations
            // 
            this.cancelDonations.Location = new System.Drawing.Point(199, 203);
            this.cancelDonations.Name = "cancelDonations";
            this.cancelDonations.Size = new System.Drawing.Size(86, 34);
            this.cancelDonations.TabIndex = 6;
            this.cancelDonations.Text = "Cancel";
            this.cancelDonations.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fund Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fund Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Money Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Envelope Number";
            // 
            // AddDonation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 262);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelDonations);
            this.Controls.Add(this.AddDonations);
            this.Controls.Add(this.txtDonMoneyType);
            this.Controls.Add(this.txtDonationsFundAmt);
            this.Controls.Add(this.txtDonationsSpecDesc);
            this.Controls.Add(this.txtDonationsFundNum);
            this.Controls.Add(this.txtDonationEnvNum);
            this.Name = "AddDonation";
            this.Text = "AddDonation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDonationEnvNum;
        private System.Windows.Forms.TextBox txtDonationsFundNum;
        private System.Windows.Forms.TextBox txtDonationsSpecDesc;
        private System.Windows.Forms.TextBox txtDonationsFundAmt;
        private System.Windows.Forms.TextBox txtDonMoneyType;
        private System.Windows.Forms.Button AddDonations;
        private System.Windows.Forms.Button cancelDonations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}