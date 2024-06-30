using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
    public class InvalidCitizenshipException : Exception
    {
        public InvalidCitizenshipException() : base ("Citizenship can not be empty. Please input citizenship"){ }
    }
}
