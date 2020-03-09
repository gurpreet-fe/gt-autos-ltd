using GTAutosClasses;
using System;



public partial class ACar : System.Web.UI.Page
{
    //this fucntion handles the load event for the page
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCars();
        }
    }

    void DisplayCars()
    {
        //create an instance of the car collection
        GTAutosClasses.ClsCarCollection AllCars = new GTAutosClasses.ClsCarCollection();
        //set the data source top the list of counties in the collection 
     //   lstAllCars.DataSource = AllCars.CarList;
        //set the name of the primary key
    //    lstAllCars.DataVlaueField = "NumberPlate";
        //set the data field to display
     //   lstAllCars.DataTextField = "Car";
        //bind the data to the list
     //   lstAllCars.DataBind();
        
    }

    

    protected void btnOK_Click(object sender, EventArgs e)
    {
        ClsCar car = new ClsCar();
        String Make = txtMake.Text;
        String Model = txtMake.Text;
        String Colour = txtMake.Text;
        String Description = txtMake.Text;
        String Price = txtPrice.Text;
    
        String Error = "";

        Error = car.Valid(Make, Model, Description, Colour, Price);
        if (Error == "")
        {
            car.Make = Make;
            car.Model = Model;
            car.Colour = Colour;
            car.Description = Description;
            car.Price = Convert.ToInt32(Price);

            //store the address in the session object
            Session["car"] = car;
            //redirect to the viewer page
            Response.Redirect("CarViewer.aspx");

        }
        else
        {
            lblError.Text = Error;
        }

        
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
            txtOfficeCode.Text = car.OfficeCode.ToString();

        }
    }

    protected void Sold_CheckedChanged(object sender, EventArgs e)
    {
    
    }

    protected void Cancel_Click(object sender, EventArgs e)
    {

    }
}