using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CinemaLib
{
    public class Cinema
    {
        public Cinema(string name)
        {
            Name = name;
        }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("films")]
        public Dictionary<string, Film> Films { get; set; } = new Dictionary<string, Film>();

        public void AddFilm(string filmName)
        {
            Film film = new(filmName);
            Films.Add(film.Name,film);
        }
    }
}
