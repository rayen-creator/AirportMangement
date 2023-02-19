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

Passenger passenger = new Passenger{EmailAddress = "email@email.tn", Firstname="john", Lastname="wick"};
Console.WriteLine("check name and last name :" + passenger.CheckProfile("john", "wick"));
Console.WriteLine("check name and last name and email :" + passenger.CheckProfile("john", "wick", "email@email.tn"));

Staff staff = new Staff();
Traveller traveller = new Traveller();
passenger.PassengerType();
staff.PassengerType();
traveller.PassengerType();

ServiceFlight serviceFlight= new ServiceFlight();
serviceFlight.Flights = TestData.listFlights;