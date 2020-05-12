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
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1) 
            {
                DisplayOrders();
                //CustomerID = Convert.ToInt32(txtCustomerID.Text);
            }
            DisplayService();
            DisplayCars();
            
        }

        TxtDateOfOrder.Text = DateTime.Now.Date.ToString("dd-MM-yy");
    }

    protected void TxtOrderID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TxtCustomerID_TextChanged(object sender, EventArgs e)
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
        if (DropDownServices.SelectedIndex == DropDownServices.SelectedIndex) 
        {
            txtPrice.Text = DropDownServices.SelectedValue;
        }
        /*ClsService service = new ClsService();
        service.ServicePrice = Convert.ToDouble(DropDownServices.SelectedValue);*/
       
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
        string customerID = txtCustomerID.Text;
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

            int OIDC = 0;
            bool canCC = int.TryParse(customerID, out OIDC);
            if (canCC == false)
            {
                AnOrder.CustomerID = CustomerID;
            }
            else
            {
                AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            }

            // AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            // AnOrder.CarID = Convert.ToInt32(txtCar.Text);
            AnOrder.CarID = Convert.ToInt32(DropDownCars.SelectedValue);
            AnOrder.DateOfOrder = Convert.ToDateTime(DateOfOrder);
            AnOrder.ServiceID = Convert.ToInt32(DropDownServices.SelectedValue);
            double price;
            price = Convert.ToDouble(OrderPrice);
            AnOrder.OrderPrice = price;
            AnOrder.OrderStatus = OrderStatus;
            AnOrder.PaymentID = Convert.ToInt32(TxtPaymentID.Text);
            AnOrder.Completed = CheckBoxCompleted.Checked;
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
        /*OrderID = 0;
        Response.Redirect("AnOrder.aspx");*/
        Response.Redirect("OrderList.aspx");
    }

    void DisplayService()
    {
        GTAutosClasses.ClsServiceCollection Services = new GTAutosClasses.ClsServiceCollection();
        DropDownServices.DataSource = Services.ServiceList;
        DropDownServices.DataValueField = "ServiceID";
        DropDownServices.DataTextField = "DataField";
        DropDownServices.DataBind();
    }

    void DisplayCars()
    {
        GTAutosClasses.ClsCarCollection cars = new GTAutosClasses.ClsCarCollection();
       
        DropDownCars.DataSource = cars.CarList;
        DropDownCars.DataValueField = "CarID";
        DropDownCars.DataTextField = "DataField";
        DropDownCars.DataBind();
    }

    void DisplayOrders()
    {
        ClsOrderCollection Orders = new ClsOrderCollection();
        Orders.ThisOrder.Find(OrderID);

        TxtOrderID.Text = Orders.ThisOrder.OrderID.ToString();
        txtCustomerID.Text = Orders.ThisOrder.CustomerID.ToString();
        DropDownCars.SelectedValue = Orders.ThisOrder.CarID.ToString();
        //txtCar.Text = Orders.ThisOrder.CarID.ToString();
        TxtPaymentID.Text = Orders.ThisOrder.PaymentID.ToString();
        DropDownServices.SelectedValue = Orders.ThisOrder.ServiceID.ToString();
        TxtDateOfOrder.Text = Orders.ThisOrder.DateOfOrder.ToString();
        txtPrice.Text = Orders.ThisOrder.OrderPrice.ToString();
        txtOrderStatus.Text = Orders.ThisOrder.OrderStatus;
        CheckBoxCompleted.Checked = Orders.ThisOrder.Completed;
    }

    protected void DropDownCars_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}