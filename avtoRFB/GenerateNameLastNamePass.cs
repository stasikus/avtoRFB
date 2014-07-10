using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtoRFB
{
    class GenerateNameLastNamePass
    {
        public static string Name(string path)
        {
            List<string> names = new List<string>();
            using (var sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                    names.Add(sr.ReadLine());
            }

            Random random = new Random();
            int randomNumber = random.Next(0, names.Count);

            string randomName = names[randomNumber];

            return randomName;
        }

        public static string LastName(string path)
        {
            List<string> lastNames = new List<string>();
            using (var sr = new StreamReader(path))
            {
                while (sr.Peek() >= 0)
                    lastNames.Add(sr.ReadLine());
            }

            Random random = new Random();
            int randomNumber = random.Next(0, lastNames.Count);

            string randomLastName = lastNames[randomNumber];

            return randomLastName;
        }

        public static string Password(string name, string lastname)
        {
            string randomPass = "";
            DateTime ThToday = DateTime.Now;
            randomPass = name + "" + lastname + "" + ThToday.TimeOfDay.Seconds + "" + ThToday.Date.Day;
            return randomPass;
        }
    }
}
