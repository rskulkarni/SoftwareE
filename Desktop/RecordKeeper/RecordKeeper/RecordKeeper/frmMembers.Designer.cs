namespace RecordKeeper
{
    partial class frmMembers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveMember = new System.Windows.Forms.Button();
            this.viewMembersGrid = new System.Windows.Forms.Button();
            this.btneditMember = new System.Windows.Forms.Button();
            this.deleteFrmMem = new System.Windows.Forms.Button();
            this.btnAddFrmMem = new System.Windows.Forms.Button();
            this.dataGridMembers = new System.Windows.Forms.DataGridView();
            this.txtFilterMembers = new System.Windows.Forms.TextBox();
            this.lblFilterMembers = new System.Windows.Forms.Label();
            this.printMembers = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnloadExcelMem = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExportExcel);
            this.panel1.Controls.Add(this.btnloadExcelMem);
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.lblFilterMembers);
            this.panel1.Controls.Add(this.txtFilterMembers);
            this.panel1.Controls.Add(this.btnSaveMember);
            this.panel1.Controls.Add(this.viewMembersGrid);
            this.panel1.Controls.Add(this.btneditMember);
            this.panel1.Controls.Add(this.deleteFrmMem);
            this.panel1.Controls.Add(this.btnAddFrmMem);
            this.panel1.Controls.Add(this.dataGridMembers);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 266);
            this.panel1.TabIndex = 0;
            // 
            // btnSaveMember
            // 
            this.btnSaveMember.Location = new System.Drawing.Point(281, 156);
            this.btnSaveMember.Name = "btnSaveMember";
            this.btnSaveMember.Size = new System.Drawing.Size(70, 43);
            this.btnSaveMember.TabIndex = 9;
            this.btnSaveMember.Text = "Save";
            this.btnSaveMember.UseVisualStyleBackColor = true;
            this.btnSaveMember.Click += new System.EventHandler(this.btnSaveMember_Click);
            // 
            // viewMembersGrid
            // 
            this.viewMembersGrid.Location = new System.Drawing.Point(3, 156);
            this.viewMembersGrid.Name = "viewMembersGrid";
            this.viewMembersGrid.Size = new System.Drawing.Size(99, 43);
            this.viewMembersGrid.TabIndex = 8;
            this.viewMembersGrid.Text = "View Members";
            this.viewMembersGrid.UseVisualStyleBackColor = true;
            this.viewMembersGrid.Click += new System.EventHandler(this.viewMembersGrid_Click);
            // 
            // btneditMember
            // 
            this.btneditMember.Location = new System.Drawing.Point(200, 155);
            this.btneditMember.Name = "btneditMember";
            this.btneditMember.Size = new System.Drawing.Size(75, 43);
            this.btneditMember.TabIndex = 7;
            this.btneditMember.Text = "Edit";
            this.btneditMember.UseVisualStyleBackColor = true;
            this.btneditMember.Click += new System.EventHandler(this.btneditMember_Click);
            // 
            // deleteFrmMem
            // 
            this.deleteFrmMem.Location = new System.Drawing.Point(357, 155);
            this.deleteFrmMem.Name = "deleteFrmMem";
            this.deleteFrmMem.Size = new System.Drawing.Size(72, 43);
            this.deleteFrmMem.TabIndex = 3;
            this.deleteFrmMem.Text = "Delete";
            this.deleteFrmMem.UseVisualStyleBackColor = true;
            this.deleteFrmMem.Click += new System.EventHandler(this.deleteFrmMem_Click);
            // 
            // btnAddFrmMem
            // 
            this.btnAddFrmMem.Location = new System.Drawing.Point(108, 155);
            this.btnAddFrmMem.Name = "btnAddFrmMem";
            this.btnAddFrmMem.Size = new System.Drawing.Size(86, 43);
            this.btnAddFrmMem.TabIndex = 1;
            this.btnAddFrmMem.Text = "Add Member";
            this.btnAddFrmMem.UseVisualStyleBackColor = true;
            this.btnAddFrmMem.Click += new System.EventHandler(this.btnAddFrmMem_Click);
            // 
            // dataGridMembers
            // 
            this.dataGridMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMembers.Location = new System.Drawing.Point(0, 0);
            this.dataGridMembers.Name = "dataGridMembers";
            this.dataGridMembers.Size = new System.Drawing.Size(745, 150);
            this.dataGridMembers.TabIndex = 0;
            this.dataGridMembers.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridMembers_CellValidating);
            this.dataGridMembers.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridMembers_EditingControlShowing);
            // 
            // txtFilterMembers
            // 
            this.txtFilterMembers.Location = new System.Drawing.Point(12, 234);
            this.txtFilterMembers.Name = "txtFilterMembers";
            this.txtFilterMembers.Size = new System.Drawing.Size(598, 20);
            this.txtFilterMembers.TabIndex = 10;
            this.txtFilterMembers.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFilterMembers_KeyUp);
            // 
            // lblFilterMembers
            // 
            this.lblFilterMembers.AutoSize = true;
            this.lblFilterMembers.Location = new System.Drawing.Point(27, 215);
            this.lblFilterMembers.Name = "lblFilterMembers";
            this.lblFilterMembers.Size = new System.Drawing.Size(75, 13);
            this.lblFilterMembers.TabIndex = 11;
            this.lblFilterMembers.Text = "Filter Members";
            // 
            // printMembers
            // 
            this.printMembers.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printMembers_PrintPage);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(435, 155);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(68, 42);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnloadExcelMem
            // 
            this.btnloadExcelMem.Location = new System.Drawing.Point(509, 156);
            this.btnloadExcelMem.Name = "btnloadExcelMem";
            this.btnloadExcelMem.Size = new System.Drawing.Size(75, 43);
            this.btnloadExcelMem.TabIndex = 13;
            this.btnloadExcelMem.Text = "Load from Excel";
            this.btnloadExcelMem.UseVisualStyleBackColor = true;
            this.btnloadExcelMem.Click += new System.EventHandler(this.btnloadExcelMem_Click);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Location = new System.Drawing.Point(590, 156);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(75, 41);
            this.btnExportExcel.TabIndex = 14;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // frmMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(748, 266);
            this.Controls.Add(this.panel1);
            this.Name = "frmMembers";
            this.Text = "frmMembers";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMembers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteFrmMem;
        private System.Windows.Forms.Button btnAddFrmMem;
        private System.Windows.Forms.Button btneditMember;
        private System.Windows.Forms.Button viewMembersGrid;
        private System.Windows.Forms.Button btnSaveMember;
        public System.Windows.Forms.DataGridView dataGridMembers;
        private System.Windows.Forms.TextBox txtFilterMembers;
        private System.Windows.Forms.Label lblFilterMembers;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printMembers;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnloadExcelMem;

    }
}