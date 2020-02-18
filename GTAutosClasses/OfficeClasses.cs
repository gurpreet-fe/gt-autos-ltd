using System;

namespace GTAutosClasses
{
    public class OfficeClasses
    {
        public int OfficeCode { get; set; }
        public bool IsActive { get; set; }
        public DateTime InspectionDate { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }

        //public bool Find(int officeCode)
        //{
        //throw new NotImplementedException();
        //}
    }
}