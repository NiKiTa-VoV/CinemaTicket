using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CinemaLib
{
    public class Cinema
    {
        string _name;
        private Dictionary<string, Film> _films = new Dictionary<string, Film>();

        public Cinema(string name)
        {
            this._name = name;
        }
        [JsonPropertyName("name")]
        public string Name { get => _name; set => _name = value; }
        [JsonPropertyName("films")]
        public Dictionary<string, Film> Films { get => _films; set => _films = value; }

        public void AddFilm(string filmName)
        {
            Film film = new(filmName);
            _films.Add(film.Name,film);
        }
    }
}
