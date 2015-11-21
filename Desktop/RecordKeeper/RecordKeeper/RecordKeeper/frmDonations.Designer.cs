namespace RecordKeeper
{
    partial class frmDonations
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
            this.dataGridDonations = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnViewDon = new System.Windows.Forms.Button();
            this.btnDeleteDon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDonationSave = new System.Windows.Forms.Button();
            this.btnAddeditDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDonations)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridDonations
            // 
            this.dataGridDonations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDonations.Location = new System.Drawing.Point(13, 43);
            this.dataGridDonations.Name = "dataGridDonations";
            this.dataGridDonations.Size = new System.Drawing.Size(745, 148);
            this.dataGridDonations.TabIndex = 1;
            this.dataGridDonations.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDonations_RowEnter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // btnViewDon
            // 
            this.btnViewDon.Location = new System.Drawing.Point(13, 197);
            this.btnViewDon.Name = "btnViewDon";
            this.btnViewDon.Size = new System.Drawing.Size(180, 43);
            this.btnViewDon.TabIndex = 3;
            this.btnViewDon.Text = "View";
            this.btnViewDon.UseVisualStyleBackColor = true;
            this.btnViewDon.Click += new System.EventHandler(this.btnViewDon_Click);
            // 
            // btnDeleteDon
            // 
            this.btnDeleteDon.Location = new System.Drawing.Point(578, 197);
            this.btnDeleteDon.Name = "btnDeleteDon";
            this.btnDeleteDon.Size = new System.Drawing.Size(180, 43);
            this.btnDeleteDon.TabIndex = 5;
            this.btnDeleteDon.Text = "Delete";
            this.btnDeleteDon.UseVisualStyleBackColor = true;
            this.btnDeleteDon.Click += new System.EventHandler(this.btnDeleteDon_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDonationSave);
            this.panel1.Controls.Add(this.btnAddeditDon);
            this.panel1.Controls.Add(this.dataGridDonations);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.btnDeleteDon);
            this.panel1.Controls.Add(this.btnViewDon);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 243);
            this.panel1.TabIndex = 6;
            // 
            // btnDonationSave
            // 
            this.btnDonationSave.Location = new System.Drawing.Point(415, 197);
            this.btnDonationSave.Name = "btnDonationSave";
            this.btnDonationSave.Size = new System.Drawing.Size(128, 43);
            this.btnDonationSave.TabIndex = 9;
            this.btnDonationSave.Text = "Save";
            this.btnDonationSave.UseVisualStyleBackColor = true;
            this.btnDonationSave.Click += new System.EventHandler(this.btnDonationSave_Click);
            // 
            // btnAddeditDon
            // 
            this.btnAddeditDon.Location = new System.Drawing.Point(214, 197);
            this.btnAddeditDon.Name = "btnAddeditDon";
            this.btnAddeditDon.Size = new System.Drawing.Size(180, 43);
            this.btnAddeditDon.TabIndex = 8;
            this.btnAddeditDon.Text = "Add/Edit";
            this.btnAddeditDon.UseVisualStyleBackColor = true;
            this.btnAddeditDon.Click += new System.EventHandler(this.btnAddeditDon_Click);
            // 
            // frmDonations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(862, 262);
            this.Controls.Add(this.panel1);
            this.Name = "frmDonations";
            this.Text = "frmDonations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDonations)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDonations;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnViewDon;
        private System.Windows.Forms.Button btnDeleteDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddeditDon;
        private System.Windows.Forms.Button btnDonationSave;
    }
}