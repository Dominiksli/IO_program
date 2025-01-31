namespace QuadraticSolverNamespace 
{
    public class QuadraticSolver
    {
        public static (double?, double?) SolveQuadratic(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;
            if (delta < 0)
                return (null, null);  // Brak pierwiastków rzeczywistych
            if (delta == 0)
                return (-b / (2 * a), null);  // Jeden pierwiastek
            double sqrtDelta = Math.Sqrt(delta);
            return ((-b + sqrtDelta) / (2 * a), (-b - sqrtDelta) / (2 * a));  // Dwa pierwiastki
        }
    }
}
