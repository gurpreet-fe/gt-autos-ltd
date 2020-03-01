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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ClsRequest req = new ClsRequest();
        req.RequestId = Convert.ToInt32(txtRequestID.Text);
        req.SellerName = txtName.Text;
        req.SellerPhoneNum = txtPhoneNum.Text;
        req.SellerEmail = txtEmail.Text;
        req.SellerAddress = txtAddress.Text;
        req.NumberPlate = txtNumberPlate.Text;
        req.Make = txtMake.Text;
        req.Model = txtModel.Text;
        req.Colour = txtColour.Text;
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



    protected void btnFind_Click(object sender, EventArgs e)
    {
        ClsRequest req = new ClsRequest();
        Int32 RequestId;
        Boolean Found = false;
        RequestId = Convert.ToInt32(txtRequestID.Text);
        Found = req.Find(RequestId);
        if (Found == true)
        {
            txtName.Text = req.SellerName;
            txtPhoneNum.Text = req.SellerPhoneNum;
            txtEmail.Text = req.SellerEmail;
            txtAddress.Text = req.SellerAddress;
            txtNumberPlate.Text = req.NumberPlate;
            txtMake.Text = req.Make;
            txtModel.Text = req.Model;
            txtColour.Text = req.Colour;
            txtDescription.Text = req.Description;
            txtPrice.Text = req.Price.ToString();
            txtDateOfPurchased.Text = req.DateOfPurchased.ToString();
            txtDateOfRequest.Text = req.DateOfRequest.ToString();
            txtRequest.Text = req.Request.ToString();
            txtPurchased.Text = req.Purchased.ToString();

        }
    }
}