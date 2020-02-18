using GTAutosClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ACar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        clsCar car = new clsCar();
        car.NumberPlate = txtNumberPlate.Text;
        car.Make = txtMake.Text;
        car.Model = txtMake.Text;
        car.Colour = txtMake.Text;
        car.Description = txtMake.Text;
        car.Price = Convert.ToDouble(txtPrice.Text);
        car.Sold = Convert.ToBoolean(txtSold.Text);
        car.OfficeCode = Convert.ToInt32(txtPrice.Text);

        Session["car"] = car;
        Response.Redirect("CarViewer.aspx");
      }

    protected void Active_CheckedChanged(object sender, EventArgs e)
    {

    }

    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {

    }
}