using AM.ApplicationCore;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;
using System.Net.Mail;
using System.Numerics;


//Plane plane=new Plane();
//plane.Planetype = PlaneType.Airbus;
//plane.Capacity = 200;
//plane.ManufactureDate = new DateTime(218, 11, 10);

//Plane plane= new Plane(300, DateTime.Now,PlaneType.Boing);

/*Plane plane = new Plane
{
    Capacity = 300,
    ManufactureDate = DateTime.Now,
    Planetype = PlaneType.Boing,

};*/
/*Console.WriteLine(plane.ToString());
*/

//Passenger passenger = new Passenger{EmailAddress = "email@email.tn", Firstname="john", Lastname="wick"};
//Console.WriteLine("check name and last name :" + passenger.CheckProfile("john", "wick"));
//Console.WriteLine("check name and last name and email :" + passenger.CheckProfile("john", "wick", "email@email.tn"));

//Staff staff = new Staff();
//Traveller traveller = new Traveller();
//passenger.PassengerType();
//staff.PassengerType();
//traveller.PassengerType();

//ServiceFlight serviceFlight= new ServiceFlight();
//serviceFlight.Flights = TestData.listFlights;
Passenger p1 = new Passenger
{
    //  FirstName = "John",
    //LastName = "Doe",
    EmailAddress = "john.doe@example.com"

};
//Console.WriteLine("la méthode checkpassenger");
//Console.WriteLine(p1.CheckProfile("John", "Doe"));
//Console.WriteLine(p1.CheckProfile("John", "Doe", "john.doe@example.com"));


Console.WriteLine("*************Testing passenger**************");
//Staff s1= new Staff { FirstName = "Bill", LastName = "Gates", EmailAddress="BillGates@gmail.com" };
Traveller t1 = new Traveller();
p1.PassengerType();
//s1.PassengerType();
t1.PassengerType();



ServiceFlight sf = new ServiceFlight();
sf.Flights = TestData.listFlights;
bool test = false;
if (test)
{

}