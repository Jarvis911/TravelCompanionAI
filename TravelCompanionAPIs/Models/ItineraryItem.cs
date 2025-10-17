namespace TravelCompanionAPIs.Models
{
    public class ItineraryItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
        public string? Category { get; set; }
        public int DurationMinutes { get; set; }
        public int TripId { get; set; }
        public Trip? Trip { get; set; }
    }
}
