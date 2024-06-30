using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
    public class InvalidFlightCodeException : Exception
    {
        public InvalidFlightCodeException() : base("Flight can not be NULL, please input a flight.")
        { }
        public InvalidFlightCodeException(string flightCode) : base("Flight code does not exist.") 
        { }
    }
}
