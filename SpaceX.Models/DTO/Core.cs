using System.Text.Json.Serialization;

namespace SpaceX.Models.DTO
{
    public class Core
    {
        [JsonPropertyName("core_serial")]
        public string CoreSerial { get; set; }

        [JsonPropertyName("flight")]
        public long? Flight { get; set; }

        [JsonPropertyName("block")]
        public long? Block { get; set; }

        [JsonPropertyName("gridfins")]
        public bool? Gridfins { get; set; }

        [JsonPropertyName("legs")]
        public bool? Legs { get; set; }

        [JsonPropertyName("reused")]
        public bool? Reused { get; set; }

        [JsonPropertyName("land_success")]
        public bool? LandSuccess { get; set; }

        [JsonPropertyName("landing_intent")]
        public bool? LandingIntent { get; set; }

        [JsonPropertyName("landing_type")]
        public string LandingType { get; set; }

        [JsonPropertyName("landing_vehicle")]
        public string LandingVehicle { get; set; }
    }
}
