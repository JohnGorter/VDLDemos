using System;
using ConsoleApp9;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class TubaViewModelUnitTests
    {
        [TestInitialize]
        public void init() {
            Console.WriteLine("Starting the unit test");
        }

        [TestMethod]
        public void AddressShouldContainPostalCode()
        {
            // Arrange
            Calculator calc = new Calculator();
            int a = 10;
            int b = 10;
            int expected = 20;

            // Act
            int result = calc.add(a,b);

            // Assert
            Assert.AreEqual(result, expected);
        }


        [TestMethod]
        public void AddressShouldContainStreet()
        {
            // Arrange
            Calculator calc = new Calculator();
            int a = 0;
            int b = 10;
            int expected = 10;

            // Act
            int result = calc.add(a, b);

            // Assert
            Assert.AreEqual(result, expected);
        }



        [TestCleanup]
        public void cleanup() {
            Console.WriteLine("clean up test");
        }
    }
}
