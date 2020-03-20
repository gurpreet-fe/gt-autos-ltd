using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }

    protected void lstOrderList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    void DisplayOrders()
    {
        GTAutosClasses.ClsOrderCollection Orders = new GTAutosClasses.ClsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "allProperties";
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        int OrderID;

        if (lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("DeleteOrder.aspx");
        }
        else
        {
            lblError.Text = "pleases select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        int OrderID;

        if (lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("AnOrder.aspx");
        }
        else
        {
            lblError.Text = "pleases select a record to edit from the list";
        }

    }
    protected void btnApply_Click(object sender, EventArgs e)
    {
        ClsOrderCollection Orders = new ClsOrderCollection();
        Orders.ReportByOrderStatus(txtOrderStatus.Text);
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "allProperties";
        lstOrderList.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClsOrderCollection Orders = new ClsOrderCollection();
        Orders.ReportByOrderStatus("");
        txtOrderStatus.Text = "";
        DisplayOrders();
    }
}
