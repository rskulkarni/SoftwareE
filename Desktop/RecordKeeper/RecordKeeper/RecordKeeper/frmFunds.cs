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
using System.Configuration;
namespace RecordKeeper
{
    public partial class frmFunds : Form
    {
        public frmMain ThefrmMain { get; set; }
        public frmFunds ThefrmFunds { get; set; }
        public AddUpdateFunds TheAddUpdateFunds { get; set; }
        connRecordkeeperData fundsData;
        DataTable sqlTableFunds;
        SqlCommand sqlCommandFunds;
        SqlDataAdapter sqlAdapterFunds;
        SqlCommandBuilder sqlBuilderFunds;
        DataSet sqlDataSetFunds = new DataSet();
        string ConnectionString = ConfigurationManager.ConnectionStrings[@"RecordKeeper.Properties.Settings.RecordkeeperConnectionString"].ConnectionString;
      //  SqlConnection connection = new SqlConnection(ConnectionString);
        public frmFunds(frmMain _frmMain)
        {
            ThefrmMain = _frmMain;
            InitializeComponent();
            editFund.Enabled = false;
            deleteFund.Enabled = false;
            btnSave.Enabled = false;
            fundsData = new connRecordkeeperData();
        }

        private void addFund_Click(object sender, EventArgs e)
        {
            AddUpdateFunds objFrmAddUpdateFund = new AddUpdateFunds(this);
            editFund.Enabled = true;
            deleteFund.Enabled = true;
            objFrmAddUpdateFund.cmbFundNumber.Visible = false;
            objFrmAddUpdateFund.lblFundNumber.Visible = false;
            objFrmAddUpdateFund.Show();
        
        }

       
        private void showFundGrid_Click(object sender, EventArgs e)
        {
            //add funds to datagrid from sql funds table
            
            string connectionString = @"Data Source=ROHAN-PC\SQLEXPRESS;Initial Catalog=Recordkeeper;Integrated Security=True";
            string sql = "SELECT * FROM Fund";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            sqlCommandFunds = new SqlCommand(sql, connection);
            sqlAdapterFunds = new SqlDataAdapter(sqlCommandFunds);
            sqlBuilderFunds = new SqlCommandBuilder(sqlAdapterFunds);
            sqlDataSetFunds = new DataSet();
            sqlAdapterFunds.Fill(sqlDataSetFunds, "Fund");
            sqlTableFunds = sqlDataSetFunds.Tables["Fund"];
            connection.Close();
            dataGridFunds.DataSource = sqlDataSetFunds.Tables["Fund"];
            dataGridFunds.ReadOnly = true;
            btnSave.Enabled = false;
            
            editFund.Enabled = true;
            deleteFund.Enabled = true;
            dataGridFunds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
           
        }
        
        private void deleteFund_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridFunds.Rows.RemoveAt(dataGridFunds.SelectedRows[0].Index);
                sqlAdapterFunds.Update(sqlTableFunds);

            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlAdapterFunds.Update(sqlTableFunds);
            addFund.Enabled = true;
            btnSave.Enabled = false;
            editFund.Enabled = true;
            
            deleteFund.Enabled = true;
        }

        private void editFund_Click(object sender, EventArgs e)
        {
            //AddUpdateFunds objFrmAddUpdateFund = new AddUpdateFunds(this);
            dataGridFunds.ReadOnly = false;
            btnSave.Enabled = true;
            addFund.Enabled = false;
            deleteFund.Enabled = false;
        }

        private void txtFilterFunds_KeyUp(object sender, KeyEventArgs e)
        {
             string connectionString = @"Data Source=ROHAN-PC\SQLEXPRESS;Initial Catalog=Recordkeeper;Integrated Security=True";
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            sqlCommandFunds = connection.CreateCommand();
            sqlCommandFunds.CommandType = CommandType.Text;
            sqlCommandFunds.CommandText = "SELECT * FROM Fund WHERE FundName like('" + txtFilterFunds.Text+ "%')";
            sqlCommandFunds.ExecuteNonQuery();
            DataTable dtFilter = new DataTable();
            sqlAdapterFunds = new SqlDataAdapter(sqlCommandFunds);
            sqlAdapterFunds.Fill(dtFilter);
            dataGridFunds.DataSource = dtFilter;
            connection.Close();
        }

        private void printFunds_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridFunds.Width, this.dataGridFunds.Height);
            dataGridFunds.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridFunds.Width, this.dataGridFunds.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnPrintFunds_Click(object sender, EventArgs e)
        {
            printFunds.Print();
        }

        

        
    }
}
