using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Podaj współczynniki równania kwadratowego (a, b, c):");
        
        Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        var (root1, root2) = QuadraticSolver.SolveQuadratic(a, b, c);

        if (root1 == null && root2 == null)
        {
            Console.WriteLine("Brak pierwiastków rzeczywistych.");
        }
        else if (root2 == null)
        {
            Console.WriteLine($"Jeden pierwiastek: {root1}");
        }
        else
        {
            Console.WriteLine($"Dwa pierwiastki: {root1}, {root2}");
        }
    }
}
