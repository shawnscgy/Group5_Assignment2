using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
    public class FlightManager
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..//..//..//..//..//Resources//Res//flights.csv");
        public static List<Flight> flights = new List<Flight>();

        public FlightManager() 
        {
            populateFlights();
        }
        private void populateFlights()
        {
            Flight flight;
            foreach(string line in File.ReadAllLines(filePath))
            {
                flight = new Flight();
                string[] items = line.Split(",");
                flight.FlightCode = items[0];
                flight.Airline = items[1];
                flight.Departure = items[2];
                flight.Arriving = items[3];
                flight.Day = items[4];
                flight.Time = items[5];
                flight.Cost = int.Parse(items[6]);
                flight.Price = double.Parse(items[7]);

                flights.Add(flight);
            }
        }
        public static List<Flight> GetFlights()
        {
            return flights;
        }
    }
}
