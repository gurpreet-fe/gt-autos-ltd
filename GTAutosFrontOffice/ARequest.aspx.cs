using GTAutosClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ARequest : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsRequest req = new clsRequest();
        req.RequestId = Convert.ToInt32(txtRequestID.Text);
        req.SellerName = txtName.Text;
        req.SellerPhoneNum = txtPhoneNum.Text;
        req.SellerEmail = txtEmail.Text;
        req.SellerAddress = txtAddress.Text;
        req.NumberPlate = txtNumberPlate.Text;
        req.Make = txtMake.Text;
        req.Model = txtModel.Text;
        req.Colour = txtName.Text;
        req.Description = txtDescription.Text;
        req.Price = Convert.ToDouble(txtPrice.Text);
        req.DateOfPurchased = Convert.ToDateTime(txtDateOfPurchased.Text);
        req.DateOfRequest = Convert.ToDateTime(txtDateOfRequest.Text);
        req.Request = Convert.ToBoolean(txtRequest.Text);
        req.Purchased = Convert.ToBoolean(txtPurchased);

        Session["ARequest"] = req;
        Response.Redirect("RequestViewer.aspx");
    }

    protected void Active_CheckedChanged(object sender, EventArgs e)
    {

    }
}