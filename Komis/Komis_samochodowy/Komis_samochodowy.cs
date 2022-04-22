using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komis_samochodowy
{
    public partial class Komis_samochodowy : Form
    {
        public Komis_samochodowy()
        {
            InitializeComponent();
        }

        private void Designer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Designer designer = new Designer(this);
            designer.Show();
        }

        private void Dodaj_samochód_Click(object sender, EventArgs e)
        {
            Dodaj dodaj = new Dodaj(this);
            dodaj.Show();
            this.Hide();
        }

        private void Rezerwacja_Click(object sender, EventArgs e)
        {
            Rezerwacja rezewacja = new Rezerwacja(this);
            rezewacja.Show();
            this.Hide();
        }
    }
}
