using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findThePrime
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {                
                Console.WriteLine("Give me the start: ");
                int start;
                do
                {
                    int.TryParse(Console.ReadLine(), out start);
                    if (start <= 1)
                    {
                        Console.WriteLine("The start must not be a negative number or 1: ");
                        Console.Write("Give the right start: ");
                    }
                } while (start <= 1);
                Console.WriteLine("Give me the end: ");
                int end;
                while (!int.TryParse(Console.ReadLine(), out end))
                {
                    Console.WriteLine("Give me a number");
                }

                Tools.findThePrime(start, end);                
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
            Console.ReadKey();

        }
        class Tools
        {
            public static void findThePrime(int start, int end)
            {
                List<int> primeNum = new List<int>();
                bool prime = true;
                for (int a = start; a <= end; a++)
                {
                    for (int b = 2; b <= end; b++)
                    {
                        if (a != b && a % b == 0)
                        {
                            prime = false;
                            break;
                        }
                    }
                    if (prime)
                    {
                        primeNum.Add(a);

                    }
                    prime = true;
                }
                Console.Write($"The prime numbers between {start} and {end} are: ");
                for (int i = 0; i < primeNum.Count; i++)
                {
                    Console.Write($"{primeNum[i]} ");
                }
            }
            
        }
        
    }
}
