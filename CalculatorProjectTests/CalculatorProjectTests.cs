

using CalculatorProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorProjectTests
{
    [TestClass]
    public class CalculatorProjectTests
    {
        public TestContext? TestContext { get; set; } // TestContext is nullable

        [TestMethod]
        public void CalculatorProjectAdd_2_4_returns_6()
        {
            // Initialize x and y with default values
            int x = 0;
            int y = 0;

            // Safely parse TestContext properties if they are not null
            if (TestContext?.Properties["ValuX"] is string valuXStr)
            {
                x = int.Parse(valuXStr); // Direct parsing after null check
            }

            if (TestContext?.Properties["ValueY"] is string valueYStr)
            {
                y = int.Parse(valueYStr); // Direct parsing after null check
            }

            Calculator c = new Calculator();
            int result = c.Add(x, y);
            Assert.AreEqual(6, result); // The expected result should be 6 based on the test method's name
        }
    }
}
