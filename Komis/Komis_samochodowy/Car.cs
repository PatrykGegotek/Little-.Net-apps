using System;
using System.Collections.Generic;
using System.Text;

namespace Komis_samochodowy
{
    public class Car
    {
        public string marka;
        public string model;
        public string silnik;
        public string kolor;
        public string image;
        public DateTime rez_date;
        public string rez_name;
        public Boolean reserved;

        public Car(string marka, string model, string silnik, string kolor, string image)
        {
            this.marka = marka;
            this.model = model;
            this.silnik = silnik;
            this.kolor = kolor;
            this.image = image;
            this.reserved = false;
        }
    }
}
