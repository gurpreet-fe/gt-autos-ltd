using GTAutosClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PositionPage : System.Web.UI.Page
{
    int positionID;

    protected void Page_Load(object sender, EventArgs e)
    {
        positionID = Convert.ToInt32(Session["positionID"]);

        if (IsPostBack == false)
        {
            if (positionID != -1)
            {
                DisplayPosition();
            }
        }
    }

    void DisplayPosition()
    {
        ClsPositionCollection positions = new ClsPositionCollection();

        positions.ThisPosition.Find(positionID);

        TbPositionID.Text = positions.ThisPosition.PositionID.ToString();
        TbDescription.Text = positions.ThisPosition.Description;
        TbSalary.Text = positions.ThisPosition.Salary.ToString();
    }

    protected void TxtPositionID_Changed(object sender, EventArgs e)
    {

    }

    protected void BtnFind_Click(object sender, EventArgs e)
    {
        ClsPosition position = new ClsPosition();
        int positionID;
        bool found = false;

        if (System.Text.RegularExpressions.Regex.IsMatch(TbPositionID.Text, "^[a-zA-Z]*$"))
        {
            Response.Redirect("PositionPage.aspx");
        }

        positionID = Convert.ToInt32(TbPositionID.Text);
        found = position.Find(this.positionID);

        if (found == true)
        {
            TbPositionName.Text = position.PositionName;
            TbDescription.Text = position.Description;
            TbSalary.Text = position.Salary.ToString();
        }
    }

    protected void TxtPositionName_Changed(object sender, EventArgs e)
    {

    }

    protected void TxtDescription_Changed(object sender, EventArgs e)
    {

    }

    protected void TxtSalary_Changed(object sender, EventArgs e)
    {

    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        ClsPosition position = new ClsPosition();
        string positionName = TbPositionName.Text;
        string description = TbDescription.Text;
        string salary = TbSalary.Text;

        string error = "";
        error = position.Valid(positionName, description, salary);
        if (error == "")
        {
            position.PositionID = positionID;
            position.PositionName = positionName;
            position.Description = description;
            position.Salary = Decimal.Parse(salary);

            ClsPositionCollection positionList = new ClsPositionCollection();

            if (positionID == -1)
            {
                positionList.ThisPosition = position;
                positionList.Add();
            } else
            {
                positionList.ThisPosition.Find(positionID);
                positionList.ThisPosition = position;
                positionList.Update();
            }

            Response.Redirect("PositionList.aspx");
        } else
        {
            LblError.Text = error;
        }
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("PositionPage.aspx");
    }

    protected void BtnList_Click(object sender, EventArgs e)
    {
        Response.Redirect("PositionList.aspx");
    }

}