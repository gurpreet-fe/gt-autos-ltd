using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class AnService : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnAdd_Click(object sender, EventArgs e)
    {
        ClsService AnService = new ClsService();
        string ServiceName = TxtServiceName.Text;
        string ServiceDesc = TxtServiceDesc.Text;
        string ServicePrice = TxtServicePrice.Text;

        string Error = "";
        ;
        Error = AnService.Valid(ServiceName, ServiceDesc, ServicePrice);
        if (Error == "") 
        {
            AnService.ServiceName = TxtServiceName.Text;
            AnService.ServiceDescription = TxtServiceDesc.Text;

            double price;
            price = Convert.ToDouble(ServicePrice);
            AnService.ServicePrice = price;
            ClsServiceCollection ServiceList = new ClsServiceCollection();
            ServiceList.ThisService = AnService;
            ServiceList.Add();
            Session["ServiceID"] = -1;
            Response.Redirect("AnService.aspx");
        }
        else
        {
            lblError.Text = Error;
        }

    }
}