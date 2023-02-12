using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public int PassportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int TelNumber { get; set; } 
        public DateTime BirthDate { get; set; }

        public ICollection<Flight> Flights { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
