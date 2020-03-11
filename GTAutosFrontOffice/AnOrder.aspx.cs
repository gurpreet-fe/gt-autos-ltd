using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;


public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrder();
        }
    }

    protected void TxtOrderID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TxtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCar_TextChanged(object sender, EventArgs e)
    {

    }

    protected void DropDownPayment_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void TxtDateOfOrder_TextChanged(object sender, EventArgs e)
    {

    }

    protected void DropDownDates_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DropDownServices_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void txtPrice_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtOrderStatus_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CheckBoxCompleted_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        // Old
        //ClsOrder AnOrder = new ClsOrder();
        //AnOrder.OrderID = Convert.ToInt32(TxtOrderID.Text);
        //AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        //AnOrder.CarID = txtCar.Text;
        //AnOrder.DateOfOrder = Convert.ToDateTime(TxtDateOfOrder.Text);
        ////AnOrder.ServiceID = DropDownServices.SelectedValue;
        //Session["AnOrder"] = AnOrder;
        //Response.Redirect("OrderViewer.aspx");
        // New
        ClsOrder AnOrder = new ClsOrder();
        string DateOfOrder = TxtDateOfOrder.Text;
        //string ServiceID = DropDownServices.SelectedValue;
        string OrderPrice = txtPrice.Text;
        string OrderStatus = txtOrderStatus.Text;
        string Error = "";

        Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
        if (Error == "")
        {
            AnOrder.OrderID = Convert.ToInt32(TxtOrderID.Text);
            AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            AnOrder.CarID = txtCar.Text;
            AnOrder.DateOfOrder = Convert.ToDateTime(DateOfOrder);
            // AnOrder.ServiceID = ServiceID;
            double price;
            price = Convert.ToDouble(OrderPrice);
            AnOrder.OrderPrice = price;
            AnOrder.OrderStatus = OrderStatus;
            Session["AnOrder"] = AnOrder;
            Response.Redirect("OrderViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        ClsOrder AnOrder = new ClsOrder();
        // variable to store the primary key
        Int32 OrderID;
        // Variable to store result of the find operation.
        Boolean Found = false;
        // Get the primary key entered by the user
        OrderID = Convert.ToInt32(TxtOrderID.Text);
        // Find the record
        Found = AnOrder.Find(OrderID);
        // If found
        if (Found == true)
        {
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtCar.Text = AnOrder.CarID.ToString();
            DropDownPayment.Text = AnOrder.PaymentID.ToString();
            TxtDateOfOrder.Text = AnOrder.DateOfOrder.Date.ToString("dd-MM-yy");
            DropDownServices.Text = AnOrder.ServiceID;
            txtPrice.Text = AnOrder.OrderPrice.ToString();
            txtOrderStatus.Text = AnOrder.OrderStatus;
            CheckBoxCompleted.Checked = AnOrder.Completed;
        }
        else
        {
            Response.Redirect("OrderError.aspx");
        }

    }

    void DisplayOrder()
    {
        GTAutosClasses.ClsServiceCollection Orders = new GTAutosClasses.ClsServiceCollection();
        DropDownServices.DataSource = Orders.ServiceList;
        DropDownServices.DataValueField = "ServiceID";
        DropDownServices.DataBind();
    }



    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }
}