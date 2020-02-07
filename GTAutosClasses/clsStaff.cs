using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAutosClasses
{
    public class clsStaff
    {
        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public int OfficeId { get; set; }
        public int PositionId { get; set; }
        public int ContactNumber { get; set; }
        public string StaffAddress { get; set; }
        public DateTime HireDate { get; set; }
        public Boolean IsEmployed { get; set; }

    }
}
