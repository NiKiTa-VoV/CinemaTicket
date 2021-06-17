using System;

namespace CinemaLib
{
    public class Ticket
    {
        City _city;
        Cinema _cinema;
        Film _film;
        string _session;
        int _row;
        int _place;
        int _price;
        DateTime _date;


        public City City { get => _city; set => _city = value; }
        public Cinema Cinema { get => _cinema; set => _cinema = value; }
        public Film Film { get => _film; set => _film = value; }
        public string Session { get => _session; set => _session = value; }
        public int Row { get => _row; set => _row = value; }
        public int Place { get => _place; set => _place = value; }
        public int Price { get => _price; set => _price = value; }
        public DateTime Date { get => _date; set => _date = value; }
    }
}
