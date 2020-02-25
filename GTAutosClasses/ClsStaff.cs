using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAutosClasses
{
    public class ClsStaff
    {

        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public int OfficeCode { get; set; }
        public int PositionId { get; set; }
        public int StaffContactNumber { get; set; }
        public string StaffAddress { get; set; }
        public DateTime HireDate { get; set; }
        public bool IsEmployed { get; set; }

    }
}
