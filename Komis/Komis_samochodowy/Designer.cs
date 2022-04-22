using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Komis_samochodowy
{
    public partial class Designer : Form
    {
        Komis_samochodowy komis;
        string curBrand;
        string curModel;
        string curEngine;
        string curColor;
        string currImage;
        public static List<Car> cars = new List<Car>();
        public static List<Dictionary<String, String>> carList = new List<Dictionary<String, String>>();
        public Designer(Komis_samochodowy komis)
        {
            InitializeComponent();
            this.komis = komis;
            List<string> brands = FileReader.readEntity("brands");
            foreach (string str in brands)
            {
                marka.Items.Add(str);
            }
            wybierz.Hide();
        }

        private void Designer_FormClosed(object sender, FormClosedEventArgs e)
        {
            komis.Show();
        }

        private void marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            model.Items.Clear();
            silnik.Items.Clear();
            kolor.Items.Clear();

            curBrand = (string)((ListBox)sender).SelectedItem;
            string path = "brands\\" + curBrand;
            List<string> models = FileReader.readEntity(path);
            foreach (string str in models)
            {
                model.Items.Add(str);
            }

        }

        private void model_SelectedIndexChanged(object sender, EventArgs e)
        {
            silnik.Items.Clear();
            kolor.Items.Clear();

            curModel = (string)((ListBox)sender).SelectedItem;
            string path = "brands\\" + curBrand + "\\" + curModel;
            List<string> engine = FileReader.readEntity(path);
            foreach (string str in engine)
            {
                silnik.Items.Add(str);
            }
        }

        private void silnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            kolor.Items.Clear();

            curEngine = (string)((ListBox)sender).SelectedItem;
            string path = "brands\\" + curBrand + "\\" + curModel + "\\" + curEngine;
            List<string> color = FileReader.readEntity(path);
            foreach (string str in color)
            {
                kolor.Items.Add(str);
            }
        }

        private void kolor_SelectedIndexChanged(object sender, EventArgs e)
        {
            curColor = (string)((ListBox)sender).SelectedItem;
            string path = "brands\\" + curBrand + "\\" + curModel + "\\" + curEngine + "\\" + curColor + ".jpg";

            photo.Image = Image.FromFile(path);
            currImage = path;
            wybierz.Show();
        }

        private void wybierz_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("marka", curBrand);
            dict.Add("model", curModel);
            dict.Add("silnik", curEngine);
            dict.Add("kolor", curColor);
            dict.Add("image", currImage);
            Car car = new Car(curBrand, curModel, curEngine, curColor, currImage);
            cars.Add(car);
            carList.Add(dict);
            MessageBox.Show("Wybrano samochód!");
        }
    }
}
