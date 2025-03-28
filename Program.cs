using System;

class Program
{
    static void Main()
    {
        Console.Title = "Дейко Влад"; 

        // Введення значень з клавіатури
        Console.Write("Введіть x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        // Задання константних значень
        double z = 0.88;
        double a = 0.85;
        double b = 0.56;

        // Обчислення значень виразів
        double L = Math.Sin(Math.Atan(1 / z));
        double m = (4 * Math.Pow(y, 2) * Math.Exp(Math.Pow(Math.Sin(x), 3))) / (3 * Math.Pow(z, 3) + Math.Log(x));
        double j = (Math.Pow(Math.Log(x), 2) + Math.Sqrt(x + a)) / Math.Tan(b * x);
        double q = Math.Sin(b * x) / (Math.Pow(b, 2) + Math.Pow(x, 2));

        // Виведення результатів
        Console.WriteLine("\nРезультати обчислень:");
        Console.WriteLine($"L = {L:F4}");
        Console.WriteLine($"m = {m:F4}");
        Console.WriteLine($"j = {j:F4}");
        Console.WriteLine($"q = {q:F4}");

        // Очікування натискання клавіші перед виходом
        Console.WriteLine("\nНатисніть будь-яку клавішу для виходу...");
        Console.ReadKey();
    }
}
