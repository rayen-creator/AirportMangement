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
        public List<Flight> Flights { get; set; } = new List<Flight>();
        public List<Passenger> Passengers { get; set; } = new List<Passenger>();

        public void GetFlights(string filterType, string filterValue)
        {
            switch (filterType)
            {

                case "Destination":
                    foreach (var flight in Flights)
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
                        if (flight.FlightDate == DateTime.Parse(filterValue))
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

        public List<DateTime> FlightDates(string destination)
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
            var query = from flight in Flights
                        where flight.Plane == plane
                        select new
                        {
                            flight.Destination,
                            flight.FlightDate,
                        };
            var query2 = Flights.Where(f => f.Plane == plane).Select(f => new
            {
                f.Destination,
                f.FlightDate,
            });
            foreach (var flight in query2)
            {
                Console.WriteLine("destination = " + flight.Destination + "flight date =" + flight.FlightDate);
            }

        }

        public int ProgrammedFlight(DateTime startDate)
        {
            /*var query = from fligh in Flights
                        where fligh.FlightDate.CompareTo(startDate) > 0 && (fligh.FlightDate - startDate).TotalDays < 7
                        select fligh;*/

            var query = Flights.Where(f => f.FlightDate.CompareTo(startDate) > 0 && (f.FlightDate - startDate).TotalDays < 7);

            return query.Count();
        }

        public double DurationAverage(string destination)
        {
            var query = from flights in Flights
                        where flights.Destination == destination
                        select flights.EstimatedDuration;

            var query2 = Flights.Where(f => f.Destination == destination).Select(f => f.EstimatedDuration);
            return query.Average();


        }
        public IEnumerable<Flight> OrderedDurationFlights()
        {
            var query = from flights in Flights
                        orderby flights.EstimatedDuration
                        descending
                        select flights;
            var query2=Flights.OrderByDescending(f => f.EstimatedDuration);
            return query;
        }

        public IEnumerable<Passenger> SeniorTravellers(Flight flight)
        {

            var oldTravellers = from p in Passengers.OfType<Traveller>()
                                orderby p.BirthDate
                                select p;
            var qr = Passengers.OrderBy(p => p.BirthDate);
            return qr.Take(3);
            //if we want to skip 3
            //return oldTravellers.Skip(3);
           
        }
        public IEnumerable<IGrouping<string, Flight>> DestinationGroupeFlights()
        {
            var query = from flight in Flights
                        group flight by flight.Destination;
            //var query2 = Flights.GroupBy(f => f.Destination);
            foreach (var g in query)
            {
                Console.WriteLine("destination:" + g.Key);
                foreach (var flight in g)
                {
                    Console.WriteLine("decollage:" + flight.FlightDate);
                }
            }
            return query;

        }
    }
}
