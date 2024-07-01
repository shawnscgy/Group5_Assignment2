using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{

    public class ReservationManager
    {
        //
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..//..//..//..//..//Resources//Res//reservations.csv");
        public static List<Reservation> reservations = new List<Reservation>();
        //
        static Random random = new Random();

        public ReservationManager()
        {
            populateReservations();
        }
        private void populateReservations()
        {
            // get flights list
            FlightManager fm = new FlightManager();
            List<Flight> flights = FlightManager.GetFlights();

            Reservation reservation;
            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] parts = line.Split(",");
                string reservationCode = parts[0];
                Flight flight = flights.Find(f => f.FlightCode == parts[1]);
                string name = parts[2];
                string citizenship = parts[3];
                string status = parts[4];
                reservation = new Reservation(reservationCode, flight, name, citizenship, status);
                reservations.Add(reservation);
            }

        }
        public List<Reservation> GetReservations()
        {
            return reservations;
        }
        public static string RenderCode()
        {
            string reservationCode;
            bool isEqual = true;
            do
            {
                string alp = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                int index = random.Next(0, alp.Length);
                int number = random.Next(0, 10000);
                reservationCode = alp[index].ToString() + number.ToString(); // 
                foreach (Reservation reservation in reservations)
                {
                    if (reservationCode == reservation.ReservationCode)
                    {
                        isEqual = true; 
                        break;
                    }
                    else
                    {
                        isEqual = false;
                    }
                    
                }
            } while (isEqual);
            return reservationCode;
        }

    }
}
