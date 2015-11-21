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
    public partial class frmDonations : Form
    {
        public frmMain ThefrmMain { get; set; }
        public AddDonation ThefrmDonations { get; set; }
        DataTable sqlTableDonations;
        SqlCommand sqlCommandDonations;
        SqlDataAdapter sqlAdapterDonations;
        SqlCommandBuilder sqlBuilderDonations;
        DataSet sqlDataSetDonations = new DataSet();
        public frmDonations(frmMain _frmMain)
        {
            ThefrmMain = _frmMain;
            InitializeComponent();
        }

        
        //private void btnAddDon_Click(object sender, EventArgs e)
        //{
        //    AddDonation objFrmAddDonation = new AddDonation(this);
        //    objFrmAddDonation.Show();

        //}

        private void dataGridDonations_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
             // Get all rows entered on each press of Enter.
            var collection = this.dataGridDonations.Rows;
            string output = "";
            foreach (DataGridViewRow row in collection)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        output += cell.Value.ToString() + " ";
                    }
                }
            }
            // Display.
            this.Text = output;
        
    
        }

        private void btnViewDon_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ROHAN-PC\SQLEXPRESS;Initial Catalog=Recordkeeper;Integrated Security=True";
            string sql = "SELECT* FROM Donation";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            sqlCommandDonations = new SqlCommand(sql, connection);
            sqlAdapterDonations = new SqlDataAdapter(sqlCommandDonations);
            sqlBuilderDonations = new SqlCommandBuilder(sqlAdapterDonations);
            sqlDataSetDonations = new DataSet();
            sqlAdapterDonations.Fill(sqlDataSetDonations, "Donation");
            sqlTableDonations = sqlDataSetDonations.Tables["Donation"];
            connection.Close();
            dataGridDonations.DataSource = sqlDataSetDonations.Tables["Donation"];
            dataGridDonations.ReadOnly = true;
            btnAddeditDon.Enabled = true;
            dataGridDonations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnAddeditDon_Click(object sender, EventArgs e)
        {
            dataGridDonations.ReadOnly = false;
            btnDonationSave.Enabled = true;
            btnAddeditDon.Enabled = false;
            btnDeleteDon.Enabled = false;
        }

        private void btnDonationSave_Click(object sender, EventArgs e)
        {
            sqlAdapterDonations.Update(sqlTableDonations);
            dataGridDonations.ReadOnly = true;
            btnDonationSave.Enabled = false;
            btnAddeditDon.Enabled = true;
            btnDeleteDon.Enabled = true;
        }

        private void btnDeleteDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridDonations.Rows.RemoveAt(dataGridDonations.SelectedRows[0].Index);
                sqlAdapterDonations.Update(sqlTableDonations);

            }
        }

        
    }
}
