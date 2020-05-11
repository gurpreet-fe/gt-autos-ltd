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
        if (IsPostBack == false)
        {
            DisplayOffices();
        }
    }

    void DisplayOffices()
    {
        GTAutosClasses.clsOfficeCollection Offices = new GTAutosClasses.clsOfficeCollection();
        lstOffices.DataSource = Offices.OfficeList;
        lstOffices.DataValueField = "OfficeCode";
        lstOffices.DataTextField = "PostCode";
        lstOffices.DataBind();
    }

    protected void lstOffices_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Back_Click(object sender, EventArgs e)
    {
        Response.Redirect("OfficePage.aspx");
    }
}