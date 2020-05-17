using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class ACustomer : System.Web.UI.Page
{
    int CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            if (CustomerID != -1)
            {
                DisplayCustomers();
                
            }
        }
    }

    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ThisCustomer.Find(CustomerID);

        txtCustomerID.Text = Customers.ThisCustomer.ToString();
        txtFirstName.Text = Customers.ThisCustomer.CustomerFirstName;
        txtLastName.Text = Customers.ThisCustomer.CustomerLastName;
        txtPhoneNumber.Text = Customers.ThisCustomer.CustomerPhoneNumber;
        txtAddress.Text = Customers.ThisCustomer.Address;
        txtEmailAddress.Text = Customers.ThisCustomer.CustomerEmail;
        txtDateOfBirth.Text = Customers.ThisCustomer.CustomerDOB.ToString();
        txtPassword.Text = Customers.ThisCustomer.CustomerPassword;
        txtPostcode.Text = Customers.ThisCustomer.PostCode;
        OptInMarketingCompleted.Checked = Customers.ThisCustomer.Marketing;
        ActiveCompleted.Checked = Customers.ThisCustomer.Active;
    }

    protected void TxtFirstName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TxtLastName_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TxtDateOfBirth_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TxtAddress_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TxtPostcode_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TxtPhoneNumber_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TxtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TxtPassword_TextChanged(object sender, EventArgs e)
    {

    }
    protected void CheckBoxMarketing_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void CheckBoxActive_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        // variable to store the primary key
        Int32 CustomerID;
        // Variable to store result of the find operation.
        Boolean Found = false;
        // Get the primary key (CustomerID) entered by the user
        CustomerID = Convert.ToInt32(txtCustomerID.Text);
        // Find the record
        Found = ACustomer.Find(CustomerID);
        // If found
        if (Found == true)
        {
            txtFirstName.Text = ACustomer.CustomerFirstName;
            txtLastName.Text = ACustomer.CustomerLastName;
            txtPhoneNumber.Text = ACustomer.CustomerPhoneNumber;
            txtAddress.Text = ACustomer.Address;
            txtEmailAddress.Text = ACustomer.CustomerEmail;
            txtDateOfBirth.Text = ACustomer.CustomerDOB.ToString();
            txtPassword.Text = ACustomer.CustomerPassword;
            txtPostcode.Text = ACustomer.PostCode;
            OptInMarketingCompleted.Checked = ACustomer.Marketing;
            ActiveCompleted.Checked = ACustomer.Active;
        }
        else
        {
            Response.Redirect("CustomerError.aspx");
        }

    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        string customerID = txtCustomerID.Text;
        string customerFirstName = txtFirstName.Text;
        string customerLastName = txtLastName.Text;
        string customerPhoneNumber = txtPhoneNumber.Text;
        string customerAddress = txtAddress.Text;
        string customerEmail = txtEmailAddress.Text;
        string customerDOB = txtDateOfBirth.Text;
        string customerPassword = txtPassword.Text;
        string customerPostCode = txtPostcode.Text;
        string marketing = OptInMarketingCompleted.Checked.ToString();
        string active = ActiveCompleted.Checked.ToString();

        string Error = "";

        Error = ACustomer.Valid(customerFirstName, customerLastName, customerPhoneNumber, 
            customerAddress, customerEmail, customerDOB, customerPassword,customerPostCode, 
            marketing, ACustomer.DateAdded.ToString(), active);
        if (Error == "")
        {
            int CustID = 0;
            bool test = int.TryParse(customerID, out CustID);
            if (test == false)
            {
                ACustomer.CustomerID = Convert.ToInt32(customerID);
            }
            else
            {
                ACustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            }

            ACustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            ACustomer.CustomerFirstName = txtFirstName.Text;
            ACustomer.CustomerLastName = txtLastName.Text;
            ACustomer.CustomerPhoneNumber = txtPhoneNumber.Text;
            ACustomer.Address = txtAddress.Text;
            ACustomer.CustomerEmail = txtEmailAddress.Text;
            ACustomer.CustomerDOB = Convert.ToDateTime(txtDateOfBirth.Text);
            ACustomer.CustomerPassword = txtPassword.Text;
            ACustomer.PostCode = txtPostcode.Text;
            ACustomer.Marketing = OptInMarketingCompleted.Checked;
            ACustomer.Active = ActiveCompleted.Checked;

            clsCustomerCollection CustomerList = new clsCustomerCollection();
            if (ACustomer.CustomerID == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(ACustomer.CustomerID);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

        ACustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}