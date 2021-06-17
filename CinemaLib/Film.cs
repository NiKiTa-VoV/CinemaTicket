using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CinemaLib
{
    public class Film
    {
        string _description;
        string _dataRelease;
        string _name;
        List<string> _sessions = new List<string>();


        public Film(string name)
        {
            this._name = name;
        }
        [JsonPropertyName("name")]
        public string Name { get => _name; set => _name = value; }
        [JsonPropertyName("description")]
        public string Description { get => _description; set => _description = value; }
        [JsonPropertyName("release-date")]
        public string DateRelease { get => _dataRelease; set => _dataRelease = value; }
        [JsonPropertyName("sessions")]
        public List<string> Sessions { get => _sessions; set => _sessions = value; }

        public void AddTime(string time)
        {
            _sessions.Add(time);
        }
    }
}
