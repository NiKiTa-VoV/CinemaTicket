using System;

namespace CinemaLib
{
    public static class Ticket
    {
        public static City City { get; set; }
        public static Cinema Cinema { get; set; }
        public static Film Film { get; set; }
        public static string Session { get; set; }
        public static int Row { get; set; }
        public static int Place { get; set; }
        public static int Price { get; set; }
        public static DateTime Date { get; set; }
    }
}
