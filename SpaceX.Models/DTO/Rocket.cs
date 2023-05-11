using System.Text.Json.Serialization;

namespace SpaceX.Models.DTO
{
    public class Rocket
    {
        [JsonPropertyName("rocket_id")]
        public string RocketId { get; set; }

        [JsonPropertyName("rocket_name")]
        public string RocketName { get; set; }

        [JsonPropertyName("rocket_type")]
        public string RocketType { get; set; }

        [JsonPropertyName("first_stage")]
        public FirstStage? FirstStage { get; set; }

        [JsonPropertyName("second_stage")]
        public SecondStage? SecondStage { get; set; }

        [JsonPropertyName("fairings")]
        public Fairing Fairings { get; set; }
    }
}
