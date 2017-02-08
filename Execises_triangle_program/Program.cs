using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execises_triangle_program
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Triangle Identifier";
            Triangle_checker triangle_checker = new Triangle_checker();
            int a;
            int b;
            int c;
            string side1;
            string side2;
            string side3;

            while (true)
            {
                Console.WriteLine("side 1: ");
                side1 = Console.ReadLine();
                if (!int.TryParse(side1, out a))
                {
                    Console.WriteLine("invalid input");
                    continue;
                }

                Console.WriteLine("side 2: ");
                side2 = Console.ReadLine();
                if (!int.TryParse(side2, out b))
                {
                    Console.WriteLine("invalid input");
                    continue;
                }

                Console.WriteLine("side 3: ");
                side3 = Console.ReadLine();
                if (!int.TryParse(side3, out c))
                {
                    Console.WriteLine("invalid input");
                    continue;
                }
                Console.WriteLine(triangle_checker.IdentifyTriangle(a, b, c));
            }
        }
    }
}