using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Komis_samochodowy
{
    public partial class Rezerwacja : Form
    {
        static List<Car> cars = Designer.cars;
        Komis_samochodowy komis;
        int i;
        public Rezerwacja(Komis_samochodowy komis)
        {
            this.komis = komis;
            this.i = 0;
            InitializeComponent();
            if(Designer.cars.Count != 0)
                showImage(i);
        }

        private void showImage(int i)
        {
            image.Image = Image.FromFile(cars[i].image);
            if (cars[i].reserved)
            {
                rez.Text = "Rezerwacja dla: " + cars[i].rez_name + " na dzień " + cars[i].rez_date.Day.ToString() 
                    + "." + cars[i].rez_date.Month.ToString();
            }
            else rez.Text = "";
        }

        private void Rezerwacja_FormClosed(object sender, FormClosedEventArgs e)
        {
            komis.Show();
        }

        private void right_Click(object sender, EventArgs e)
        {
            if (i < cars.Count - 1) i++;
            showImage(i);
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (i > 0) i--;
            showImage(i);
        }

        private void choose_Click(object sender, EventArgs e)
        {
            if(cars[i].reserved)
            {
                MessageBox.Show("Już zarezerwowany!");
                return;
            }
            Kalendarz kal = new Kalendarz(this, cars[i]);
            this.Hide();
            kal.ShowDialog();
            showImage(i);

        }
    }
}
