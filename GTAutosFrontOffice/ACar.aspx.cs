using GTAutosClasses;
using System;



public partial class ACar : System.Web.UI.Page
{
    //variable to store the priamry key with page level scope
    String NumberPlate;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the address to be processed
        NumberPlate = Convert.ToString(Session["NumberPlate"]);
        if (IsPostBack == false)
        {
            //if this is not a neew record
            if (NumberPlate != -1)
            {
                //display the current data for the record
                DisplayCar();
            }
        }
    }

    void DisplayCar()
    {
        //create an instanc of the collection
        ClsCarCollection AllCars = new ClsCarCollection();
        //find the record to update 
        AllCars.ThisCar.Find(NumberPlate);
        //display the data for this record
        txtNumberPlate.Text = AllCars.ThisCar.NumberPlate;
        txtMake.Text = AllCars.ThisCar.Make;
        txtModel.Text = AllCars.ThisCar.Model;
        txtColour.Text = AllCars.ThisCar.Colour;
        txtDescription.Text = AllCars.ThisCar.Description;
        txtPrice.Text = AllCars.ThisCar.Price.ToString();
        txtOfficeCode.Text = AllCars.ThisCar.OfficeCode.ToString();

    }




    protected void btnOK_Click(object sender, EventArgs e)
    {
        ClsCar car = new ClsCar();
        String Make = txtMake.Text;
        String Model = txtModel.Text;
        String Colour = txtColour.Text;
        String Description = txtDescription.Text;
        String Price = txtPrice.Text;
    
        String Error = "";

        Error = car.Valid(Make, Model, Description, Colour, Price);
        if (Error == "")
        {
            car.NumberPlate = NumberPlate;
            car.Make = Make;
            car.Model = Model;
            car.Colour = Colour;
            car.Description = Description;
            car.Price = Convert.ToInt32(Price);

            ClsCarCollection CarList = new ClsCarCollection();

            //if this is a new record i.e. NumberPlate != -1 then add the data
            if (NumberPlate != -1)
            {
                //set the ThisCar Property
                CarList.ThisCar = NumberPlate;
                //add the new record
                CarList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update 
                CarList.ThisCar.Find(NumberPlate);
                //set the ThisCar property
                CarList.ThisCar = car;
                //update the record
                CarList.Update();
            }
            //redirect back to thte list page 
            Response.Redirect("CarList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }

        
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        ClsCar car = new ClsCar();
        String NumberPlate;
        Boolean Found = false;
        NumberPlate = txtNumberPlate.Text;
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

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}