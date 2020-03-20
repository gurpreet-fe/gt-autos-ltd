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
        OfficeClasses AnOffice = new OfficeClasses();
        string AddressLine1 = txtAddressLine1.Text;
        string AddressLine2 = txtAddressLine2.Text;
        string City = txtCity.Text;
        string PostCode = txtPostCode.Text;
        string PhoneNumber = txtPhoneNumber.Text;
        string InspectionDate = txtInspectionDate.Text;
        string Error = "";
        Error = AnOffice.Valid(AddressLine1, AddressLine2, City, PostCode, PhoneNumber, InspectionDate);
        if (Error == "")
        {
            AnOffice.AddressLine1 = AddressLine1;
            AnOffice.AddressLine2 = AddressLine2;
            AnOffice.City = City;
            AnOffice.PostCode = PostCode;
            AnOffice.InspectionDate = Convert.ToDateTime(InspectionDate);
            Session["AnOffice"] = AnOffice;
            Response.Write("OfficeView.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //Cancel Button
        Response.Redirect("OfficePage.aspx");

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
        //lblError
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //viewer button
        Response.Redirect("OfficeView.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        //List button
        Response.Redirect("OfficeList.aspx");
    }
}