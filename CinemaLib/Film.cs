using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CinemaLib
{
    public class Film
    {
        public Film(string name)
        {
            Name = name;
        }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("release-date")]
        public string DateRelease { get; set; }
        [JsonPropertyName("sessions")]
        public List<string> Sessions { get; set; } = new List<string>();

        public void AddTime(string time)
        {
            Sessions.Add(time);
        }
    }
}
