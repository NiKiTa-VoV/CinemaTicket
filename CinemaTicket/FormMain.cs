using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;
using CinemaLib;

namespace CinemaTicket
{
    
    public partial class FormMain : Form
    {
        private readonly Dictionary<string, City> _cities;
        Ticket _ticket = new();
        City _city;
        Cinema _cinema;
        public FormMain()
        {
            InitializeComponent();


            string jsonString = File.ReadAllText("file/Main.json");
            _cities = JsonSerializer.Deserialize<Dictionary<string, City>>(jsonString);


            comboBoxCity.Items.Clear();
            foreach (var cityName in _cities?.Keys)
            {
                comboBoxCity.Items.Add(cityName);
            }
        }
        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_cities.TryGetValue((string)comboBoxCity.SelectedItem, out _city))
            {
                comboBoxCinema.Items.Clear();
                _cinema = null;
                foreach (var cinemaName in _city.Cinemas.Keys)
                {
                    comboBoxCinema.Items.Add(cinemaName);
                }
            }
        }
        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (_city.Cinemas.TryGetValue((string)comboBoxCinema.SelectedItem, out _cinema)) 
                {
                }
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (_city != null && _cinema != null)
            {
                _ticket.City = _city;
                _ticket.Cinema = _cinema;
                
                FormFilm formFilm = new(ref _ticket);
                if (!formFilm.IsAccessible)
                {
                    formFilm.Show();
                }
            }
            else
            {
                MessageBox.Show(_city == null ? "Вы не выбрали где находится кинотеатр" : "Вы не выбрали кинотеатр",
                    "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Вы точно хотите закрыть программу?", @"Закрытие программы", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
