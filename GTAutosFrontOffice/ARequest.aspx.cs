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
        req.SellerName = txtName.Text;
        req.SellerPhoneNum = txtPhoneNum.Text;
        req.SellerEmail = txtEmail.Text;
        req.SellerAddress = txtAddress.Text;
        req.NumberPlate = Convert.ToInt32(txtNumberPlate.Text);
        req.Make = txtMake.Text;
        req.Model = txtModel.Text;
        req.Colour = txtName.Text;
        req.Description = txtDescription.Text;
        req.Price = Convert.ToInt32(txtPrice.Text);
        Session["ARequest"] = req;
        Response.Redirect("RequestViewer.aspx");
    }
}