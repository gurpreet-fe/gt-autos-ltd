using System;
using System.Collections.Generic;

namespace GTAutosClasses

{
	public class clsCustomerCollection
	{

		List<clsCustomer> mCustomerList = new List<clsCustomer>();
		clsCustomer mThisCustomer = new clsCustomer();

		public clsCustomerCollection()
        {

			clsDataConnection DB = new clsDataConnection();
			DB.Execute("sproc_tblCustomer_selectAll");
			generateArray(DB);
	
		}

		void generateArray(clsDataConnection DB)
		{
			Int32 index = 0;
			Int32 recordCount = 0;
			recordCount = DB.Count;
			mCustomerList = new List<clsCustomer>();

			while (index < recordCount)
			{
				clsCustomer aCustomer = new clsCustomer();
				aCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
				aCustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
				aCustomer.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
				aCustomer.CustomerPassword = Convert.ToString(DB.DataTable.Rows[0]["Password"]);
				aCustomer.Address = Convert.ToString(DB.DataTable.Rows[0]["Address"]);
				aCustomer.PostCode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
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

		public clsCustomer ThisCustomer
		{
			get
			{
				return mThisCustomer;
			}
			set
			{
				mThisCustomer = value;
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

		public int Add()
		{
			clsDataConnection DB = new clsDataConnection();

			DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
			DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
			DB.AddParameter("@CustomerLastName", mThisCustomer.CustomerLastName);
			DB.AddParameter("@Address", mThisCustomer.Address);
			DB.AddParameter("@EmailAddress", mThisCustomer.CustomerEmail);
			DB.AddParameter("@Password", mThisCustomer.CustomerPassword);
			DB.AddParameter("@Postcode", mThisCustomer.PostCode);
			DB.AddParameter("@DateOfBirth", mThisCustomer.CustomerDOB);
			DB.AddParameter("@OptInMarketing", mThisCustomer.Marketing);
			DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
			DB.AddParameter("@Active", mThisCustomer.Active);

			return DB.Execute("sproc_tblCustomer_Add");

		}

		public void Delete()
		{
			clsDataConnection DB = new clsDataConnection();
			DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
			DB.Execute("sproc_tblCustomer_Delete");
		}

		public void Update()
		{
			clsDataConnection DB = new clsDataConnection();
			// clsCustomer aCustomer = new clsCustomer();
			DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
			DB.AddParameter("@CustomerFirstName", mThisCustomer.CustomerFirstName);
			DB.AddParameter("@CustomerLastName", mThisCustomer.CustomerLastName);
			DB.AddParameter("@Address", mThisCustomer.Address);
			DB.AddParameter("@EmailAddress", mThisCustomer.CustomerEmail);
			DB.AddParameter("@Password", mThisCustomer.CustomerPassword);
			DB.AddParameter("@Postcode", mThisCustomer.PostCode);
			DB.AddParameter("@DateOfBirth", mThisCustomer.CustomerDOB);
			DB.AddParameter("@OptInMarketing", mThisCustomer.Marketing);
			DB.AddParameter("@DateAdded", mThisCustomer.DateAdded);
			DB.AddParameter("@Active", mThisCustomer.Active);

			DB.Execute("sproc_tblCustomer_Update");
		}

	}
}