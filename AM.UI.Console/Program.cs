using AM.ApplicationCore;
using AM.ApplicationCore.Domain;

//Plane plane=new Plane();
//plane.Planetype = PlaneType.Airbus;
//plane.Capacity = 200;
//plane.ManufactureDate = new DateTime(218, 11, 10);

//Plane plane= new Plane(300, DateTime.Now,PlaneType.Boing);

Plane plane = new Plane
{
    Capacity = 300,
    ManufactureDate = DateTime.Now,
    Planetype = PlaneType.Boing,

};
Console.WriteLine(plane.ToString());