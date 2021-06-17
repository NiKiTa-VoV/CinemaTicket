using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CinemaLib
{
    public class City
    {
        string _name;
        Dictionary<string, Cinema> _cinemas = new Dictionary<string, Cinema>();
        [JsonPropertyName("name")]
        public string Name { get => _name; set => _name = value; }
        [JsonPropertyName("cinemas")]
        public Dictionary<string, Cinema> Cinemas { get => _cinemas; set => _cinemas = value; }

        public Cinema AddCinema(string cinemaName) 
        {
            Cinema cinema = new Cinema(cinemaName);
            _cinemas.Add(cinemaName, cinema);
            return cinema;
        }
    }
}
