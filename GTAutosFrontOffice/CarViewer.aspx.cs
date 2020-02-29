using GTAutosClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CarViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClsCar car = new ClsCar();
        car = (ClsCar)Session["ACar"];
        Response.Write(car.NumberPlate);
        Response.Write(car.Make);
        Response.Write(car.Model);
        Response.Write(car.Colour);
        Response.Write(car.Description);
        Response.Write(car.Price);
        Response.Write(car.Sold);
        Response.Write(car.OfficeCode);
    }
}