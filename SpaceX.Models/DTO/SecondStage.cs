using System.Text.Json.Serialization;

namespace SpaceX.Models.DTO
{
    public class SecondStage
    {
        [JsonPropertyName("block")]
        public int? Block { get; set; }

        [JsonPropertyName("payloads")]
        public IEnumerable<Payload> Payloads { get; set; }
    }
}
