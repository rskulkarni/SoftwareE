using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeper
{
    class Member
    {
        int envelopeNo;

        public int EnvelopeNo
        {
            get { return envelopeNo; }
            set { envelopeNo = value; }
        }


        string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        string firstName;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }


        string address;

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        
        string city;

        public string City
        {
            get { return city; }
            set { city = value; }
        }
        int zip;

        public int Zip
        {
            get { return zip; }
            set { zip = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


    }
}
