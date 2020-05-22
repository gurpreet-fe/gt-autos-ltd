using GTAutosClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StaffList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayStaff();
        }
    }

    void DisplayStaff()
    {
        ClsStaffCollection members = new ClsStaffCollection();

        LbStaffList.DataSource = members.StaffList;
        LbStaffList.DataValueField = "StaffID";
        LbStaffList.DataTextField = "ContactNumber";
        LbStaffList.DataBind();
    }

    protected void LbStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["StaffID"] = -1;
        Response.Redirect("StaffPage.aspx");
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        Int32 staffID;

        if (LbStaffList.SelectedIndex != -1)
        {
            staffID = Convert.ToInt32(LbStaffList.SelectedValue);
            Session["StaffID"] = staffID;
            Response.Redirect("StaffPage.aspx");
        }
        else
        {
            LblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        int staffID;

        if (LbStaffList.SelectedIndex != -1)
        {
            staffID = Convert.ToInt32(LbStaffList.SelectedValue);
            Session["StaffID"] = staffID;
            Response.Redirect("DeleteStaff.aspx");
        }
        else
        {
            LblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void TbContactNumberFilter_Changed(object sender, EventArgs e)
    {
        
    }

    protected void BtnApply_Click(object sender, EventArgs e)
    {
        ClsStaffCollection members = new ClsStaffCollection();

        members.ReportByContactNumber(TbContactNumberFilter.Text);
        LbStaffList.DataSource = members.StaffList;
        LbStaffList.DataValueField = "StaffID";
        LbStaffList.DataTextField = "ContactNumber";
        LbStaffList.DataBind();
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        ClsStaffCollection members = new ClsStaffCollection();

        members.ReportByContactNumber("");
        TbContactNumberFilter.Text = "";

        LbStaffList.DataSource = members.StaffList;
        LbStaffList.DataValueField = "StaffID";
        LbStaffList.DataTextField = "ContactNumber";
        LbStaffList.DataBind();
    }
}