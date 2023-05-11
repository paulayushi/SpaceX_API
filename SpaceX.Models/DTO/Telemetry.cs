using System.Text.Json.Serialization;

namespace SpaceX.Models.DTO
{
    public class Telemetry
    {
        [JsonPropertyName("flight_club")]
        public string FlightClub { get; set; }
    }
}
