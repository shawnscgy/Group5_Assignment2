using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException() : base("Name can not be empty. Please input client's full name") { }

    }
}
