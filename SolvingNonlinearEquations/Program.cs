namespace SolvingNonlinearEquations
{
    public static class Program
    {
        public static void Main()
        {
            float EPSILON1 = 0.001f, EPSILON2 = 0.001f, EPSILON3 = 0.001f, EPSILON4 = 0.0001f, EPSILON5 = 0.0001f, EPSILON6 = 0.00001f;
            
            MathFunction Function = new MathFunction(x => (float)(Math.Pow(2, x) - 5 * Math.Pow(x, 2) + 10),
                x => (float)(Math.Log(2) * Math.Pow(2, x) - 10 * x),
                x => (float)(Math.Log(2) * Math.Log(2) * Math.Pow(2, x) - 10f));
           
            SimpleIterationMethodCalculator Calculator1 = new SimpleIterationMethodCalculator(Function);
            NewtonMethodCalculator Calculator2 = new NewtonMethodCalculator(Function);
            ChordMethodCalculator Calculator3 = new ChordMethodCalculator(Function);

            Console.WriteLine("Equation: 2^x - 5x^2 + 10 = 0");
            Console.WriteLine("Expected solution:\n-1.440054\n1.6165551\n8.432747\n");

            Console.WriteLine("Simple iteration method:");
            Console.WriteLine(Calculator1.Solve(-2, -1, -0.0967f, EPSILON1));
            Console.WriteLine(Calculator1.Solve(1, 2, 0.058f, EPSILON1));
            Console.WriteLine(Calculator1.Solve(8, 9, -0.003775f, EPSILON1));

            Console.WriteLine();

            Console.WriteLine("Newton method:");
            Console.WriteLine(Calculator2.Solve(-2, -1, EPSILON2));
            Console.WriteLine(Calculator2.Solve(1, 2, EPSILON2));
            Console.WriteLine(Calculator2.Solve(8, 9, EPSILON2));

            Console.WriteLine();

            Console.WriteLine("Chord method:");
            Console.WriteLine(Calculator3.Solve(-2, -1, EPSILON3));
            Console.WriteLine(Calculator3.Solve(1, 2, EPSILON3));
            Console.WriteLine(Calculator3.Solve(8, 9, EPSILON3));
            
            Function = new MathFunction(x => (float)(100*Math.Pow(x, 2) - 10000*x - 2),
                x => (float)(200*x - 10000), x => 200f);

            Calculator1 = new SimpleIterationMethodCalculator(Function);
            Calculator2 = new NewtonMethodCalculator(Function);
            Calculator3 = new ChordMethodCalculator(Function);

            Console.WriteLine();

            Console.WriteLine("Equation: 100x^2 - 10000x - 2 = 0");
            Console.WriteLine("Expected solution:\n100.0002\n");

            Console.WriteLine("Simple iteration method:");
            Console.WriteLine(Calculator1.Solve(100, 101, -0.000098f, EPSILON4));

            Console.WriteLine();

            Console.WriteLine("Newton method:");
            Console.WriteLine(Calculator2.Solve(100, 101, EPSILON5));

            Console.WriteLine();

            Console.WriteLine("Chord method:");
            Console.WriteLine(Calculator3.Solve(100, 101, EPSILON6));
        }
    }
}
