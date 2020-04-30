using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class Default2 : System.Web.UI.Page
{
    Int32 OfficeCode;

    protected void Page_Load(object sender, EventArgs e)
    {
        OfficeCode = Convert.ToInt32(Session["OfficeCode"]);
        if (IsPostBack == false)
        {
            if (OfficeCode != -1)
            {
                DisplayOffice();
            }
        }
    }

    void DisplayOffice()
    {
        clsOfficeCollection OfficeBook = new clsOfficeCollection();
        OfficeBook.ThisOffice.Find(OfficeCode);
        txtOfficeCode.Text = OfficeBook.ThisOffice.OfficeCode.ToString();
        txtAddressLine1.Text = OfficeBook.ThisOffice.AddressLine1;
        txtAddressLine2.Text = OfficeBook.ThisOffice.AddressLine2;
        txtCity.Text = OfficeBook.ThisOffice.City;
        txtPostCode.Text = OfficeBook.ThisOffice.PostCode;
        txtPhoneNumber.Text = OfficeBook.ThisOffice.PhoneNumber;
        txtInspectionDate.Text = OfficeBook.ThisOffice.InspectionDate.ToShortDateString();
        ChkBox.Checked = OfficeBook.ThisOffice.IsActive;
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
            AnOffice.OfficeCode = OfficeCode;
            AnOffice.AddressLine1 = AddressLine1;
            AnOffice.AddressLine2 = AddressLine2;
            AnOffice.City = City;
            AnOffice.PhoneNumber = PhoneNumber;
            AnOffice.PostCode = PostCode;
            AnOffice.InspectionDate = Convert.ToDateTime(InspectionDate);
            AnOffice.IsActive = ChkBox.Checked;
            clsOfficeCollection OfficeList = new clsOfficeCollection();
            OfficeList.ThisOffice = AnOffice;

            if (OfficeCode == -1)
            {
                OfficeList.ThisOffice = AnOffice;
                OfficeList.Add();
            }
            else
            {
                OfficeList.ThisOffice.Find(OfficeCode);
                OfficeList.ThisOffice = AnOffice;
                OfficeList.Update();
            }
            Response.Redirect("OfficeList.aspx");
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
        //isActive nope
    }

    protected void TextBox7_TextChanged(object sender, EventArgs e)
    {
        //inspection date

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

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        //check box isActive
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        //find button
        OfficeClasses AnOffice = new OfficeClasses();
        Int32 OfficeCode;
        Boolean Found = false;
        OfficeCode = Convert.ToInt32( txtOfficeCode.Text);
        Found = AnOffice.Find(OfficeCode);
        if (Found == true)
        {
            txtAddressLine1.Text = AnOffice.AddressLine1;
            txtAddressLine2.Text = AnOffice.AddressLine2;
            txtCity.Text = AnOffice.City;
            txtPostCode.Text = AnOffice.PostCode;
            txtPhoneNumber.Text = AnOffice.PhoneNumber;
            txtInspectionDate.Text = AnOffice.InspectionDate.ToShortDateString();
            ChkBox.Checked = AnOffice.IsActive;
        }
    }
}