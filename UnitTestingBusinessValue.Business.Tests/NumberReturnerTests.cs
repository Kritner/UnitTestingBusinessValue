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
        /// When ReturnNumberAsString is provided a number, the number is returned as a string
        /// </summary>
        [TestMethod]
        public void NumberReturner_ReturnNumberAsString_ReturnsNumberThatWasProvided()
        {
            // Arrange
            int expected = 42;
            NumberReturner biz = new NumberReturner();

            // Act
            var results = biz.ReturnNumberAsString(expected);

            // Assert
            Assert.AreEqual(expected.ToString(), results);
        }

    }
}
