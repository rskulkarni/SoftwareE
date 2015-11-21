using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordKeeper
{
    class Fund
    {
        int fundNumber;

        public int FundNumber
        {
            get { return fundNumber; }
            set { fundNumber = value; }
        }
        string fundName;

        public string FundName
        {
            get { return fundName; }
            set { fundName = value; }
        }
    }
}
