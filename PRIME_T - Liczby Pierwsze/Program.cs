using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIME_T___Liczby_Pierwsze
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfTests = int.Parse(Console.ReadLine());

            int digit = 0;
            string[] answers = new string[numberOfTests];
            for (int i = 0; i < numberOfTests; i++)
            {
                digit = int.Parse(Console.ReadLine());
                bool isPrime = true;

                if (digit < 2)
                {
                    answers[i] = "NIE";
                }
                else
                {
                    for (int k = 2; k * k <= digit; k++)
                    {
                        if (digit % k == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (digit == 3 || digit == 2)
                    {
                        isPrime = true;
                    }
                    answers[i] = isPrime ? "TAK" : "NIE";
                }
            }
            for (int i = 0; i < numberOfTests; i++)
            {
                Console.WriteLine(answers[i]);
            }
        }
    }
}
