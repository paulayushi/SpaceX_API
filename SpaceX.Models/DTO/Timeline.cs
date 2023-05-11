using System.Text.Json.Serialization;

namespace SpaceX.Models.DTO
{
    public class Timeline
    {
        [JsonPropertyName("webcast_liftoff")]
        public int? WebcastLiftOff { get; set; }
        [JsonPropertyName("go_for_prop_loading")]
        public int? GoForPropLoading { get; set; }
        [JsonPropertyName("rp1_loading")]
        public int? Rp1Loading { get; set; }
        [JsonPropertyName("stage1_lox_loading")]
        public int? Stage1LoxLoading { get; set; }
        [JsonPropertyName("stage2_lox_loading")]
        public int? Stage2LoxLoading { get; set; }
        [JsonPropertyName("engine_chill")]
        public int? EngineChill { get; set; }
        [JsonPropertyName("prelaunch_checks")]
        public int? PrelaunchChecks { get; set; }
        [JsonPropertyName("propellant_pressurization")]
        public int? PropellantPressurization { get; set; }
        [JsonPropertyName("go_for_launch")]
        public int? GoForLaunch { get; set; }
        [JsonPropertyName("ignition")]
        public int? Ignition { get; set; }
        [JsonPropertyName("liftoff")]
        public int? Liftoff { get; set; }
        [JsonPropertyName("maxq")]
        public int? Maxq { get; set; }
        [JsonPropertyName("meco")]
        public int? Meco { get; set; }
        [JsonPropertyName("stage_sep")]
        public int? StageSep { get; set; }
        [JsonPropertyName("second_stage_ignition")]
        public int? SecondStageIgnition { get; set; }
        [JsonPropertyName("fairing_deploy")]
        public int? FairingDeploy { get; set; }

        [JsonPropertyName("seco-1")]
        public int? Seco1 { get; set; }
        [JsonPropertyName("second_stage_restart")]
        public int? SecondStageRestart { get; set; }

        [JsonPropertyName("seco-2")]
        public int? Seco2 { get; set; }
        [JsonPropertyName("payload_deploy_1")]
        public int? PayloadDeploy1 { get; set; }
        [JsonPropertyName("payload_deploy_2")]
        public int? PayloadDeploy2 { get; set; }
    }
}
