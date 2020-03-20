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
       

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsCustomer aCustomer = new clsCustomer();
        string dateAdded = DateTime.Now.ToString();

        // Variables to store result of the find operation.
        string customerID = txtCustomerID.Text;
        string firstName = txtFirstName.Text;
        string lastName = txtLastName.Text;
        string address = txtAddress.Text;
        string postcode = txtPostcode.Text;
        string phoneNumber = txtPhoneNumber.Text;
        string password = txtPassword.Text;
        string dateOfBirth = txtDateOfBirth.Text;
        string email = txtEmail.Text;
        string Error = "";

        Error = aCustomer.Valid(firstName, lastName, phoneNumber, email, dateAdded, dateOfBirth, password, address, postcode);
        // If there is no error
        if (Error == "")
        {
            aCustomer.CustomerFirstName = firstName;
            aCustomer.CustomerLastName = lastName;
            aCustomer.CustomerID = Convert.ToInt32(customerID);
            aCustomer.CustomerPassword = password;
            aCustomer.CustomerDOB = Convert.ToDateTime(dateOfBirth);
            aCustomer.CustomerEmail = email;
            aCustomer.Address = address;
            aCustomer.PostCode = postcode;
            aCustomer.CustomerPhoneNumber = phoneNumber;
            Session["ACustomer"] = ACustomer;
            Response.Write("CustomerViewer.aspx");

        }
        else
        {
            Response.Redirect("CustomerError.aspx");
        }
    }
}