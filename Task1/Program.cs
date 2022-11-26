using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradus = Convert.ToInt32(Console.ReadLine());
            int minute = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            Ugol ugol = new Ugol(gradus, minute, second);
            double ugolRadians = ugol.ToRadians();
            Console.WriteLine("{0:0.0000}", ugolRadians);
            Console.ReadKey();


        }
    }
}
