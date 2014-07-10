using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtoRFB
{
    class GenerateEmail
    {
        public static string Email(string name, string lastName)
        {
            string readyEmail = "";
            List<string> domainList = new List<string>{ "gmail.com", "mail.ru", "inbox.ru", "ukr.net", "yahoo.com", "list.ru", "bk.ru", "yandex.ru", "yandex.com", "i.ua", "gmail.ru" };
            DateTime ThToday = DateTime.Now;
            Random random = new Random();
            int randomNumber = random.Next(0, domainList.Count);

            readyEmail = lastName.ToLower() + "-" + name.ToLower() + "" + ThToday.Second + "" + ThToday.Minute + "_" + random.Next(1960, 2000) + "@" + domainList[randomNumber];
            return readyEmail;
        }
    }
}
