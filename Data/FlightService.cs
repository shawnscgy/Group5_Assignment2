namespace Assignment2.Data
{
    public class FlightService
    {
        string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..//..//..//..//..//Resources//Res//airports.csv");
        public static List<string> airports = new List<string>();

        public FlightService()
        {
            populateAirports();
        }
        private void populateAirports()
        {
            string airport;
            foreach (string line in File.ReadAllLines(filePath))
            {
                airports.Add(line);
            }
        }
        public static List<string> GetAirports()
        {
            return airports;
        }
    }
}