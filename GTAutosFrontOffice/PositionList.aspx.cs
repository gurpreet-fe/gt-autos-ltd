using GTAutosClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PositionList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayPosition();
        }
    }

    void DisplayPosition()
    {
        ClsPositionCollection positions = new ClsPositionCollection();

        LbPositionList.DataSource = positions.PositionList;
        LbPositionList.DataValueField = "PositionID";
        LbPositionList.DataTextField = "Description";
        LbPositionList.DataBind();
    }

    protected void LbPositionList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        Session["PositionID"] = -1;
        Response.Redirect("PositionID.aspx");
    }

    protected void BtnEdit_Click(object sender, EventArgs e)
    {
        int positionID;

        if (LbPositionList.SelectedIndex != -1)
        {
            positionID = Convert.ToInt32(LbPositionList.SelectedValue);
            Session["PositionID"] = positionID;
            Response.Redirect("PositionPage.aspx");
        }
        else
        {
            LblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void BtnDelete_Click(object sender, EventArgs e)
    {
        int positionID;

        if (LbPositionList.SelectedIndex != -1)
        {
            positionID = Convert.ToInt32(LbPositionList.SelectedValue);
            Session["PositionID"] = positionID;
            Response.Redirect("DeletePosition.aspx");
        }
        else
        {
            LblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void TxtDescriptionFilter_Changed(object sender, EventArgs e)
    {

    }

    protected void BtnApply_Click(object sender, EventArgs e)
    {
        ClsPositionCollection positions = new ClsPositionCollection();

        positions.ReportByDescription(TbDescriptionFilter.Text);
        LbPositionList.DataSource = positions.PositionList;
        LbPositionList.DataValueField = "PositionID";
        LbPositionList.DataTextField = "Description";
        LbPositionList.DataBind();
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        ClsPositionCollection positions = new ClsPositionCollection();
        
        positions.ReportByDescription(TbDescriptionFilter.Text);
        TbDescriptionFilter.Text = "";

        LbPositionList.DataSource = positions.PositionList;
        LbPositionList.DataValueField = "PositionID";
        LbPositionList.DataTextField = "Description";
        LbPositionList.DataBind();
    }
}