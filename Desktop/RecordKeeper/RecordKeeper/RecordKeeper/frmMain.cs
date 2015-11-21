using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
namespace RecordKeeper
{
    public partial class frmMain : Form
    {
        connRecordkeeperData fullBackUpDatabase = new connRecordkeeperData();
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFormFunds_Click(object sender, EventArgs e)
        {
            frmFunds objFrmFund = new frmFunds(this);
            objFrmFund.Show();
        }

        private void btnFormMembers_Click(object sender, EventArgs e)
        {
            frmMembers objFrmMembers = new frmMembers(this);
            objFrmMembers.Show();
        }

        private void btnFormDonations_Click(object sender, EventArgs e)
        {
            frmDonations objFrmDonations = new frmDonations(this);
            objFrmDonations.Show();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {


            fullBackUpDatabase.BackupDatabase("Recordkeeper");
        }

        //Don't test this right now
        private void btnRestore_Click(object sender, EventArgs e)
        {
           // fullBackUpDatabase.RestoreDatabase("Recordkeeper");
        }
    }
}
