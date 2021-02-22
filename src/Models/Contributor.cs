using System.Text.Json.Serialization;

namespace TwitchChallenge.Web.Models
{
    public class Contributor
    {
        [JsonPropertyName("login")]
        public string Login { get; set; }

        [JsonPropertyName("contributions")]
        public int Contributions { get; set; }
    }
}