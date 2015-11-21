namespace RecordKeeper
{
    partial class AddMember
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
            this.addMemberPanel = new System.Windows.Forms.Panel();
            this.btnCancelAddMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnvelopeNumber = new System.Windows.Forms.TextBox();
            this.addMemberPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addMemberPanel
            // 
            this.addMemberPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.addMemberPanel.Controls.Add(this.txtEnvelopeNumber);
            this.addMemberPanel.Controls.Add(this.label1);
            this.addMemberPanel.Controls.Add(this.btnCancelAddMember);
            this.addMemberPanel.Controls.Add(this.btnAddMember);
            this.addMemberPanel.Controls.Add(this.lblEmail);
            this.addMemberPanel.Controls.Add(this.lblZip);
            this.addMemberPanel.Controls.Add(this.lblCity);
            this.addMemberPanel.Controls.Add(this.lblAddress);
            this.addMemberPanel.Controls.Add(this.lblFirstName);
            this.addMemberPanel.Controls.Add(this.lblLastName);
            this.addMemberPanel.Controls.Add(this.txtFirstName);
            this.addMemberPanel.Controls.Add(this.txtAddress);
            this.addMemberPanel.Controls.Add(this.txtCity);
            this.addMemberPanel.Controls.Add(this.txtZip);
            this.addMemberPanel.Controls.Add(this.txtEmail);
            this.addMemberPanel.Controls.Add(this.txtLastName);
            this.addMemberPanel.Location = new System.Drawing.Point(-1, 1);
            this.addMemberPanel.Name = "addMemberPanel";
            this.addMemberPanel.Size = new System.Drawing.Size(440, 262);
            this.addMemberPanel.TabIndex = 0;
            // 
            // btnCancelAddMember
            // 
            this.btnCancelAddMember.Location = new System.Drawing.Point(225, 221);
            this.btnCancelAddMember.Name = "btnCancelAddMember";
            this.btnCancelAddMember.Size = new System.Drawing.Size(203, 28);
            this.btnCancelAddMember.TabIndex = 11;
            this.btnCancelAddMember.Text = "Cancel";
            this.btnCancelAddMember.UseVisualStyleBackColor = true;
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(3, 221);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(206, 28);
            this.btnAddMember.TabIndex = 10;
            this.btnAddMember.Text = "OK";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(310, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(155, 153);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(22, 13);
            this.lblZip.TabIndex = 10;
            this.lblZip.Text = "Zip";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(46, 153);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 9;
            this.lblCity.Text = "City";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(310, 84);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(139, 84);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(34, 84);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(119, 100);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 5;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(225, 100);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(212, 20);
            this.txtAddress.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(13, 169);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 7;
            this.txtCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCity_KeyPress);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(119, 169);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 20);
            this.txtZip.TabIndex = 8;
            this.txtZip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtZip_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(225, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(13, 100);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Envelope Number";
            // 
            // txtEnvelopeNumber
            // 
            this.txtEnvelopeNumber.Location = new System.Drawing.Point(17, 37);
            this.txtEnvelopeNumber.Name = "txtEnvelopeNumber";
            this.txtEnvelopeNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEnvelopeNumber.TabIndex = 2;
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 262);
            this.Controls.Add(this.addMemberPanel);
            this.Name = "AddMember";
            this.Text = "AddMember";
            this.addMemberPanel.ResumeLayout(false);
            this.addMemberPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addMemberPanel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnCancelAddMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.TextBox txtEnvelopeNumber;
        private System.Windows.Forms.Label label1;
    }
}