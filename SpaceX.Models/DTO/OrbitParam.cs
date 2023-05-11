using System.Text.Json.Serialization;

namespace SpaceX.Models.DTO
{
    public class OrbitParam
    {
        [JsonPropertyName("reference_system")]
        public string ReferenceSystem { get; set; }

        [JsonPropertyName("regime")]
        public string Regime { get; set; }

        [JsonPropertyName("longitude")]
        public float? Longitude { get; set; }

        [JsonPropertyName("semi_major_axis_km")]
        public float? SemiMajorAxisKm { get; set; }

        [JsonPropertyName("eccentricity")]
        public float? Eccentricity { get; set; }

        [JsonPropertyName("periapsis_km")]
        public float? PeriapsisKm { get; set; }

        [JsonPropertyName("apoapsis_km")]
        public float? ApoapsisKm { get; set; }

        [JsonPropertyName("inclination_deg")]
        public float? InclinationDeg { get; set; }

        [JsonPropertyName("period_min")]
        public float? PeriodMin { get; set; }

        [JsonPropertyName("lifespan_years")]
        public float? LifespanYears { get; set; }

        [JsonPropertyName("epoch")]
        public DateTime? Epoch { get; set; }

        [JsonPropertyName("mean_motion")]
        public float? MeanMotion { get; set; }

        [JsonPropertyName("raan")]
        public float? Raan { get; set; }

        [JsonPropertyName("arg_of_pericenter")]
        public float? ArgOfPericenter { get; set; }

        [JsonPropertyName("mean_anomaly")]
        public float? MeanAnomaly { get; set; }
    }
}
