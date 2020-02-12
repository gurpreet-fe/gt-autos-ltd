using System;

namespace GTAutosClasses
{
    public class clsRequest
    {
        public int RequestId { get; set; }
        public string SellerName { get; set; }
        public string SellerEmail { get; set; }
        public int SellerPhoneNum { get; set; }
        public string SellerAddress { get; set; }
        public int NumberPlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime DateOfRequest { get; set; }
        public DateTime DateOfPurchased { get; set; }
        public bool Purchased { get; set; }
        public bool Request { get; set; }
    }
}