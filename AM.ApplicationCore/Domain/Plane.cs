﻿using System;
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
