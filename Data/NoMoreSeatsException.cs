using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
    public class NoMoreSeatsException : Exception
    {
        public NoMoreSeatsException() : base ("Seats sold out. Please try other flight.") { }
    }
}
