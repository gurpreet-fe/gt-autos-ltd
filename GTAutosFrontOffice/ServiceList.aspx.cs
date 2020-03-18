using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ServiceList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false) 
        {
            DisplayServices();
        }
    }


    void DisplayServices()
    {
        GTAutosClasses.ClsServiceCollection Orders = new GTAutosClasses.ClsServiceCollection();
        lstServiceList.DataSource = Orders.ServiceList;
        lstServiceList.DataValueField = "ServiceID";
        lstServiceList.DataTextField = "DataField";
        lstServiceList.DataBind();
    }
    protected void lstServiceList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ServiceID"] = -1;
        Response.Redirect("AnOrder.aspx");
    }
}