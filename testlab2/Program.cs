using static testlab2.Class1;

Console.WriteLine("Введите радиус 1 шара:");
double r1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите радиус 2 шара:");
double r2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите радиус 3 шара:");
double r3 = Convert.ToDouble(Console.ReadLine());

SphereCalculations calc = new SphereCalculations();

double[] radius = { r1, r2, r3 };

for (int i = 0; i < radius.Length; i++)
{
    double charge = calc.CalculateMaxCharge(radius[i]);
    double potential = calc.CalculatePotential(charge, radius[i]);

    Console.WriteLine($"Шар {i + 1}: Максимальный заряд = {charge:E2} Кл, Потенциал = {potential:E2} В");
}
