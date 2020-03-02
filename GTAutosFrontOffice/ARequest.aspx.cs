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

        String SellerName = txtName.Text;
        String SellerPhoneNum = txtPhoneNum.Text;
        String SellerEmail = txtEmail.Text;
        String SellerAddress = txtAddress.Text;
        String NumberPlate = txtNumberPlate.Text;
        String Make = txtMake.Text;
        String Model = txtModel.Text;
        String Colour = txtColour.Text;
        String Description = txtDescription.Text;
        String Price = txtPrice.Text;
        String DateOfPurchase = txtDateOfPurchase.Text;
        String DateOfRequest = txtDateOfRequest.Text;
        String Error = "";

        Error = req.Valid(SellerName, SellerEmail, SellerPhoneNum, SellerAddress, NumberPlate, Make, Model, Description, Colour, Price, DateOfPurchase, DateOfRequest);
        if (Error == "")
        {
            req.SellerName = SellerName;
            req.SellerPhoneNum = SellerPhoneNum;
            req.SellerEmail = SellerEmail;
            req.SellerAddress = SellerAddress;
            req.NumberPlate = NumberPlate;
            req.Make = Make;
            req.Model = Model;
            req.Colour = Colour;
            req.Description = Description;
            req.Price = Convert.ToDouble(Price);
            req.DateOfPurchase = Convert.ToDateTime(DateOfPurchase);
            req.DateOfRequest = Convert.ToDateTime(DateOfRequest);
            Session["ARequest"] = req;
            Response.Redirect("RequestViewer.aspx");

        }
        else
        {
            lblError.Text = Error;
        }

        
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
            txtDateOfPurchase.Text = req.DateOfPurchase.ToString();
            txtDateOfRequest.Text = req.DateOfRequest.ToString();



        }
    }

    protected void Request_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void Purchased_CheckedChanged(object sender, EventArgs e)
    {

    }
}

