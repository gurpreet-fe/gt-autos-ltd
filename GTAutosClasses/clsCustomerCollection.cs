using System;
using GTAutosClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace GTAutosClasses

{
	public class clsCustomerCollection
	{

		List<clsCustomer> mCustomerList = new List<clsCustomer>();

		public List<clsCustomer> CustomerList
		{
			get
			{
				return mCustomerList;
			}
			set
			{
				mCustomerList = value;
			}
		}

		public int Count
		{
			get
			{
				return mCustomerList.Count;
			}
			set
			{
				//to complete
			}

		}

		public clsCustomerCollection()
        {
			Int32 index = 0;
			Int32 recordCount = 0;
			clsCustomerCollection DB = new clsCustomerCollection();
			DB.Execute("sproc_tblCustomer_selectAll");
			recordCount = DB.Count;
            while (index < recordCount)
            {
				clsCustomer aCustomer = new clsCustomer();
				aCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
				aCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
				aCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
				aCustomer.CustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
				aCustomer.Address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
				aCustomer.Postcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
				aCustomer.CustomerFirstName = Convert.ToString(DB.DataTable.Rows[0]["CustomerFirstName"]);
				aCustomer.CustomerLastName = Convert.ToString(DB.DataTable.Rows[0]["CustomerLastName"]);
				aCustomer.CustomerPhoneNumber = Convert.ToString(DB.DataTable.Rows[0]["PhoneNumber"]);
				aCustomer.CustomerEmail = Convert.ToString(DB.DataTable.Rows[0]["EmailAddress"]);
				aCustomer.CustomerDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfBirth"]);
				aCustomer.Marketing = Convert.ToBoolean(DB.DataTable.Rows[0]["OptInMarketing"]);

				mCustomerList.Add(aCustomer);
				index++;
			}

		}

	}
}