using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables___Exercice_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int BC, CA;

            Console.WriteLine("Quelle est la valeur de BC ?");
            BC = int.Parse(Console.ReadLine());
            Console.WriteLine("Quelle est la valeur de CA");
            CA = int.Parse(Console.ReadLine());

            double BC2 = Math.Pow(BC, 2);
            double CA2 = Math.Pow(CA, 2);

            Console.WriteLine("La longueur de AB est de " + Math.Sqrt(BC2 + CA2) + " cm");
            Console.ReadLine();
        }
    }
}
