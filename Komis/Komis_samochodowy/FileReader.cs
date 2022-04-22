using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Komis_samochodowy
{
    static class FileReader
    {
        static public List<string> readEntity(string path)
        {
            List<string> brands = new List<string>();
            StreamReader streamReader = new StreamReader(path + ".txt");

            string str = streamReader.ReadLine();

            while(str != null)
            {
                brands.Add(str);
                str = streamReader.ReadLine();
            }
            streamReader.Close();
            return brands;

        }

    }
}
