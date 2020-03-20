using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;


public partial class AnOrder : System.Web.UI.Page
{
    Int32 OrderID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1) 
            {
                DisplayOrders();
            }
            DisplayService();
        }

        TxtDateOfOrder.Text = DateTime.Now.Date.ToString("dd-MM-yy");
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
        string orderID = TxtOrderID.Text;
        string DateOfOrder = TxtDateOfOrder.Text;
        //string ServiceID = DropDownServices.SelectedValue;
        string OrderPrice = txtPrice.Text;
        string OrderStatus = txtOrderStatus.Text;
        string Error = "";

        Error = AnOrder.Valid(DateOfOrder, OrderPrice, OrderStatus);
        if (Error == "")
        {
            int OID = 0;
            bool canC = int.TryParse(orderID, out OID);
            if (canC == false)
            {
                AnOrder.OrderID = OrderID;
            }
            else
            {
                AnOrder.OrderID = Convert.ToInt32(TxtOrderID.Text);
            }
               
            /*if (TxtOrderID.Text == "" || Convert.ToInt32(TxtOrderID.Text) != OrderID) 
                {
                    AnOrder.OrderID = OrderID;
                }
                else 
                {
                    AnOrder.OrderID = Convert.ToInt32(TxtOrderID.Text);
                }*/

            AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            AnOrder.NumberPlate = txtCar.Text;
            AnOrder.DateOfOrder = Convert.ToDateTime(DateOfOrder);
            AnOrder.ServiceID = Convert.ToInt32(DropDownServices.SelectedValue);
            double price;
            price = Convert.ToDouble(OrderPrice);
            AnOrder.OrderPrice = price;
            AnOrder.OrderStatus = OrderStatus;
            AnOrder.PaymentID = Convert.ToInt32(TxtPaymentID.Text);
            ClsOrderCollection OrderList = new ClsOrderCollection();
            if (OrderID == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else 
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
            /* OrderList.ThisOrder = AnOrder;
             OrderList.Add();
             Session["AnOrder"] = -1; // AnOrder;
             Response.Redirect("AnOrder.aspx");*/
            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        OrderID = 0;
        Response.Redirect("AnOrder.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        ClsOrder AnOrder = new ClsOrder();
       // ClsService aService = new ClsService();
        // variable to store the primary key
        Int32 OrderID;
        // Variable to store result of the find operation.
        Boolean Found = false;
        // Get the primary key entered by the user
        if (TxtOrderID.Text.Equals(""))
        {
            OrderID = 0;
        }
        else 
        {
            OrderID = Convert.ToInt32(TxtOrderID.Text);
        }
        
        // Find the record
        Found = AnOrder.Find(OrderID);
        // If found
        if (Found == true)
        {
            txtCustomerID.Text = AnOrder.CustomerID.ToString();
            txtCar.Text = AnOrder.NumberPlate.ToString();
            TxtPaymentID.Text = AnOrder.PaymentID.ToString();
            //DropDownPayment.Text = AnOrder.PaymentID.ToString();
            TxtDateOfOrder.Text = AnOrder.DateOfOrder.Date.ToString("dd-MM-yy");
            DropDownServices.SelectedValue = AnOrder.ServiceID.ToString();
            txtPrice.Text = AnOrder.OrderPrice.ToString();
            txtOrderStatus.Text = AnOrder.OrderStatus.ToString();
            CheckBoxCompleted.Checked = AnOrder.Completed;
        }
        else
        {
            Response.Redirect("OrderError.aspx");
        }

    }

    void DisplayService()
    {
        GTAutosClasses.ClsServiceCollection Orders = new GTAutosClasses.ClsServiceCollection();
        DropDownServices.DataSource = Orders.ServiceList;
        DropDownServices.DataValueField = "ServiceID";
        DropDownServices.DataTextField = "DataField";
        DropDownServices.DataBind();
    }

    void DisplayOrders()
    {
        ClsOrderCollection Orders = new ClsOrderCollection();
        Orders.ThisOrder.Find(OrderID);

        TxtOrderID.Text = Orders.ThisOrder.OrderID.ToString();
        txtCustomerID.Text = Orders.ThisOrder.CustomerID.ToString();
        txtCar.Text = Orders.ThisOrder.NumberPlate;
        TxtPaymentID.Text = Orders.ThisOrder.PaymentID.ToString();
        DropDownServices.SelectedValue = Orders.ThisOrder.ServiceID.ToString();
        TxtDateOfOrder.Text = Orders.ThisOrder.DateOfOrder.ToString();
        txtPrice.Text = Orders.ThisOrder.OrderPrice.ToString();
        txtOrderStatus.Text = Orders.ThisOrder.OrderStatus;
        CheckBoxCompleted.Checked = Orders.ThisOrder.Completed;


    }



    protected void btnViewList_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }
}