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
        private static int _row;
        private static int _price;
        private static int _place;
        public FormTicket()
        {
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
            switch (_row)
            {
                case 8:
                    numericUpDownPlace.Minimum = 2;
                    numericUpDownPlace.Maximum = 23;
                    break;
                default:
                    numericUpDownPlace.Minimum = 1;
                    numericUpDownPlace.Maximum = 24;
                    break;
            }
            switch (_row)
            {
                case < 5:
                    _price = 360;
                    break;
                case 5:
                case 6:
                case 7:
                {
                    if (_place > 7 && _place < 18)
                    {
                        _price = 390;
                    }
                    else
                    {
                        _price = 360;
                    }

                    break;
                }
                case 8:
                    _price = 390;
                    break;
            }
            labelPriceAll.Text = "Итог: ";
            labelPriceAll.Text += "ваш ряд " + _row + ", ваше место " + _place + ", цена билета " + _price + " руб.";
        }

        private void numericUpDownMesto_ValueChanged(object sender, EventArgs e)
        {
            _place = Convert.ToInt32(numericUpDownPlace.Value);
            switch (_row)
            {
                case < 5:
                    _price = 360;
                    break;
                case 5:
                case 6:
                case 7:
                {
                    if (_place > 7 && _place < 1)
                        _price = 390;
                    else
                        _price = 360;
                    break;
                }
                case 8:
                    _price = 390;
                    break;
            }

            labelPriceAll.Text = "Итог: ";
            labelPriceAll.Text += "ваш ряд " + _row + ", ваше местав " + _place + ", цена билета " + _price + " руб.";
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите отменить оформление билета?", @"Отмена", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }
        private void buttonIssue_Click(object sender, EventArgs e)
        {
                Ticket.Row = _row;
                Ticket.Place = _place;
                Ticket.Price = _price;
                FormСheque formСheque = new();
                formСheque.Show();
        }

        private void pictureBoxHall_Click(object sender, EventArgs e)
        {

        }
    }
}
