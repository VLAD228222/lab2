using System;

class Program
{
    static void Main()
    {  
        Console.WriteLine($"Дейко Влад");

        Console.Write("Введіть значення x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть значення y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        double z = 1.13;
        double a = 0.25;
        double b = 0.8;

        double m = Math.Sqrt(a + b * z) / Math.Pow(Math.Log(x), 2);
        double f = Math.Pow(a, 2) * Math.Exp(-b * x);
        double i = 1 + x + Math.Pow(x, 4) / y;
        double j = x * Math.Atan(a);

        Console.WriteLine($"\nРезультати обчислень:");
        Console.WriteLine($"m = {m:F4}");
        Console.WriteLine($"f = {f:F4}");
        Console.WriteLine($"i = {i:F4}");
        Console.WriteLine($"j = {j:F4}");

        Console.ReadLine();
    }
}
