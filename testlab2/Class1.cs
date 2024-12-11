using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testlab2
{
    public class Class1
    {
        public class SphereCalculations
        {
            const double Strength = 3e6; // Напряженость поля
            const double Epsilon = 8.85e-12; // Электрическая постоянная

            public double CalculateMaxCharge(double radius)
            {
                return Strength * radius * Epsilon;
            }

            public double CalculatePotential(double charge, double radius)
            {
                return charge / (4 * Math.PI * Epsilon * radius);
            }
        }
    }
}
