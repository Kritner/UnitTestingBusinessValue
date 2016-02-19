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
        /// Return the provided number as a string
        /// </summary>
        /// <param name="numberToReturn">The number to return</param>
        /// <returns>The number as string</returns>
        public string ReturnNumberAsString(int numberToReturn)
        {
            return numberToReturn.ToString();
        }

    }
}
