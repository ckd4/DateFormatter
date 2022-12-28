using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DateFormatter
{
    public static class Formatter
    {
        public static string Normalize(string text)
        {
            Regex reg1 = new Regex(@"\d*\d.\d*\d.\d\d*\d*\d");
            Regex reg2 = new Regex(@"\d*\d.\w+.\d*\d");
            if (reg1.IsMatch(text))
            {
                DateTime date = DateTime.Parse(reg1.Match(text).Value);
                return $"{date.Day.ToString().PadLeft(2, '0')}." +
                       $"{date.Month.ToString().PadLeft(2, '0')}." +
                       $"{date.Year.ToString().PadLeft(2, '0')}";
            }
            else
            {
                return text + " года";
            }
        }
    }
}
