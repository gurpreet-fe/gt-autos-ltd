using GTAutosClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OfficeList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOffices();
        }
    }

    void DisplayOffices()
    {
        GTAutosClasses.clsOfficeCollection Offices = new GTAutosClasses.clsOfficeCollection();
        lstOfficeList.DataSource = Offices.OfficeList;
        lstOfficeList.DataValueField = "OfficeCode";
        lstOfficeList.DataTextField = "PostCode";
        lstOfficeList.DataBind();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["OfficeCode"] = -1;
        //redirect to the data entry page
        Response.Redirect("OfficePage.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OfficeCode;
        //if a record has been slected from the list
        if (lstOfficeList.SelectedIndex != -1)
        {
            OfficeCode = Convert.ToInt32(lstOfficeList.SelectedValue);
            Session["OfficeCode"] = OfficeCode;
            Response.Redirect("DeleteOffice.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 OfficeCode;
        //if a record has been slected from the list
        if (lstOfficeList.SelectedIndex != -1)
        {
            OfficeCode = Convert.ToInt32(lstOfficeList.SelectedValue);
            Session["OfficeCode"] = OfficeCode;
            Response.Redirect("OfficePage.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        clsOfficeCollection Offices = new clsOfficeCollection();
        Offices.ReportByPostCode(txtFilter.Text);
        lstOfficeList.DataSource = Offices.OfficeList;
        lstOfficeList.DataValueField = "OfficeCode";
        lstOfficeList.DataTextField = "PostCode";
        lstOfficeList.DataBind();
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        clsOfficeCollection Offices = new clsOfficeCollection();
        Offices.ReportByPostCode("");
        txtFilter.Text = "";
        lstOfficeList.DataSource = Offices.OfficeList;
        lstOfficeList.DataValueField = "OfficeCode";
        lstOfficeList.DataTextField = "PostCode";
        lstOfficeList.DataBind();
    }
}