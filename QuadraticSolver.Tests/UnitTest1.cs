using Xunit;
using QuadraticSolverNamespace;

public class QuadraticSolverTests
{
    [Theory]
    [InlineData(1.0, -3.0, 2.0, 2.0, 1.0)]  // Dwa pierwiastki: x^2 - 3x + 2 = 0
    [InlineData(1.0, -2.0, 1.0, 1.0, null)]  // Jeden pierwiastek: x^2 - 2x + 1 = 0
    [InlineData(1.0, 2.0, 3.0, null, null)]  // Brak pierwiastków: x^2 + 2x + 3 = 0
    public void TestSolveQuadratic(double a, double b, double c, double? expectedRoot1, double? expectedRoot2)
    {
        
        var (root1, root2) = QuadraticSolver.SolveQuadratic(a, b, c);
        Console.WriteLine($"📌 TEST: Równanie {a}x² + {b}x + {c} = 0");
        Console.WriteLine($"🔹 Oczekiwane wyniki: {expectedRoot1}, {expectedRoot2}");
        Console.WriteLine($"✅ Obliczone wyniki: {root1}, {root2}");
        Console.WriteLine("----------------------------------");

        Assert.Equal(expectedRoot1, root1);
        Assert.Equal(expectedRoot2, root2);

    }
}
