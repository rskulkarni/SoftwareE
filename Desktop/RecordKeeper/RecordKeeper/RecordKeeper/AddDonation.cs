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
    public partial class AddDonation : Form
    {
        public frmDonations ThefrmDonations { get; set; }
        public frmMain ThefrmMain { get; set; }
        connRecordkeeperData donationsData = new connRecordkeeperData();
        Donation donation = new Donation();
        public AddDonation(frmDonations _frmDonations)
        {
            ThefrmDonations = _frmDonations;
            InitializeComponent();
        }

        private void AddDonations_Click(object sender, EventArgs e)
        {
            //insert Members

            Donation donation = new Donation();
            donation.EnvelopeNo = int.Parse(txtDonationEnvNum.Text);
            donation.FundNumber = int.Parse(txtDonationsFundNum.Text);
            donation.Fundamount = float.Parse(txtDonationsFundAmt.Text);
            donation.MoneyType = txtDonMoneyType.Text;
            donation.Description = txtDonationsSpecDesc.Text;
            donationsData.insertDonation(donation);
            
            this.Close();
        }
    }
}
