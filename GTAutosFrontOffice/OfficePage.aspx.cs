using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        //OK Button
        OfficeClasses AnOffice = new OfficeClasses();
        AnOffice.OfficeCode = Convert.ToInt32(txtOfficeCode.Text);
        AnOffice.AddressLine1 = txtAddressLine1.Text;
        AnOffice.AddressLine2 = txtAddressLine2.Text;
        AnOffice.City = txtCity.Text;
        //AnOffice.PhoneNumber = Convert.ToInt64(txtPhoneNumber);
        AnOffice.PhoneNumber = txtPhoneNumber.Text;
        AnOffice.PostCode = txtPostCode.Text;
        //AnOffice.IsActive = IsActive;
        AnOffice.InspectionDate = Convert.ToDateTime( txtInspectionDate.Text);
        Session["AnOffice"] = AnOffice;
        Response.Redirect("OfficeView.aspx");

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //Cancel Button

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        //OfficeCode
        
    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {
        //AddressLine1

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {
        //Address Line 2

    }

    protected void TextBox4_TextChanged(object sender, EventArgs e)
    {
        //city
    }

    protected void TextBox5_TextChanged(object sender, EventArgs e)
    {
        //postcode
    }

    protected void TextBox6_TextChanged(object sender, EventArgs e)
    {
        //phone number
    }

    protected void TextBox8_TextChanged(object sender, EventArgs e)
    {
        //isActive
    }

    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {
        //inspection date
    }



    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
}