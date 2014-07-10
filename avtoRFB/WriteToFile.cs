using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtoRFB
{
    class WriteToFile
    {
        public static string line = "";
        public static void Writer(string path, string site, string format, string name, string lastname, string email, string pass)
        {
            if (format == "TXT")
            {
                line += lastname + " | " + name + " | " + email + " | " + pass;
            }
            else if (format == "CSV")
            {
                line += lastname + ";" + name + ";" + email + ";" + pass;
            }
            else if (format == "XLS")
            {
                line += lastname + " | " + name + " | " + email + " | " + pass;
            }

            StreamWriter sw = new StreamWriter(@""+ path +"//Created_"+ site +"_acc."+ format.ToLower() +"", true, System.Text.Encoding.UTF8);
            sw.WriteLine(line);
            sw.Close();
            line = "";
        }
    }
}
