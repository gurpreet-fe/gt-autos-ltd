using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GTAutosClasses;

public partial class DeleteCar : System.Web.UI.Page
{
    //var to store the primary key value to be deleted 
    int CarID;
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the car to be deleated from the session object
        CarID = Convert.ToInt32(Session["CarID"]);
    }

    protected void BtnYes_Click(object sender, EventArgs e)
    {
        //create an instance of the car collection
        ClsCarCollection AllCars = new ClsCarCollection();
        //find the record to delete
        AllCars.ThisCar.Find(CarID);
        //delete the record
        AllCars.Delete();
        //redirect back to main page
        Response.Redirect("CarList.aspx");
    }
}