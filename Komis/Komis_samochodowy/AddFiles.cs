using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Drawing;

namespace Komis_samochodowy
{
    class AddFiles
    {
        static public void addCar(string marka, string model, string silnik, string kolor, string file)
        {
            StreamWriter stream;

            Directory.CreateDirectory("brands");
            stream = File.AppendText("brands.txt");
            stream.Close();
            if (!FileReader.readEntity("brands").Contains(marka))
            {
                stream = File.AppendText("brands.txt");
                stream.WriteLine(marka);
                stream.Close();
            }
                

            Directory.CreateDirectory("brands\\" + marka);
            stream = File.AppendText("brands\\" + marka + ".txt");
            stream.Close();
            if (!FileReader.readEntity("brands\\" + marka).Contains(model))
            {
                stream = File.AppendText("brands\\" + marka + ".txt");
                stream.WriteLine(model);
                stream.Close();
            }
                

            Directory.CreateDirectory("brands\\" + marka + "\\" + model);
            stream = File.AppendText("brands\\" + marka + "\\" + model + ".txt");
            stream.Close();
            if (!FileReader.readEntity("brands\\" + marka + "\\" + model).Contains(silnik))
            {
                stream = File.AppendText("brands\\" + marka + "\\" + model + ".txt");
                stream.WriteLine(silnik);
                stream.Close();
            }
                

            Directory.CreateDirectory("brands\\" + marka + "\\" + model + "\\" + silnik);
            stream = File.AppendText("brands\\" + marka + "\\" + model + "\\" + silnik + ".txt");
            stream.Close();
            if (!FileReader.readEntity("brands\\" + marka + "\\" + model + "\\" + silnik).Contains(kolor))
            {
                stream = File.AppendText("brands\\" + marka + "\\" + model + "\\" + silnik + ".txt");
                stream.WriteLine(kolor);
                stream.Close();
            }
                

            Image.FromFile(file).Save("brands\\" + marka + "\\" + model + "\\" + silnik + "\\" + kolor + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

        }
    }
}
