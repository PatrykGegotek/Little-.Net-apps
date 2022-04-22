using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Komis_samochodowy
{
    public partial class Dodaj : Form
    {
        String file;
        Komis_samochodowy komis;
        public Dodaj(Komis_samochodowy komis)
        {
            this.komis = komis;
            InitializeComponent();
        }

        private void wybierzZdjecie_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                //pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                //textBox1.Text = open.FileName;
                file = open.FileName;
            }
        }

        private void Dodaj_FormClosed(object sender, FormClosedEventArgs e)
        {
            komis.Show();
        }

        private void zapisz_Click(object sender, EventArgs e)
        {
            String Marka = markaT.Text;
            String Model = modelT.Text;
            String Silnik = silnikT.Text;
            String Kolor = kolorT.Text;

            if(Marka.Length == 0 || Model.Length == 0 || Silnik.Length == 0 || Kolor.Length == 0 || file == null)
            {
                MessageBox.Show("Zbyt mało informacji!");
                return;
            }

            AddFiles.addCar(Marka, Model, Silnik, Kolor, file);
            MessageBox.Show("Zapisano pomyślnie!");
            Close();


        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            markaT.Text = modelT.Text = silnikT.Text = kolorT.Text = "";
            file = null;
        }

        private void wyjdz_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
