using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class CustomerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayCustomers();
        }
        if (lstCustomerList.Items.Count == 0)
        {
            lblError.Text = "There are no existing customers.";
        }
    }
    void DisplayCustomers()
    {
        GTAutosClasses.clsCustomerCollection Customers = new GTAutosClasses.clsCustomerCollection();
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "Postcode";
        lstCustomerList.DataBind();
    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;
        Response.Redirect("ACustomer.aspx");
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        int CustomerID;

        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("DeleteCustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select the record to be deleted";
        }
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        int CustomerID;

        if (lstCustomerList.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("ACustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select a valid CustomerID to edit";
        }

    }
    protected void BtnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();

        lblError.Text = "";
        string CustomerID = txtCustomerID.Text;
        int ID = 0;
        bool test = int.TryParse(CustomerID, out ID);
        if (test == false)
        {
            lblError.Text = "Please enter a valid Customer ID";
        }
        else
        {
            ID = Convert.ToInt32(CustomerID);
            Customers.ReportByCustomerID(ID);
        }

        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerID";
        lstCustomerList.DataTextField = "allProperties";
        lstCustomerList.DataBind();

        if (lstCustomerList.Items.Count <= 0)
        {
            lblError.Text = "There are no customers with the ID " + CustomerID;
        }
    }


    protected void BtnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        txtCustomerID.Text = "";
        DisplayCustomers();
        lblError.Text = "";
    }
}
