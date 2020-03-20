using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PythagoreanTheorem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mekkora az a oldal?");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Mekkora az b oldal?");
            float b = float.Parse(Console.ReadLine());
            Console.Write("A 'c' oldal hossza: '");
            Console.WriteLine(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
            Console.ReadKey();
        }
    }
}
