using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FCTRL3___Dwie_cyfry_silni
{
    internal class Program
    {
        static void Main()
        {
            int numberOfTest = int.Parse(Console.ReadLine());

            string[] finalTexts = new string[numberOfTest];

            for (int i = 0; i < numberOfTest; i++)
            {
                string text = Console.ReadLine();
                
                double digit = long.Parse(text);

                if(digit < 10)
                {
                    int finalResult = 1;
                    for (int k = 1; k <= digit; k++)
                    {
                        finalResult *= k;
                    }
                    char[] charArray = finalResult.ToString().ToCharArray();
                    if(digit < 4)
                    {
                        Console.WriteLine($"0 {charArray[0]}");
                    }
                    else
                    {
                        int length = charArray.Length;
                        Console.WriteLine($"{charArray[length -2]} {charArray[length -1]}");
                    }
                }
                else
                {
                    Console.WriteLine("0 0");
                }
            }
        }
    }
}
