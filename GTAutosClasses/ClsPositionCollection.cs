using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTAutosClasses
{
    public class ClsPositionCollection
    {
        List<ClsPosition> mPositionList = new List<ClsPosition>();
        ClsPosition mThisPosition = new ClsPosition();

        public List<ClsPosition> PositionList
        {
            get { return mPositionList; }
            set { mPositionList = value; }
        }

        public int Count
        {
            get { return mPositionList.Count; }
            set { }
        }

        public ClsPosition ThisPosition
        {
            get { return mThisPosition; }
            set { mThisPosition = value; }
        }

        public ClsPositionCollection()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblPosition_SelectAll");

            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@PositionID", mThisPosition.PositionID);
            DB.AddParameter("@PositionName", mThisPosition.PositionName);
            DB.AddParameter("@Description", mThisPosition.Description);
            DB.AddParameter("@Salary", mThisPosition.Salary);

            return DB.Execute("sproc_tblPosition_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("PositionID", mThisPosition.PositionID);

            DB.Execute("sproc_tblPosition_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PositionID", mThisPosition.PositionID);
            DB.AddParameter("@PositionName", mThisPosition.PositionName);
            DB.AddParameter("@Description", mThisPosition.Description);
            DB.AddParameter("@Salary", mThisPosition.Salary);

            DB.Execute("sproc_tblPosition_Update");
        }

        public void ReportByDescription(string description)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Description", description);

            DB.Execute("sproc_tblPosition_FilterByDescription");

            PopulateArray(DB);
        }

        private void PopulateArray(clsDataConnection DB)
        {
            int index = 0;
            int recordCount;

            recordCount = DB.Count;
            mPositionList = new List<ClsPosition>();

            while (index < recordCount)
            {
                ClsPosition position = new ClsPosition();

                position.PositionID = Convert.ToInt32(DB.DataTable.Rows[index]["PositionID"]);
                position.PositionName = Convert.ToString(DB.DataTable.Rows[index]["PositionName"]);
                position.Description = Convert.ToString(DB.DataTable.Rows[index]["Description"]);
                position.Salary = Convert.ToInt32(DB.DataTable.Rows[index]["Salary"]);

                mPositionList.Add(position);

                index++;
            }
        }
    }
}
