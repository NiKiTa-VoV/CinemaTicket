using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaLib;

namespace CinemaTicket
{
    public partial class FormTicket : Form
    {
        private Ticket _ticket;
        private static int _row = 0;
        private static int _price = 0;
        private static int _place = 0;
        public FormTicket(ref Ticket ticket)
        {
            this._ticket = ticket;
            _price = 0;
            _row = 1;
            _place = 1;

            InitializeComponent();
            numericUpDownRow.Minimum = 1;
            numericUpDownRow.Maximum = 8;
            numericUpDownPlace.Minimum = 1;
            numericUpDownPlace.Maximum = 24;
        }
        private void numericUpDownRyad_ValueChanged(object sender, EventArgs e)
        {
            _row = Convert.ToInt32(numericUpDownRow.Value);
            if (_row == 8)
            {
                numericUpDownPlace.Minimum = 2;
                numericUpDownPlace.Maximum = 23;
            }
            else
            {
                numericUpDownPlace.Minimum = 1;
                numericUpDownPlace.Maximum = 24;
            }
            if (_row < 5)
            {
                _price = 360;
            }
            else if ((_row == 5) || (_row == 6) || (_row == 7))
            {
                if ((_place > 7) && (_place < 18))
                {
                    _price = 390;
                }
                else
                {
                    _price = 360;
                }
            }
            else if ((_row == 8))
            {
                _price = 390;
            }
            labelPriceAll.Text = "Итог: ";
            labelPriceAll.Text += "ваш ряд " + _row + ", ваше место " + _place + ", цена билета " + _price + " руб.";
        }

        private void numericUpDownMesto_ValueChanged(object sender, EventArgs e)
        {
            _place = Convert.ToInt32(numericUpDownPlace.Value);
            if (_row < 5)
            {
                _price = 360;
            }
            else if ((_row == 5) || (_row == 6) || (_row == 7))
            {
                if ((_place > 7) && (_place < 18))
                {
                    _price = 390;
                }
                else
                {
                    _price = 360;
                }
            }
            else if ((_row == 8)) _price = 390;

            labelPriceAll.Text = "Итог: ";
            labelPriceAll.Text += "ваш ряд " + _row + ", ваше местав " + _place + ", цена билета " + _price + " руб.";
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите отменить оформление билета?", @"Отмена", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void buttonIssue_Click(object sender, EventArgs e)
        {
            if (_ticket != null)
            {
                _ticket.Row = _row;
                _ticket.Place = _place;
                _ticket.Price = _price;
                FormСheque formСheque = new(ref _ticket);
                formСheque.Show();
            }
        }
    }
}
