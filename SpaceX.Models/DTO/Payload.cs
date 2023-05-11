using System.Text.Json.Serialization;

namespace SpaceX.Models.DTO
{
    public class Payload
    {
        [JsonPropertyName("payload_id")]
        public string PayloadId { get; set; }

        [JsonPropertyName("norad_id")]
        public long[] NoradId { get; set; }

        [JsonPropertyName("cap_serial")]
        public string CapSerial { get; set; }

        [JsonPropertyName("reused")]
        public bool? Reused { get; set; }

        [JsonPropertyName("customers")]
        public string[] Customers { get; set; }

        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        [JsonPropertyName("manufacturer")]
        public string Manufacturer { get; set; }

        [JsonPropertyName("payload_type")]
        public string PayloadType { get; set; }

        [JsonPropertyName("payload_mass_kg")]
        public float? PayloadMassKg { get; set; }

        [JsonPropertyName("payload_mass_lbs")]
        public float? PayloadMassLbs { get; set; }

        [JsonPropertyName("orbit")]
        public string Orbit { get; set; }

        [JsonPropertyName("orbit_params")]
        public OrbitParam OrbitParams { get; set; }

        [JsonPropertyName("mass_returned_kg")]
        public float? MassReturnedKg { get; set; }

        [JsonPropertyName("mass_returned_lbs")]
        public float? MassReturnedLbs { get; set; }

        [JsonPropertyName("flight_time_sec")]
        public long? FlightTimeSec { get; set; }

        [JsonPropertyName("cargo_manifest")]
        public string CargoManifest { get; set; }
    }
}
