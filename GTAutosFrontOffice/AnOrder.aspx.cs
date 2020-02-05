using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       // GTAutosClasses.ClsOrder
    }

    protected void TxtOrderID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TxtCustomerID_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtCar_TextChanged(object sender, EventArgs e)
    {

    }

    protected void DropDownPayment_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DropDownDates_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void DropDownServices_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void txtPrice_TextChanged(object sender, EventArgs e)
    {

    }

    protected void txtOrderStatus_TextChanged(object sender, EventArgs e)
    {

    }

    protected void CheckBoxCompleted_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        ClsOrder AnOrder = new ClsOrder();
        AnOrder.OrderID = Convert.ToInt32(TxtOrderID.Text);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("OrderViewer.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
       
    }
}