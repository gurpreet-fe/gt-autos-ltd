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
        if (lstOrderList.Items.Count < 0) 
        {
            lblError.Text = "There are no records, please try adding one";
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
            lblError.Text = "Please select a record to delete from the list";
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
            lblError.Text = "Please select a record to edit from the list";
        }

    }
    protected void btnApply_Click(object sender, EventArgs e)
    {

        if (txtOrderStatus.Text == "")
        {
            lblError.Text = "Please enter an Order status before trying to filter";
        }
        else
        {
            //lblError.Text = "";
            ClsOrderCollection Orders = new ClsOrderCollection();
            Orders.ReportByOrderStatus(txtOrderStatus.Text);
            lstOrderList.DataSource = Orders.OrderList;
            lstOrderList.DataValueField = "OrderID";
            lstOrderList.DataTextField = "allProperties";
            lstOrderList.DataBind();

            if (lstOrderList.Items.Count > 0)
            {
                lblError.Text = "";
            }
            else if (lstOrderList.Items.Count == 0) 
            {
                lblError.Text = "There are no records with the status " + txtOrderStatus.Text + " please try again";
                Orders.ReportByOrderStatus("");
                txtOrderStatus.Text = "";
                DisplayOrders();
            }
            
        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        ClsOrderCollection Orders = new ClsOrderCollection();
        Orders.ReportByOrderStatus("");
        txtOrderStatus.Text = "";
        DisplayOrders();
        lblError.Text = "";
    }

    protected void btnApply2_Click(object sender, EventArgs e)
    {

        lblError.Text = "";
        ClsOrderCollection Orders = new ClsOrderCollection();
        string orderID = txtOrderID.Text;
        int OID = 0;
        bool canC = int.TryParse(orderID, out OID);
        if (canC == false)
        {
            lblError.Text = "Please enter a valid OrderID";
        }
        else
        {
            Orders.ReportByOrderID(Convert.ToInt32(txtOrderID.Text));
        }

        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "allProperties";
        lstOrderList.DataBind();

        if (lstOrderList.Items.Count <= 0)
        {
            lblError.Text = "There are no records with the OrderID: " + txtOrderID.Text;
        }
    }



    protected void btnClear2_Click(object sender, EventArgs e)
    {
        ClsOrderCollection Orders = new ClsOrderCollection();
        txtOrderID.Text = "";
        DisplayOrders();
        lblError.Text = "";
    }
}

