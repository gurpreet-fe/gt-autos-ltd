using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAutosClasses
{
    public class ClsOrder
    {
        private int pOrderID;
        private int pCustomerID;
        private String pCardID;
        private int pPaymentID;
        private DateTime pDateOfOrder;
        private String pServiceID;
        private double pOrderPrice;
        private String pOrderStatus;
        private Boolean pCompleted;
        public int OrderID 
        {
            get 
            {
                return pOrderID;
            }
            set
            {
                pOrderID = value;
            }
        }
        public int CustomerID 
        { 
            get 
            {
                return pCustomerID;
            } 
            set 
            {
                pCustomerID = value;
            } 
        }
        public String CarID 
        { 
            get 
            {
                return pCardID;
            }
            set
            {
                pCardID = value;
            } 
        }
        public DateTime DateOfOrder 
        {
            get 
            {
                return pDateOfOrder;          
            } 
            set 
            {
                pDateOfOrder = value;   
            } 
        }
        public String ServiceID 
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
        public double OrderPrice 
        {
            get 
            {
                return pOrderPrice;
            } 
            set 
            {
                pOrderPrice = value;
            } 
        }
        public String OrderStatus 
        {
            get 
            {
                return pOrderStatus;
            }
            set 
            {
                pOrderStatus = value;
            } 
        }
        public int PaymentID 
        {
            get 
            {
                return pPaymentID;
            } 
            set 
            {
                pPaymentID = value;
            } 
        }
        public bool Completed 
        {
            get 
            {
                return pCompleted;
            } 
            set 
            {
                pCompleted = value;   
            } 
        }

        public bool Find(int OrderID)
        {
            pOrderID = 1;
            pCustomerID = 1;
            pCardID = "MP04XTT";
            pPaymentID = 1;
            pDateOfOrder = DateTime.Now.Date;
            pServiceID = "MOT";
            pOrderPrice = 20.5;
            pOrderStatus = "Completed";
            pCompleted = true;
            return true;
        }
    }
}