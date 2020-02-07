using System;

namespace GTAutosClasses
{
    public class Customer
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int AddressNo { get; set; }
        public int CountyNo { get; set; }
        public string HouseNo { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public int CustomerID { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerEmail { get; set; }
        public DateTime CustomerDOB { get; set; }
        public bool Marketing { get; set; }
    }
}