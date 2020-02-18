using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
            //create a new instance of clsOffice
            OfficeClasses AnOffice = new OfficeClasses();
            //get the data from the session object
            AnOffice = (OfficeClasses)Session["AnOffice"];
            //display the office code for this entry
            Response.Write(AnOffice.OfficeCode);
        
    }
}