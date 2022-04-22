using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Komis_samochodowy
{
    public partial class Kalendarz : Form
    {
        Rezerwacja rez;
        Car car;
        public Kalendarz(Rezerwacja rez, Car car)
        {
            this.rez = rez;
            this.car = car;
            InitializeComponent();
        }

        private void Kalendarz_FormClosed(object sender, FormClosedEventArgs e)
        {
            rez.Show();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (name.Text != "")
            {
                car.rez_date = monthCalendar1.SelectionStart;
                car.rez_name = textBox1.Text;
                car.reserved = true;
                Close();
            } else MessageBox.Show("Brak danych!");
        }
    }
}
