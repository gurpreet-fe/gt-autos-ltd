using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsOrder AnOrder = new ClsOrder();
        AnOrder = (ClsOrder)Session["AnOrder"];
        Response.Write(AnOrder.OrderID + "</br>);
        Response.Write(AnOrder.CustomerID + "</br>);

    }
}