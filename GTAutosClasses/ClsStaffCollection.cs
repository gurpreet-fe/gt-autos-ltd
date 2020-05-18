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
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@OfficeCode", mThisStaff.OfficeCode);
            DB.AddParameter("@PositionId", mThisStaff.PositionId);
            DB.AddParameter("@StaffContactNumber", mThisStaff.StaffContactNumber);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@HireDate", mThisStaff.HireDate);
            DB.AddParameter("@IsEmployed", mThisStaff.IsEmployed);

            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("StaffId", mThisStaff.StaffId);

            DB.Execute("sproc_tblStaff_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffId", mThisStaff.StaffId);
            DB.AddParameter("@StaffName", mThisStaff.StaffName);
            DB.AddParameter("@OfficeCode", mThisStaff.OfficeCode);
            DB.AddParameter("@PositionId", mThisStaff.PositionId);
            DB.AddParameter("@StaffContactNumber", mThisStaff.StaffContactNumber);
            DB.AddParameter("@StaffAddress", mThisStaff.StaffAddress);
            DB.AddParameter("@HireDate", mThisStaff.HireDate);
            DB.AddParameter("@IsEmployed", mThisStaff.IsEmployed);

            DB.Execute("sproc_tblStaff_Update");
        }

        public void ReportByContactNumber(string contactNumber)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StaffContactNumber", contactNumber);

            DB.Execute("sproc_tblStaff_FiltereByStaffContactNumber");

            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            int index = 0;
            int recordCount;

            recordCount = DB.Count;
            mStaffList = new List<ClsStaff>();

            while (index < recordCount)
            {
                ClsStaff member = new ClsStaff();

                member.StaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                member.StaffName = Convert.ToString(DB.DataTable.Rows[0]["StaffName"]);
                member.OfficeCode = Convert.ToInt32(DB.DataTable.Rows[0]["OfficeCode"]);
                member.PositionId = Convert.ToInt32(DB.DataTable.Rows[0]["PositionId"]);
                member.StaffContactNumber = Convert.ToString(DB.DataTable.Rows[0]["ContactNumber"]);
                member.StaffAddress = Convert.ToString(DB.DataTable.Rows[0]["StaffAddress"]);
                member.HireDate = Convert.ToDateTime(DB.DataTable.Rows[0]["StaffHireDate"]);
                member.IsEmployed = Convert.ToBoolean(DB.DataTable.Rows[0]["IsEmployed"]);

                mStaffList.Add(member);

                index++;
            }
        }
    }
}