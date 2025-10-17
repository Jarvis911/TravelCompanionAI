using System.ComponentModel.DataAnnotations;

namespace TravelCompanionAPIs.Models
{
    public class Trip
    {
        public int Id { get; set; }
        public string? Destination { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        public string? Preference { get; set; }
        public Decimal Budget { get; set; }
    }
}
