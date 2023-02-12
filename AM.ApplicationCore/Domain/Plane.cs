using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
        Boing,
        Airbus
    }
    public class Plane
    {
        public Plane()
        {
        }

        //public Plane(int capacity, DateTime manufactureDate, PlaneType planetype)
        //{
        //    Capacity = capacity;
        //    ManufactureDate = manufactureDate;
        //    Planetype = planetype;
        //}

        public int PlaneId { get; set; }

        public int Capacity { get; set; }

        public DateTime ManufactureDate { get; set; }
        public PlaneType Planetype { get; set; }

        public ICollection<Flight> Flights { get; set; }
        public override string ToString()
        {
            return "Plane Id :" + PlaneId + ", Capacity :" + Capacity + ", ManufactureDate :" + ManufactureDate + " , PlaneType : " + Planetype;
        }
    }

    
}
