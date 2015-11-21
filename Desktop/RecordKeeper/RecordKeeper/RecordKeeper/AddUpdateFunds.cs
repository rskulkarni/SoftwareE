using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordKeeper
{
    public partial class AddUpdateFunds : Form
    {
        public frmFunds ThefrmFunds { get; set; }
        public frmMain ThefrmMain { get; set; }
        Fund funds;
        connRecordkeeperData fundsData;
        public AddUpdateFunds(frmFunds _frmFunds)
        {
           
            ThefrmFunds = _frmFunds;
            
            InitializeComponent();
            
            fundsData = new connRecordkeeperData();
        }
        DataTable dt = new DataTable();
        private void btnOKAddfunds_Click(object sender, EventArgs e)
        {
            frmFunds objfrmfundToAdd = new frmFunds(ThefrmMain);
            cmbFundNumber.Visible = false;
            
            //insert funds
            
                funds = new Fund();
                funds.FundName = txtFundName.Text;
                if (string.IsNullOrEmpty(this.txtFundName.Text))
                    
                   {
                       throw new ArgumentNullException("fund name can't be null");
                   }
                else
                fundsData.insert(funds);

                //add funid in combobox
                DataTable dt3 = fundsData.FillcmbFundNumber();
                cmbFundNumber.DisplayMember = "FundID";
                this.cmbFundNumber.DataSource = dt3; 
           

            this.Close();
            try
            {

                //   dt.Rows.Add(dataGridFunds.NewRowIndex,txtFundName.Text);

                //  dataGridFunds.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void txtFundName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar)﻿)
                e.Handled = true;
               base.OnKeyPress(e);
        }
        
    }
}
