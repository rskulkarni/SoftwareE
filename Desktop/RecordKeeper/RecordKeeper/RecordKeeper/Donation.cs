using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeper
{
    class Donation
    {
        int donationID;

        public int DonationID
        {
            get { return donationID; }
            set { donationID = value; }
        }
        int envelopeNo;

        public int EnvelopeNo
        {
            get { return envelopeNo; }
            set { envelopeNo = value; }
        }
        int fundNumber;

        public int FundNumber
        {
            get { return fundNumber; }
            set { fundNumber = value; }
        }
        string moneyType;

        public string MoneyType
        {
            get { return moneyType; }
            set { moneyType = value; }
        }
        float fundamount;

        public float Fundamount
        {
            get { return fundamount; }
            set { fundamount = value; }
        }
        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
