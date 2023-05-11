using System.Text.Json.Serialization;

namespace SpaceX.Models.DTO
{
    public class FirstStage
    {
        [JsonPropertyName("cores")]
        public IEnumerable<Core>? Cores { get; set; }
    }
}
