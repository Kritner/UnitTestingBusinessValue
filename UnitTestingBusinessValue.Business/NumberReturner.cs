using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingBusinessValue.Business
{

    /// <summary>
    /// This class is used to return a number.
    /// </summary>
    public class NumberReturner
    {

        /// <summary>
        /// Return the provided number as a string.
        /// If divisble evenly by 3, return fizz.
        /// By 5, returns buzz
        /// By both, returns fizzbuzz
        /// </summary>
        /// <param name="numberToReturn">The number to return</param>
        /// <returns>The number as string</returns>
        public string ReturnNumberAsString(int numberToReturn)
        {
            if (numberToReturn % 3 == 1 && numberToReturn % 5 == 1)
                return "FizzBuzz";
            else if (numberToReturn % 3 == 1)
                return "Fizz";
            else if (numberToReturn % 5 == 1)
                return "Buzz";

            return numberToReturn.ToString();
        }

    }
}
