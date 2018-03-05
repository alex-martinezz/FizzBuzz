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
                
                if(i%3==0 && i % 5 == 0)
                {
                    System.Console.WriteLine("Fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    System.Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    System.Console.WriteLine("Buzz");
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }   
            System.Console.ReadLine();
        }
    }
}
