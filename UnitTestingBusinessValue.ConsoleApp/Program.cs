using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingBusinessValue.Business;

namespace UnitTestingBusinessValue.ConsoleApp
{

    /// <summary>
    /// Entry point into application
    /// </summary>
    class Program
    {

        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");

            int parsedValue = 0;
            int.TryParse(Console.ReadLine(), out parsedValue);

            Console.WriteLine("\n");

            NumberReturner nr = new NumberReturner();
            Console.WriteLine(nr.ReturnNumberAsString(parsedValue));

            Console.WriteLine("\n");
        }
    }
}
