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
        req.SellerPhoneNum = Convert.ToInt32(txtPhoneNum.Text);
        req.SellerEmail = txtName.Text;
        req.SellerAddress = txtName.Text;
        req.NumberPlate = Convert.ToInt32(txtPhoneNum.Text);
        req.Make = txtName.Text;
        req.Model = txtName.Text;
        req.Colour = txtName.Text;
        req.Description = txtName.Text;
        req.Price = Convert.ToInt32(txtPhoneNum.Text);
        Session["ARequest"] = req;
        Response.Redirect("RequestViewer.aspx");
    }
}