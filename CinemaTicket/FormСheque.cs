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
    public partial class FormСheque : Form
    {
        private const string DefaultLabelCheque = "Ваш чек на фильм: ";

        public FormСheque()
        {
            InitializeComponent();
            saveFileDialogCheque.DefaultExt = "txt";
            saveFileDialogCheque.AddExtension = true;
            saveFileDialogCheque.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialogCheque.FileName = "Чек.txt";
            labelCheque.Text = DefaultLabelCheque;
            labelCheque.Text += Ticket.Film.Name;
            textBoxСheque.Text = "";
            textBoxСheque.Text =
                "Чек" + Environment.NewLine
                + "Название города:  " + Ticket.City.Name + Environment.NewLine
                + "Название кинотеатр:  " + Ticket.Cinema.Name + Environment.NewLine
                + "Название фильма:  " + Ticket.Film.Name + Environment.NewLine
                + "Дата сеанса:  " + Ticket.Date.ToString("dd.MM.yyyy") + Environment.NewLine
                + "Время сеанса:  " + Ticket.Session + Environment.NewLine
                + "Ряд:  " + Ticket.Row + "    Место:  " + Ticket.Place + Environment.NewLine
                + "Стоимость билета:  " + Ticket.Price + " руб.";
        }

        private void buttonSaveCheque_Click(object sender, EventArgs e)
        {
            if (saveFileDialogCheque.ShowDialog() == DialogResult.OK)
                File.WriteAllText(saveFileDialogCheque.FileName, textBoxСheque.Text);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно сохранили чек?", @"Закрыть", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
