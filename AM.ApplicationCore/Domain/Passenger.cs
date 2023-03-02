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

        public virtual ICollection<Flight> Flights { get; set; }

       
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public bool CheckProfile(string nom , string prenom)
        {
            return (this.Firstname == nom) && (this.Lastname == prenom);
            
        }

        public bool CheckProfile(string nom ,string prenom , string email)
        {
            return (this.EmailAddress == email) && (this.Firstname == nom) && (this.EmailAddress == email);
        }
    }
}
