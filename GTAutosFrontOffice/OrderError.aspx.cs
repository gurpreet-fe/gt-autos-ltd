using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class OrderError : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //AnOrder.OrderID = Convert.ToInt32(TxtOrderID.Text);
        //Session["AnOrder"] = AnOrder;
        Response.Write("This Order does not exist " + "</br>");
    }
    protected void btnTryAgain_Click1(object sender, EventArgs e)
    {
        Response.Redirect("AnOrder.aspx");
    }
}