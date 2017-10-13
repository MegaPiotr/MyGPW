using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyGPW
{
    class Company
    {
        static int counter = 0;
        public string Walor { get; set; }
        public double Kurs { get; set; }
        public double Zmiana { get; set; }
        public double ZmianaProc { get; set; }
        public long LiczbaTranakcji { get; set; }
        public long Obrot { get; set; }
        public double Otwarcie { get; set; }
        public double Max { get; set; }
        public double Min { get; set; }
        public DateTime Czas { get; set; }

        public Company(string text)
        {
            counter++;
            Func < Match, string> preper = match => Regex.Replace(match.ToString(), "&nbsp;", "");
            Match m = Regex.Match(text, @"(?<=<td[^>]*>\s*)(?s).*?(?-s)(?=\s*</td>)");
            Match name = Regex.Match(m.ToString(), @"(?<=<a title[^>]*>).*?(?=</a>)");
            if (!name.Success) return;
            Walor = name.ToString();
            m = m.NextMatch();
            Kurs = double.Parse(preper(m));
            m = m.NextMatch();
            Zmiana = double.Parse(preper(m));
            m = m.NextMatch();
            ZmianaProc = double.Parse(preper(m).TrimEnd('%'));
            m = m.NextMatch();
            LiczbaTranakcji = long.Parse(preper(m));
            m = m.NextMatch();
            Obrot = long.Parse(preper(m));
            m = m.NextMatch();
            Otwarcie = double.Parse(preper(m));
            m = m.NextMatch();
            Min = double.Parse(preper(m));
            m = m.NextMatch();
            Max = double.Parse(preper(m));
            m = m.NextMatch();
            Czas = DateTime.ParseExact(m.ToString(), "dd.MM HH:mm",
                                       System.Globalization.CultureInfo.InvariantCulture);
            Czas.AddYears(DateTime.Now.Year);
        }
    }
}
