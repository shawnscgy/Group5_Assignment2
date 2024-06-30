using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
    public class Flight
    {
        string flightCode;
        string airline;
        string departure;
        string arriving;
        string day;
        string time;
        int cost;
        double price;

        public string FlightCode { get => flightCode; set => flightCode = value; }
        public string Airline { get => airline; set => airline = value; }
        public string Departure { get => departure; set => departure = value; }
        public string Arriving { get => arriving; set => arriving = value; }
        public string Day { get => day; set => day = value; }
        public string Time { get => time; set => time = value; }
        public int Cost { get => cost; set => cost = value; }
        public double Price { get => price; set => price = value; }

        public Flight()
        {
            
        }
        public Flight(string flightCode, string airline, string departure, string arriving, string day,
            string time, int cost, double price)
        {
            this.FlightCode = flightCode;
            this.Airline = airline;
            this.Departure = departure;
            this.Arriving = arriving;
            this.Day = day;
            this.Time = time;
            this.Cost = cost;
            this.Price = price;
        }

        public override string? ToString()
        {
            return $"{FlightCode},{Airline},{Departure},{Arriving},{Day},{Time},{Cost},{Price}";
        }
    }
}
