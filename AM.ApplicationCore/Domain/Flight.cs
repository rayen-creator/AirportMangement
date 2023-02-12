using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int Flightid { get; set; }

        public DateTime FlightDate { get; set; }

        public string Departure { get; set; }

        public string Destination { get; set; }

        public DateTime EstimatedArrival { get; set; }

        public int EstimatedDuration { get; set; }

        public Plane Plane { get; set; }
        public ICollection<Passenger> Passengers { get; set; } 
        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
