using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CinemaLib
{
    public class City
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("cinemas")]
        public Dictionary<string, Cinema> Cinemas { get; set; }

        public Cinema AddCinema(string cinemaName) 
        {
            Cinema cinema = new Cinema(cinemaName);
            Cinemas.Add(cinemaName, cinema);
            return cinema;
        }
    }
}
