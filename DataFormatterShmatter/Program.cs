using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateFormatter;

namespace DataFormatterShmatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine(Formatter.Normalize(Console.ReadLine()) + "\n");
            }
            
        }
    }
}
