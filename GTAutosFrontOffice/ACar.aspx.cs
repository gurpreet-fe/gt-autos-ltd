using GTAutosClasses;
using System;



public partial class ACar : System.Web.UI.Page
{
    //variable to store the priamry key with page level scope
    int CarID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the numberplate of the car to be processed
        CarID = Convert.ToInt32(Session["CarID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record
            if (CarID != -1)
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
        AllCars.ThisCar.Find(CarID);
        //display the data for this record
        txtCarID.Text = AllCars.ThisCar.CarID.ToString();
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
        ClsCar ACar = new ClsCar();
        String NumberPlate = txtNumberPlate.Text;
        String Make = txtMake.Text;
        String Model = txtModel.Text;
        String Colour = txtColour.Text;
        String Description = txtDescription.Text;
        String Price = txtPrice.Text;
        String OfficeCode = txtOfficeCode.Text;
    
        String Error = "";

        Error = ACar.Valid(NumberPlate, Make, Model, Description, Colour, Price);
        if (Error == "")
        {
            ACar.NumberPlate = NumberPlate;
            ACar.Make = Make;
            ACar.Model = Model;
            ACar.Colour = Colour;
            ACar.Description = Description;
            ACar.Price = Convert.ToInt32(Price);
            ACar.OfficeCode = Convert.ToInt32(OfficeCode);

            ClsCarCollection CarList = new ClsCarCollection();

            //if this is a new record i.e. NumberPlate != -1 then add the data
            if (CarID == -1)
            {
                //set the ThisCar Property
                CarList.ThisCar = ACar;
                //add the new record
                CarList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update 
                CarList.ThisCar.Find(CarID);
                //set the ThisCar property
                CarList.ThisCar = ACar;
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
        int CarID;
        Boolean Found = false;
        CarID = Convert.ToInt32(txtCarID.Text);
        Found = car.Find(CarID);
        if (Found == true)
        {
            txtNumberPlate.Text = car.NumberPlate;
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