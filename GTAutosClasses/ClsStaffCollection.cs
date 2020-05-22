using System;
using System.Collections.Generic;

namespace GTAutosClasses
{
    public class ClsStaffCollection
    {
        List<ClsStaff> mStaffList = new List<ClsStaff>();
        ClsStaff mThisStaff = new ClsStaff();

        public List<ClsStaff> StaffList
        {
            get { return mStaffList; }
            set { mStaffList = value; }
        }

        public int Count
        {
            get { return StaffList.Count; }
            set { }
        }

        public ClsStaff ThisStaff
        {
            get { return mThisStaff; }
            set { mThisStaff = value; }
        }


        public ClsStaffCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@OfficeCode", mThisStaff.OfficeCode);
            DB.AddParameter("@PositionID", mThisStaff.PositionID);
            DB.AddParameter("@ContactNumber", mThisStaff.ContactNumber);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@HireDate", mThisStaff.HireDate);
            DB.AddParameter("@IsEmployed", mThisStaff.IsEmployed);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("StaffID", mThisStaff.StaffID);

            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffID", mThisStaff.StaffID);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@OfficeCode", mThisStaff.OfficeCode);
            DB.AddParameter("@PositionID", mThisStaff.PositionID);
            DB.AddParameter("@ContactNumber", mThisStaff.ContactNumber);
            DB.AddParameter("@Address", mThisStaff.Address);
            DB.AddParameter("@HireDate", mThisStaff.HireDate);
            DB.AddParameter("@IsEmployed", mThisStaff.IsEmployed);

            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByContactNumber(string contactNumber)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ContactNumber", contactNumber);

            DB.Execute("sproc_tblStaff_FilterByContactNumber");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 index = 0;
            Int32 recordCount;

            recordCount = DB.Count;
            mStaffList = new List<ClsStaff>();

            while (index < recordCount)
            {
                ClsStaff member = new ClsStaff();

                member.StaffID = Convert.ToInt32(DB.DataTable.Rows[index]["StaffID"]);
                member.StaffName = Convert.ToString(DB.DataTable.Rows[index]["StaffName"]);
                member.OfficeCode = Convert.ToInt32(DB.DataTable.Rows[index]["OfficeCode"]);
                member.PositionID = Convert.ToInt32(DB.DataTable.Rows[index]["PositionID"]);
                member.ContactNumber = Convert.ToString(DB.DataTable.Rows[index]["ContactNumber"]);
                member.Address = Convert.ToString(DB.DataTable.Rows[index]["Address"]);
                member.HireDate = Convert.ToDateTime(DB.DataTable.Rows[index]["HireDate"]);
                member.IsEmployed = Convert.ToBoolean(DB.DataTable.Rows[index]["IsEmployed"]);

                mStaffList.Add(member);

                index++;
            }
        }
    }
}