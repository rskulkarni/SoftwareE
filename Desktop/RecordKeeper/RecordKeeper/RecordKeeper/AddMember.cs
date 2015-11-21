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
    public partial class AddMember : Form
    {
        public frmMembers ThefrmMembers { get; set; }
        public frmMain ThefrmMain { get; set; }
        connRecordkeeperData membersData = new connRecordkeeperData();
        Member members = new Member();
        public AddMember(frmMembers _frmMembers)
        {
            ThefrmMembers = _frmMembers;
            InitializeComponent();
            //connRecordkeeperData membersData = new connRecordkeeperData();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            
            frmMembers objfrmMemberToAdd = new frmMembers(ThefrmMain);
            
             //insert Members
            
                Member member = new Member();
                member.EnvelopeNo = int.Parse(txtEnvelopeNumber.Text);
                member.LastName = txtLastName.Text;
                member.FirstName = txtFirstName.Text;
                member.Address = txtAddress.Text;
                member.City = txtCity.Text;
                member.Zip = int.Parse(txtZip.Text);
                member.Email = txtEmail.Text;
                membersData.insertMembers(member);
                this.Close();
           
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            
              if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
                base.OnKeyPress(e);

        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
                base.OnKeyPress(e);

        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
                e.Handled = true;
            base.OnKeyPress(e);

        }

        private void txtZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
       
    }
}
