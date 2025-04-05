using Microsoft.VisualStudio.TestTools.UnitTesting;
using testlab2;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var calc = new Class1.SphereCalculations();

            double charge = calc.CalculateMaxCharge(0.01);
            Assert.AreEqual(2.655e-7, charge, 1e-10);

            double potential = calc.CalculatePotential(2.655e-7, 0.01);
            Assert.AreEqual(238732.41, potential, 1.0); 
        }
    }
}