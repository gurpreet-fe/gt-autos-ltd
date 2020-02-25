using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class StaffPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        // Create a new instance of ClsStaff
        ClsStaff member = new ClsStaff();
        // Get the data from the session object
        member = (ClsStaff)Session["member"];
        // Display the house number for this entry
        Response.Write(member.StaffName);

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of ClsStaff
        ClsStaff member = new ClsStaff();
        // Capture the staff name
        member.StaffName = TxtStaffName.Text;
        // Capture the office code
        member.OfficeCode = int.Parse(TxtOfficeCode.Text);
        // Capture the position id
        member.PositionId = int.Parse(TxtPositionId.Text);
        // Capture the contact number
        member.StaffContactNumber = int.Parse(TxtStaffContactNumber.Text);
        // Capture the staff address
        member.StaffAddress = TxtStaffAddress.Text;
        // Capture the hire date
        member.HireDate = Convert.ToDateTime(TxtHireDate);
        // Capture the employement status
        member.IsEmployed = CBIsEmployed.Checked;

        // Store the name in the session object
        Session["member"] = member;
        // Redirect to the viewer page
        Response.Redirect("StaffViewer.aspx");

    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

}