using GTAutosClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RequestViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsRequest req = new ClsRequest();
        req = (ClsRequest)Session["ARequest"];
        Response.Write(req.SellerName);
        Response.Write(req.SellerPhoneNum);
        Response.Write(req.SellerEmail);
        Response.Write(req.SellerAddress);
        Response.Write(req.NumberPlate);
        Response.Write(req.Make);
        Response.Write(req.Model);
        Response.Write(req.Description);
        Response.Write(req.Price);

    }
}