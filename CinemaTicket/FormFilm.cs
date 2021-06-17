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
using CinemaLib;

namespace CinemaTicket
{
    public partial class FormFilm : Form
    {
        DateTime _dateSession;
        Film _film;
        string _session;
        public FormFilm()
        {
            InitializeComponent();

            comboBoxFilm.Items.Clear();
            foreach (var filmName in Ticket.Cinema.Films.Keys)
            {
                comboBoxFilm.Items.Add(filmName);
            }
            dateTimePickerFilm.MinDate = DateTime.Now;
            dateTimePickerFilm.MaxDate = DateTime.Now.AddDays(6);
            _dateSession = dateTimePickerFilm.Value;
        }
        private void dateTimePickerFilm_ValueChanged(object sender, EventArgs e)
        {
            _dateSession = dateTimePickerFilm.Value;
        }
        private void comboBoxFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Ticket.Cinema.Films.TryGetValue((string)comboBoxFilm.SelectedItem, out var film))
            {
                _session = null;
                comboBoxSession.Items.Clear();
                foreach (var time in film.Sessions)
                {
                    comboBoxSession.Items.Add(time);
                }
                labelDescription.Text = "";
                labelDescription.Text = 
                    "Название: " + film.Name + Environment.NewLine + Environment.NewLine +
                    "Описание: " + film.Description + Environment.NewLine + Environment.NewLine +
                    "Дата выхода: " + film.DateRelease;

                _film = film;
            }
        }
        private void comboBoxSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            _session = (string)comboBoxSession.SelectedItem;
        }
        private void buttonTicket_Click(object sender, EventArgs e)
        {
            if (_film != null && _session != null)
            {
                Ticket.Date = _dateSession;
                Ticket.Film = _film;
                Ticket.Session = _session;
                FormTicket formTicket = new();
                formTicket.Show();
            }
            else
            {
                MessageBox.Show(_film == null ? "Вы не выбрали фильм" : "Вы не выбрали время сеанса", @"Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите отменить выбор фильма?", @"Отмена", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
