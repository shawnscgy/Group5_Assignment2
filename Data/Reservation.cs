using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Data
{
    public class Reservation
    {
        string reservationCode;
        Flight flight;
        string name;
        string citizenship;
        string status = "active";

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

        public string ReservationCode { get => reservationCode; set => reservationCode = value; }
        public string Status { get => status; set => status = value; }
        
        // Flight page, click reserve button, trigger makeReservation()
        public Reservation(Flight flight, string name, string citizenship)
        {
            this.Flight = flight;
            this.Name = name;
            this.Citizenship = citizenship;
            this.ReservationCode = ReservationManager.RenderCode();
        }
        public Reservation(string reservationCode, Flight flight, string name, string citizenship, string status)
        {
            this.Flight = flight;
            this.Name = name;
            this.Citizenship = citizenship;
            this.ReservationCode = reservationCode;
            this.Status = status;
        }
        public Reservation()
        {
            
        }
        public void mutator(string name, string citizenship, string status)
        {
            this.Name = name;
            this.Citizenship = citizenship;
            this.Status = status;
        }

        public override string? ToString()
        {
            return $"{reservationCode},{flight.FlightCode},{name},{citizenship},{status}";
        }
    }
}
