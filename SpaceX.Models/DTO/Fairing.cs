using System.Text.Json.Serialization;

namespace SpaceX.Models.DTO
{
    public class Fairing
    {
        [JsonPropertyName("reused")]
        public bool? Reused { get; set; }

        [JsonPropertyName("recovery_attempt")]
        public bool? RecoveryAttempt { get; set; }

        [JsonPropertyName("recovered")]
        public bool? Recovered { get; set; }

        [JsonPropertyName("ship")]
        public string Ship { get; set; }
    }
}
