using System;
using System.Activities.Expressions;
using System.Activities.Validation;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class StaffPage : System.Web.UI.Page
{
    int staffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        staffID = Convert.ToInt32(Session["StaffID"]);

        if (IsPostBack == false)
        {
            if (staffID != -1)
            {
                DisplayStaff();
            }
        }
    }

    void DisplayStaff()
    {
        ClsStaffCollection members = new ClsStaffCollection();

        members.ThisStaff.Find(staffID);

        TbStaffID.Text = members.ThisStaff.StaffID.ToString();
        TbStaffName.Text = members.ThisStaff.StaffName;
        TbOfficeCode.Text = members.ThisStaff.OfficeCode.ToString();
        TbPositionID.Text = members.ThisStaff.PositionID.ToString();
        TbContactNumber.Text = members.ThisStaff.ContactNumber;
        TbAddress.Text = members.ThisStaff.Address;
        TbHireDate.Text = members.ThisStaff.HireDate.ToShortDateString();
        CbIsEmployed.Checked = members.ThisStaff.IsEmployed;
    }

    protected void TxtStaffID_Changed(object sender, EventArgs e)
    {

    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        ClsStaff member = new ClsStaff();
        int staffID;
        bool found = false;

        if (System.Text.RegularExpressions.Regex.IsMatch(TbPositionID.Text, "^[a-zA-Z]*$"))
        {
            Response.Redirect("StaffPage.aspx");
        }

        staffID = Convert.ToInt32(TbPositionID.Text);
        found = member.Find(this.staffID);

        if (found == true)
        {
            TbStaffName.Text = member.StaffName;
            TbOfficeCode.Text = member.OfficeCode.ToString();
            TbPositionID.Text = member.PositionID.ToString();
            TbContactNumber.Text = member.ContactNumber;
            TbAddress.Text = member.Address;
            TbHireDate.Text = member.HireDate.ToShortDateString();
            CbIsEmployed.Checked = member.IsEmployed;
        }


    }

    protected void TxtStaffName_Changed(object sender, EventArgs e)
    {

    }

    protected void TxtOfficeCode_Changed(object sender, EventArgs e)
    {

    }

    protected void TxtPositionID_Changed(object sender, EventArgs e)
    {

    }

    protected void TxtContactNumber_Changed(object sender, EventArgs e)
    {

    }

    protected void TxtAddress_Changed(object sender, EventArgs e)
    {

    }

    protected void TxtHireDate_Changed(object sender, EventArgs e)
    {

    }

    protected void CbIsEmployed_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        ClsStaff member = new ClsStaff();

        string staffName = TbStaffName.Text;
        string officeCode = TbOfficeCode.Text;
        string positionID = TbPositionID.Text;
        string contactNumber = TbContactNumber.Text;
        string address = TbAddress.Text;
        string hireDate = TbHireDate.Text;
        
        string error = "";
        error = member.Valid(staffName, contactNumber, address, hireDate);

        if (error == "")
        {
            member.StaffID = staffID;
            member.StaffName = staffName;
            member.OfficeCode = Convert.ToInt32(officeCode);
            member.PositionID = Convert.ToInt32(positionID);
            member.ContactNumber = contactNumber;
            member.Address = address;
            member.HireDate = Convert.ToDateTime(hireDate);
            member.IsEmployed = CbIsEmployed.Checked;

            ClsStaffCollection members = new ClsStaffCollection();

            if (staffID == -1)
            {
                members.ThisStaff = member;
                members.Add();
            } else
            {
                members.ThisStaff.Find(staffID);
                members.ThisStaff = member;
                members.Update();
            }

            Response.Redirect("StaffList.aspx");
        } else
        {
            LblError.Text = error;
        }
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffPage.aspx");
    }

    protected void BtnList_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffList.aspx");
    }
}