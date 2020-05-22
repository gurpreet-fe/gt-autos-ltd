using GTAutosClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeleteStaff : System.Web.UI.Page
{
    Int32 staffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        staffID = Convert.ToInt32(Session["StaffID"]);
    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        ClsStaffCollection staffCollection = new ClsStaffCollection();
        staffCollection.ThisStaff.Find(staffID);
        staffCollection.Delete();
        Response.Redirect("StaffList.aspx");
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}