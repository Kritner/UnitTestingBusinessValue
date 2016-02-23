using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingBusinessValue.Business.Tests
{

    /// <summary>
    /// Tests for NumberReturner
    /// </summary>
    [TestClass]
    public class NumberReturnerTests
    {

        /// <summary>
        /// Ensure ReturnNumberAsString has appropriate return type
        /// </summary>
        [TestMethod]
        public void NumberReturner_ReturnNumberAsString_CorrectReturnTypeIsString()
        {
            // Arrange
            int expected = 42;
            NumberReturner biz = new NumberReturner();

            // Act
            var results = biz.ReturnNumberAsString(expected);

            // Assert
            Assert.IsInstanceOfType(results, typeof(string));
        }

        /// <summary>
        /// When ReturnNumberAsString is provided a number, the number is returned as a string.  
        /// </summary>
        /// <remarks>
        /// Provided number must not be a factor of 3 or 5 to receive the same number back.
        /// </remarks>
        [TestMethod]
        public void NumberReturner_ReturnNumberAsString_ReturnsNumberThatWasProvided()
        {
            // Arrange
            int expected = 7;
            NumberReturner biz = new NumberReturner();

            // Act
            var results = biz.ReturnNumberAsString(expected);

            // Assert
            Assert.AreEqual(expected.ToString(), results);
        }

        /// <summary>
        /// number mod 3 and 5 returns FizzBuzz
        /// number mod 3 returns Fizz
        /// number mod 5 returns Buzz
        /// </summary>
        [TestMethod]
        public void NumberReturner_ReturnNumberAsString_SpecialCasesReturnValid()
        {
            // Arrange
            NumberReturner rt = new NumberReturner();
            int modThree = 9;
            int modFive = 10;
            int modThreeAndFive = 15;

            // Act
            var resultsModThree = rt.ReturnNumberAsString(modThree);
            var resultsModFive = rt.ReturnNumberAsString(modFive);
            var resultsModThreeAndFIve = rt.ReturnNumberAsString(modThreeAndFive);

            // Assert
            Assert.AreEqual("Fizz", resultsModThree, nameof(resultsModThree));
            Assert.AreEqual("Buzz", resultsModFive, nameof(resultsModFive));
            Assert.AreEqual("FizzBuzz", resultsModThreeAndFIve, nameof(resultsModThreeAndFIve));
        }

    }
}
