using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

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

    protected void btnFind_Click(object sender, EventArgs e)
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
            txtAddress.Text = ACustomer.Address;
            txtPostcode.Text = ACustomer.PostCode;
            txtPhoneNumber.Text = ACustomer.CustomerPhoneNumber;
            txtCustomerID.Text = ACustomer.CustomerID.ToString();
            txtPassword.Text = ACustomer.CustomerPassword;
            OptInMarketingCompleted.Checked = ACustomer.Marketing;
        }
        else
        {
            Response.Redirect("CustomerError.aspx");
        }

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }
}