using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {
        public List<Flight> Flights { get; set; }=new List<Flight>();

        public void GetFlights(string filterType, string filterValue)
        {
                switch(filterType){

                    case "Destination":
                        foreach(var flight in Flights)
                        {
                            if (flight.Destination.Equals(filterValue))
                            {
                            Console.WriteLine(flight.Destination);
                            }
                        }
                    break;
                    case "FlightDate":
                         foreach (var flight in Flights)
                         {
                            if (flight.FlightDate==DateTime.Parse(filterValue))
                            {
                                Console.WriteLine(flight.FlightDate);
                            }
                        }
                    break;
                    case "Estimated value":
                          foreach (var flight in Flights)
                          {
                          if (flight.EstimatedArrival == DateTime.Parse(filterValue))
                          {
                                Console.WriteLine(flight.EstimatedArrival);
                          }
                    }
                    break;
                default:
                    Console.WriteLine("choix erronée");
                break;

                }
         }

        public List<DateTime> FlightDate(string destination)
        {
            List<DateTime> date = new List<DateTime>();

            /*  for (int i = 0; i < Flights.Count; i++)
              {
                  if (Flights[i].Destination == destination)
                  {
                      date.Add(Flights[i].FlightDate);
                  }

              }*/

          /*  var query=from fligh in Flights
                      where fligh.Destination.Equals(destination)
                      select fligh.FlightDate;

            return query.ToList();*/

            var query2 = Flights.Where(f => f.Destination == destination).Select(f => f.FlightDate);

            return query2.ToList();


           /* foreach (var flight in Flights)
            {
                if (flight.Destination == destination)
                {
                    date.Add(flight.FlightDate);
                }
            }
            return date;*/
        }

        public void ShowFlightDetails(Plane plane)
        {
            var query=from flight in Flights
                      where flight.Plane == plane
                      select new
                      { 
                        flight.Destination,
                        flight.FlightDate,
                      };
            var query2=Flights.Where(f=>f.Plane==plane).Select(f => new
            {
                f.Destination, f.FlightDate,
            });
            foreach(var flight in query2)
            {
              Console.WriteLine("destination = "+flight.Destination+"flight date ="+flight.FlightDate);
            }

    }
}
