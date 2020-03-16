using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class CarList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayAddress();
        }
    }

    void DisplayAddress()
    {
        GTAutosClasses.ClsCarCollection AllCars = new GTAutosClasses.ClsCarCollection();
        lstCarList.DataSource = AllCars.CarList;
        lstCarList.DataValueField = "NumberPlate";
        lstCarList.DataTextField = "Make";
        lstCarList.DataBind();
    }
}