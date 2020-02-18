using System;

namespace GTAutosClasses
{
    public class clsRequest
    {
        public int RequestId { get; set; }
        public String SellerName { get; set; }
        public String SellerEmail { get; set; }
        public String SellerPhoneNum { get; set; }
        public String SellerAddress { get; set; }
        public String NumberPlate { get; set; }
        public String Make { get; set; }
        public String Model { get; set; }
        public String Colour { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
        public DateTime DateOfRequest { get; set; }
        public DateTime DateOfPurchased { get; set; }
        public bool Purchased { get; set; }
        public bool Request { get; set; }
    }
}