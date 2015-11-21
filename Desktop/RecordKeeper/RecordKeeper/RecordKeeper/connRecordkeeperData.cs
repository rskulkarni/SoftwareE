using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;

namespace RecordKeeper
{
     class connRecordkeeperData
    {
        SqlConnection connection;
        SqlConnectionStringBuilder connStringBuilder;
        //connectionString="Data Source=ROHAN-PC\SQLEXPRESS;Initial Catalog=Recordkeeper;Integrated Security=True"
        public void ConnectTo(){
            connStringBuilder = new SqlConnectionStringBuilder();
            connStringBuilder.DataSource=@"ROHAN-PC\SQLEXPRESS";
            connStringBuilder.InitialCatalog = "Recordkeeper";
            connStringBuilder.IntegratedSecurity = true;

            connection = new SqlConnection(connStringBuilder.ToString());

        }

        public connRecordkeeperData()
        {
            ConnectTo();
        }

        public void insert(Fund funds)
        {
            try
            {
                string cmdText = "INSERT INTO dbo.Fund(FundName) VALUES(@FundName)";
                SqlCommand cmd = new SqlCommand(cmdText, connection);
                //cmd.Parameters.AddWithValue("@FundID", funds.FundNumber);
                cmd.Parameters.AddWithValue("@FundName", funds.FundName);
                connection.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(connection!=null){
                    connection.Close();

                }
            }
        }

        public DataTable AddToDataGridFunds()
        {


           
                connection.Open();
                SqlCommand command = new SqlCommand("Select * from [dbo].[Fund]", connection);
                SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Columns.Add(new DataColumn("FundID", typeof(int)));
                    dt.Columns.Add(new DataColumn("FundName", typeof(string)));
                    while (reader.Read())
                    {
                        DataRow dr = dt.NewRow();
                        //dr["Date"] = reader.GetDateTime(0);
                        dr["FundID"] = reader.GetInt32(0);
                        dr["FundName"] = reader.GetString(1);
                        dt.Rows.Add(dr);
                    }
                    reader.Close();
                    connection.Close();

                
            return dt;

        }

        public DataTable FillcmbFundNumber()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings[@"RecordKeeper.Properties.Settings.RecordkeeperConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();
            SqlCommand command = new SqlCommand("SELECT  *FROM [Recordkeeper].[dbo].[Fund]", connection);
            SqlDataReader reader = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("FundID", typeof(int)));
            dt.Columns.Add(new DataColumn("FundName", typeof(string)));
            while (reader.Read())
            {
                DataRow dr = dt.NewRow();
                //dr["Date"] = reader.GetDateTime(0);
                dr["FundID"] = reader.GetInt32(0);
                dr["FundName"] = reader.GetString(1);
              //  dr["FundName"] = reader.GetString(1);
                dt.Rows.Add(dr);
            }
            reader.Close();
            connection.Close();


            return dt;
        }

        public void DeleteFundRecord(Fund funds)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings[@"RecordKeeper.Properties.Settings.RecordkeeperConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(ConnectionString);


            try
            {
                connection.Open();
               // int Primary_Field_Value = dataGridFunds[Column_Index, Row_Index].value.Tostring();
                SqlCommand command = new SqlCommand("DELETE  FROM [Recordkeeper].[dbo].[Fund] WHERE FundID=@FundID", connection);

                command.Parameters.AddWithValue("@FundID", funds.FundNumber);
                
                command.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(connection!=null)
                    connection.Close();

            }
        }

        public void Update(Fund oldFund,Fund newFund)
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings[@"RecordKeeper.Properties.Settings.RecordkeeperConnectionString"].ConnectionString;
            SqlConnection connection = new SqlConnection(ConnectionString);


            try
            {
                connection.Open();
                // int Primary_Field_Value = dataGridFunds[Column_Index, Row_Index].value.Tostring();
                SqlCommand command = new SqlCommand("UPDATE[Recordkeeper].[dbo].[Fund] SET FundName=@FundName WHERE FundID=@FundID", connection);

                command.Parameters.AddWithValue("@FundName", newFund.FundName);
                command.Parameters.AddWithValue("@FundID", oldFund.FundNumber);
                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection != null)
                    connection.Close();

            }
        }
         //------------------------Members----------------------------------
        public void insertMembers(Member member)
        {
            try
            {
                string cmdText = "INSERT INTO dbo.Donor(EnvelopeNumber,LastName,FirstName,Address,City,Zip,email) VALUES(@EnvelopeNumber,@LastName,@FirstName,@Address,@City,@Zip,@email)";
                SqlCommand cmd = new SqlCommand(cmdText, connection);
                cmd.Parameters.AddWithValue("@EnvelopeNumber", member.EnvelopeNo);
                cmd.Parameters.AddWithValue("@LastName", member.LastName);
                cmd.Parameters.AddWithValue("@FirstName", member.FirstName);
                cmd.Parameters.AddWithValue("@Address", member.Address);
                cmd.Parameters.AddWithValue("@City", member.City);
                cmd.Parameters.AddWithValue("@Zip", member.Zip);
                cmd.Parameters.AddWithValue("@email", member.Email);
                connection.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();

                }
            }
        }


        public DataTable AddToDataGridMembers()
        {



            connection.Open();
            SqlCommand command = new SqlCommand("Select * from [dbo].[Donor]", connection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("EnvelopeNumber", typeof(int)));
            dt.Columns.Add(new DataColumn("LastName", typeof(string)));
            dt.Columns.Add(new DataColumn("FirstName", typeof(string)));
            dt.Columns.Add(new DataColumn("Address", typeof(string)));
            dt.Columns.Add(new DataColumn("City", typeof(string)));
            dt.Columns.Add(new DataColumn("Zip", typeof(int)));
            dt.Columns.Add(new DataColumn("email", typeof(string)));
            while (reader.Read())
            {
                DataRow dr = dt.NewRow();
                //dr["Date"] = reader.GetDateTime(0);
                dr["EnvelopeNumber"] = reader.GetInt32(0);
                dr["LastName"] = reader.GetString(1);
                dr["FirstName"] = reader.GetString(2);
                dr["Address"] = reader.GetString(3);
                dr["City"] = reader.GetString(4);
                dr["Zip"] = reader.GetInt32(5);
                dr["email"] = reader.GetString(6);
                dt.Rows.Add(dr);
            }
            reader.Close();
            connection.Close();


            return dt;

        }
         //------------------------------Donations------------------------------
        public void insertDonation(Donation donation)
        {
            try
            {
                string cmdText = "INSERT INTO dbo.Donation(EnvelopeNumber,FundID,Amount,MoneyType,Description) VALUES(@EnvelopeNumber,@FundID,@Amount,@MoneyType,@Description)";
                SqlCommand cmd = new SqlCommand(cmdText, connection);
                //cmd.Parameters.AddWithValue("@FundID", funds.FundNumber);
                //cmd.Parameters.AddWithValue("@DonationID", donation.DonationID);
                cmd.Parameters.AddWithValue("@EnvelopeNumber", donation.EnvelopeNo);
                cmd.Parameters.AddWithValue("@FundID", donation.FundNumber);
                cmd.Parameters.AddWithValue("@Amount", donation.Fundamount);
                cmd.Parameters.AddWithValue("@MoneyType", donation.MoneyType);
                cmd.Parameters.AddWithValue("@Description", donation.Description);
                connection.Open();
                cmd.ExecuteNonQuery();
            }

            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();

                }
            }
        }
         //------------------------Back up/Restore---------------------------------------------------
        public void BackupDatabase(string backUpFile)
        {
            ServerConnection serverConnection = new ServerConnection(@"ROHAN-PC\SQLEXPRESS");
            Server myServer = new Server(serverConnection);
            Backup source = new Backup();
            source.Action = BackupActionType.Database;
            source.Database = "RecordKeeper";
            BackupDeviceItem destination = new BackupDeviceItem(backUpFile, DeviceType.File);
            source.Devices.Add(destination);
            source.SqlBackup(myServer);
            serverConnection.Disconnect();
        }

        public  void RestoreDatabase(string backUpFile)
        {
            ServerConnection serverConnection = new ServerConnection(@"ROHAN-PC\SQLEXPRESS");
            Server myServer = new Server(serverConnection);
            Restore destination = new Restore();
            destination.Action = RestoreActionType.Database;
            destination.Database = "RecordKeeper";
            BackupDeviceItem source = new BackupDeviceItem(backUpFile, DeviceType.File);
            destination.Devices.Add(source);
            destination.ReplaceDatabase = true;
            destination.SqlRestore(myServer);
        }
    
    }
}
