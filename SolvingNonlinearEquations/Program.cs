namespace SolvingNonlinearEquations
{
    public static class Program
    {
        public static void Main()
        {
            MathFunction Function = new MathFunction();

            SimpleIterationMethodCalculator Calculator1 = new SimpleIterationMethodCalculator(Function);
            (float s1, float s2, float s3) SimpleIterationMethodSolutions = Calculator1.PrintSolutions();

            Console.WriteLine("Simple iteration method:");
            Console.WriteLine(SimpleIterationMethodSolutions.s1);
            Console.WriteLine(SimpleIterationMethodSolutions.s2);
            Console.WriteLine(SimpleIterationMethodSolutions.s3);

            Console.WriteLine();

            NewtonMethodCalculator Calculator2 = new NewtonMethodCalculator(Function);
            (float s1, float s2, float s3) NewtonMethodSolutions = Calculator2.PrintSolutions();

            Console.WriteLine("Newton method:");
            Console.WriteLine(NewtonMethodSolutions.s1);
            Console.WriteLine(NewtonMethodSolutions.s2);
            Console.WriteLine(NewtonMethodSolutions.s3);
        }
    }
}
