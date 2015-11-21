namespace RecordKeeper
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnFormFunds = new System.Windows.Forms.Button();
            this.btnFormMembers = new System.Windows.Forms.Button();
            this.btnFormDonations = new System.Windows.Forms.Button();
            this.btnFormReports = new System.Windows.Forms.Button();
            this.picSimbaTech = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblFrmMain = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picSimbaTech)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFormFunds
            // 
            this.btnFormFunds.Location = new System.Drawing.Point(14, 14);
            this.btnFormFunds.Name = "btnFormFunds";
            this.btnFormFunds.Size = new System.Drawing.Size(75, 41);
            this.btnFormFunds.TabIndex = 0;
            this.btnFormFunds.Text = "Funds";
            this.btnFormFunds.UseVisualStyleBackColor = true;
            this.btnFormFunds.Click += new System.EventHandler(this.btnFormFunds_Click);
            // 
            // btnFormMembers
            // 
            this.btnFormMembers.Location = new System.Drawing.Point(14, 61);
            this.btnFormMembers.Name = "btnFormMembers";
            this.btnFormMembers.Size = new System.Drawing.Size(75, 41);
            this.btnFormMembers.TabIndex = 1;
            this.btnFormMembers.Text = "Members";
            this.btnFormMembers.UseVisualStyleBackColor = true;
            this.btnFormMembers.Click += new System.EventHandler(this.btnFormMembers_Click);
            // 
            // btnFormDonations
            // 
            this.btnFormDonations.Location = new System.Drawing.Point(14, 108);
            this.btnFormDonations.Name = "btnFormDonations";
            this.btnFormDonations.Size = new System.Drawing.Size(75, 41);
            this.btnFormDonations.TabIndex = 2;
            this.btnFormDonations.Text = "Donations";
            this.btnFormDonations.UseVisualStyleBackColor = true;
            this.btnFormDonations.Click += new System.EventHandler(this.btnFormDonations_Click);
            // 
            // btnFormReports
            // 
            this.btnFormReports.Location = new System.Drawing.Point(14, 155);
            this.btnFormReports.Name = "btnFormReports";
            this.btnFormReports.Size = new System.Drawing.Size(75, 41);
            this.btnFormReports.TabIndex = 3;
            this.btnFormReports.Text = "Reports";
            this.btnFormReports.UseVisualStyleBackColor = true;
            // 
            // picSimbaTech
            // 
            this.picSimbaTech.Image = ((System.Drawing.Image)(resources.GetObject("picSimbaTech.Image")));
            this.picSimbaTech.Location = new System.Drawing.Point(138, 14);
            this.picSimbaTech.Name = "picSimbaTech";
            this.picSimbaTech.Size = new System.Drawing.Size(177, 189);
            this.picSimbaTech.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSimbaTech.TabIndex = 4;
            this.picSimbaTech.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRestore);
            this.panel1.Controls.Add(this.btnBackUp);
            this.panel1.Controls.Add(this.lblAppName);
            this.panel1.Controls.Add(this.lblFrmMain);
            this.panel1.Controls.Add(this.picSimbaTech);
            this.panel1.Controls.Add(this.btnFormReports);
            this.panel1.Controls.Add(this.btnFormFunds);
            this.panel1.Controls.Add(this.btnFormDonations);
            this.panel1.Controls.Add(this.btnFormMembers);
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 284);
            this.panel1.TabIndex = 5;
            // 
            // btnBackUp
            // 
            this.btnBackUp.Location = new System.Drawing.Point(14, 202);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(75, 41);
            this.btnBackUp.TabIndex = 8;
            this.btnBackUp.Text = "Back Up";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(156, 238);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(143, 24);
            this.lblAppName.TabIndex = 7;
            this.lblAppName.Text = "Recordkeeper";
            // 
            // lblFrmMain
            // 
            this.lblFrmMain.AutoSize = true;
            this.lblFrmMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmMain.Location = new System.Drawing.Point(134, 214);
            this.lblFrmMain.Name = "lblFrmMain";
            this.lblFrmMain.Size = new System.Drawing.Size(185, 24);
            this.lblFrmMain.TabIndex = 6;
            this.lblFrmMain.Text = "Simba Technology";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(14, 250);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 31);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 318);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.picSimbaTech)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFormFunds;
        private System.Windows.Forms.Button btnFormMembers;
        private System.Windows.Forms.Button btnFormDonations;
        private System.Windows.Forms.Button btnFormReports;
        private System.Windows.Forms.PictureBox picSimbaTech;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFrmMain;
        private System.Windows.Forms.Button btnBackUp;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Button btnRestore;
    }
}

