using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Emp id:");
            int id=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Emp Name:");
            string Name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Basic Salary:");
            double bs=Convert.ToDouble(Console.ReadLine());

            double hra = (12 * bs) / 100;
            Console.WriteLine($"hrs is{hra}");

            double da = (20* bs) / 100;
            Console.WriteLine($"da is{da}");

            double ta = (10* bs) / 100;
            Console.WriteLine($"ta is{ta}");

            double pf = (12* bs) / 100;
            Console.WriteLine($"pf is{pf}");


        }
    }
}
