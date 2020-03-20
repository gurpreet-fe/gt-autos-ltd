using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OfficeList : System.Web.UI.Page
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
        lstOfficeList.DataSource = Offices.OfficeList;
        lstOfficeList.DataValueField = "OfficeCode";
        lstOfficeList.DataTextField = "PostCode";
        lstOfficeList.DataBind();
    }

}