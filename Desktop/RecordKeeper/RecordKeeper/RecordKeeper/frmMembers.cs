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
    public partial class frmMembers : Form
    {
        public frmMain ThefrmMain { get; set; }
        connRecordkeeperData membersData = new connRecordkeeperData();
        Member members = new Member();
        DataTable sqlDataTableMembers;
        SqlCommand sqlCommandMembers;
        SqlDataAdapter sqlCommandAdapter;
        SqlCommandBuilder sqlCommandBuilder;
        DataSet sqlDataSetMembers=new DataSet();
        //string ConnectionString = ConfigurationManager.ConnectionStrings[@"RecordKeeper.Properties.Settings.RecordkeeperConnectionString"].ConnectionString;
      //  SqlConnection connection = new SqlConnection(ConnectionString);
        public frmMembers(frmMain _frmMain)
        {
            ThefrmMain = _frmMain;
           
            InitializeComponent();
            btnSaveMember.Enabled = false;
            btneditMember.Enabled = false;
            deleteFrmMem.Enabled = false;
        }

        private void btnAddFrmMem_Click(object sender, EventArgs e)
        {
            AddMember objFrmAddMember = new AddMember(this);
            objFrmAddMember.Show();
        }

        private void viewMembersGrid_Click(object sender, EventArgs e)
        {

            //DataTable dt2 = membersData.AddToDataGridMembers();

            //dataGridMembers.DataSource = dt2;

            string connectionString = @"Data Source=ROHAN-PC\SQLEXPRESS;Initial Catalog=Recordkeeper;Integrated Security=True";
            string sql = "SELECT * FROM Donor";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            sqlCommandMembers = new SqlCommand(sql, connection);
            sqlCommandAdapter = new SqlDataAdapter(sqlCommandMembers);
            sqlCommandBuilder = new SqlCommandBuilder(sqlCommandAdapter);
            sqlDataSetMembers = new DataSet();
            sqlCommandAdapter.Fill(sqlDataSetMembers, "Donor");
            sqlDataTableMembers = sqlDataSetMembers.Tables["Donor"];
            connection.Close();
            dataGridMembers.DataSource = sqlDataSetMembers.Tables["Donor"];
            dataGridMembers.ReadOnly = true;
            btnSaveMember.Enabled = false;
            btneditMember.Enabled = true;
            dataGridMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

       

        private void btnSaveMember_Click(object sender, EventArgs e)
        {
            sqlCommandAdapter.Update(sqlDataTableMembers);
            dataGridMembers.ReadOnly = true;
            btnSaveMember.Enabled = false;
            btneditMember.Enabled = true;
            deleteFrmMem.Enabled = true;
        }

        private void deleteFrmMem_Click(object sender, EventArgs e)
        {
            
           
            if (MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridMembers.Rows.RemoveAt(dataGridMembers.SelectedRows[0].Index);
                sqlCommandAdapter.Update(sqlDataTableMembers);

            }
        }

        private void btneditMember_Click(object sender, EventArgs e)
        {
            dataGridMembers.ReadOnly = false;
            btnSaveMember.Enabled = true;
            btnAddFrmMem.Enabled = false;
            deleteFrmMem.Enabled = false;
        }

        private void dataGridMembers_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //string sCellName = dataGridMembers.Columns[5].Name;
           
            //        if(sCellName == "Zip")
            //    {

            //         e.Control.KeyPress += new KeyPressEventHandler(CheckKey); 

            //     }
        }

        private void CheckKey(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void dataGridMembers_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string headerText =dataGridMembers.Columns[e.ColumnIndex].HeaderText;
           // Confirm that the cell is not empty.
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dataGridMembers.Rows[e.RowIndex].ErrorText = " Name must not be empty";
                e.Cancel = true;
            }
        }

        private void txtFilterMembers_KeyUp(object sender, KeyEventArgs e)
        {
            string connectionString = @"Data Source=ROHAN-PC\SQLEXPRESS;Initial Catalog=Recordkeeper;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            sqlCommandMembers = connection.CreateCommand();
            sqlCommandMembers.CommandType = CommandType.Text;
            sqlCommandMembers.CommandText = "SELECT * FROM Donor WHERE LastName like('" + txtFilterMembers.Text + "%')";
            sqlCommandMembers.ExecuteNonQuery();
            DataTable dtFilter = new DataTable();
            sqlCommandAdapter = new SqlDataAdapter(sqlCommandMembers);
            sqlCommandAdapter.Fill(dtFilter);
            dataGridMembers.DataSource = dtFilter;
            
            connection.Close();
        }

        private void printMembers_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridMembers.Width, this.dataGridMembers.Height);
            dataGridMembers.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridMembers.Width, this.dataGridMembers.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printMembers.Print();
        }

        private void btnloadExcelMem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
