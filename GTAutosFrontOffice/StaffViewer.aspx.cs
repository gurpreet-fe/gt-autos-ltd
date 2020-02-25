using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class StaffViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        // Create a new instance of ClsStaff
        ClsStaff member = new ClsStaff();
        // Get the data from the session object
        member = (ClsStaff)Session["member"];
        // Display the staff name for this entry
        Response.Write(member.StaffName);

    }
}