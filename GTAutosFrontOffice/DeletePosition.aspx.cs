using GTAutosClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DeletePosition : System.Web.UI.Page
{
    int positionID;

    protected void Page_Load(object sender, EventArgs e)
    {
        positionID = Convert.ToInt32(Session["PositionID"]);
    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        ClsPositionCollection positionCollection = new ClsPositionCollection();
        positionCollection.ThisPosition.Find(positionID);
        positionCollection.Delete();
        Response.Redirect("PositionList.aspx");
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("PositionList.aspx");
    }
}