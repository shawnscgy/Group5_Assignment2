using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
    public class Reservation
    {
        Flight flight;
        string name;
        string citizenship;

        public Flight Flight
        {
            get { return flight; }
            set
            {
                if (value is null)
                {
                    throw new InvalidFlightCodeException();
                }
                else
                {
                    this.flight = value;
                }
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value is null)
                {
                    throw new InvalidNameException();
                }
                else
                {
                    this.name = value;
                }
            }
        }
        public string Citizenship
        {
            get { return citizenship; }
            set 
            {
                if (value is null)
                {
                    throw new InvalidCitizenshipException();
                }
                else
                {
                    this.citizenship = value;
                }
            }
        }

        public Reservation(Flight? flight, string? name, string? citizenship)
        {
            this.Flight = flight;
            this.Name = name;
            this.Citizenship = citizenship;
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
