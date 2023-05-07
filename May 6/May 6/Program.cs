using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace May_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first num: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second num: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter third num: ");
            double z = Convert.ToDouble(Console.ReadLine());
            double r = (x + y + z)/3;
            Console.WriteLine("result: " + r);
            Console.ReadLine();
        }
    }
}