using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAutosClasses
{
    public class ClsService
    {
        private string pServiceID;
        private string pServiceDesc;
        private double pServicePrice;

        public string ServiceID
        {
            get
            {
                return pServiceID;
            }
            set
            {
                pServiceID = value;
            }
        }

        public string ServiceDescription
        {
            get
            {
                return pServiceDesc;
            }
            set
            {
                pServiceDesc = value;
            }
        }

        public double ServicePrice
        {
            get
            {
                return pServicePrice;
            }
            set
            {
                pServicePrice = value;
            }
        }
    }
}
