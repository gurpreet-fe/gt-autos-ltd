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

    

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ClsCar car = new ClsCar();
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



    protected void btnFind_Click(object sender, EventArgs e)
    {
        ClsCar car = new ClsCar();
        String NumberPlate;
        Boolean Found = false;
        NumberPlate = (txtNumberPlate.Text);
        Found = car.Find(NumberPlate);
        if (Found == true)
        {

            txtMake.Text = car.Make;
            txtModel.Text = car.Model;
            txtColour.Text = car.Colour;
            txtDescription.Text = car.Description;
            txtPrice.Text = car.Price.ToString();
            txtSold.Text = car.Sold.ToString();
            txtOfficeCode.Text = car.OfficeCode.ToString();

        }
    }

    protected void Sold_CheckedChanged(object sender, EventArgs e)
    {

    }
}