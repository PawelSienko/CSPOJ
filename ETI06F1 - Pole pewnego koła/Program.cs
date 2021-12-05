using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETI06F1___Pole_pewnego_koła
{
    internal class Program
    {
        static void Main()
        {
            string[] args = Console.ReadLine().Split(' ');
            double r = double.Parse(args[0]);
            double d = double.Parse(args[1]);

            double s = Math.PI * (Math.Pow(r, 2) - Math.Pow((d / 2), 2));

            Console.Write(s);
        }
    }
}
