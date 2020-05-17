using GTAutosClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer = (clsCustomer)Session["ACustomer"];
        Response.Write("Customer ID: " + ACustomer.CustomerID + "</br>");
        Response.Write("First name: " + ACustomer.CustomerFirstName + "</br>");
        Response.Write("Last name: " + ACustomer.CustomerLastName + "</br>");
        Response.Write("Tel: " + ACustomer.CustomerPhoneNumber + "</br>");
        Response.Write("Address: " + ACustomer.Address + "</br>");
        Response.Write("Email: " + ACustomer.CustomerEmail + "</br>");
        Response.Write("Password: " + ACustomer.CustomerPassword + "</br>");
        Response.Write("Postcode: " + ACustomer.PostCode + "</br>");
        Response.Write("Date of birth: " + ACustomer.CustomerDOB + "</br>");
        Response.Write("Marketing: " + ACustomer.Marketing + "</br>");
        Response.Write("Postcode: " + ACustomer.PostCode + "</br>");
        Response.Write("Date added: " + ACustomer.DateAdded + "</br>");
        Response.Write("Active: " + ACustomer.Active + "</br>");
    }
}