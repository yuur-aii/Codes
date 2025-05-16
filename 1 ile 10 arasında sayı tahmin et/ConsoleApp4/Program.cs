using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Generate:
            Random random = new Random();
            int num = random.Next(1, 11);
            Console.Write("1 ile 10 arasınıda bir sayı tahmin edin :");

            int sayi = Convert.ToInt32(Console.ReadLine());
            if (num == sayi)
            { Console.WriteLine("Bildin!");
                Console.Read();
            }

            else
            {
                Console.WriteLine("Bilemedin yeniden dene :( ");
                goto Generate;
                
                
               

            }
        }
    }
    }