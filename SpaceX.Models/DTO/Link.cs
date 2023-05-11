using System.Text.Json.Serialization;

namespace SpaceX.Models.DTO
{
    public class Link
    {
        [JsonPropertyName("mission_patch")]
        public string MissionPatch { get; set; }

        [JsonPropertyName("mission_patch_small")]
        public string MissionPatchSmall { get; set; }

        [JsonPropertyName("reddit_campaign")]
        public string RedditCampaign { get; set; }

        [JsonPropertyName("reddit_launch")]
        public string RedditLaunch { get; set; }

        [JsonPropertyName("reddit_recovery")]
        public string RedditRecovery { get; set; }

        [JsonPropertyName("reddit_media")]
        public string RedditMedia { get; set; }

        [JsonPropertyName("presskit")]
        public string Presskit { get; set; }

        [JsonPropertyName("article_link")]
        public string ArticleLink { get; set; }

        [JsonPropertyName("wikipedia")]
        public string Wikipedia { get; set; }

        [JsonPropertyName("video_link")]
        public string VideoLink { get; set; }

        [JsonPropertyName("youtube_id")]
        public string YoutubeId { get; set; }

        [JsonPropertyName("flickr_images")]
        public string[] FlickrImages { get; set; }
    }
}
