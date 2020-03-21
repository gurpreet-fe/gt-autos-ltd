using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class DeleteOffice : System.Web.UI.Page
{
    Int32 OfficeCode;

    protected void Page_Load(object sender, EventArgs e)
    {
        OfficeCode = Convert.ToInt32(Session["OfficeCode"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsOfficeCollection OfficeBook = new clsOfficeCollection();
        OfficeBook.ThisOffice.Find(OfficeCode);
        OfficeBook.Delete();
        Response.Redirect("OfficeList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {

    }
}