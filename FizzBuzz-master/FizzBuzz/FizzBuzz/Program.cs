using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i=1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    // Print FIZZBUZZ
                    System.Console.WriteLine("FIZZBUZZ");
                }
                else
                {
                    if (i % 3 == 0)
                    {
                        // Print FIZZ
                        System.Console.WriteLine("FIZZ");
                    }
                    else
                    {
                        if (i % 5 == 0)
                        {
                            // Print BUZZ
                            System.Console.WriteLine("BUZZ");
                        }
                        else
                        {
                            // Print normal number
                            System.Console.WriteLine(i);
                        }
                    }
                }
            }
            System.Console.ReadLine();
        }
    }
}
