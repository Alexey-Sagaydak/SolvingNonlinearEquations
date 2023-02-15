namespace SolvingNonlinearEquations
{
    public static class Program
    {
        public static void Main()
        {
            float EPSILON = 0.001f;
            MathFunction Function = new MathFunction();

            Console.WriteLine("Equation: 2^x - 5x^2 + 10 = 0\n");

            SimpleIterationMethodCalculator Calculator1 = new SimpleIterationMethodCalculator(Function);
            (float s1, float s2, float s3) SimpleIterationMethodSolutions = Calculator1.PrintSolutions(EPSILON);

            Console.WriteLine("Simple iteration method:");
            Console.WriteLine(SimpleIterationMethodSolutions.s1);
            Console.WriteLine(SimpleIterationMethodSolutions.s2);
            Console.WriteLine(SimpleIterationMethodSolutions.s3);

            Console.WriteLine();

            NewtonMethodCalculator Calculator2 = new NewtonMethodCalculator(Function);
            (float s1, float s2, float s3) NewtonMethodSolutions = Calculator2.PrintSolutions(EPSILON);

            Console.WriteLine("Newton method:");
            Console.WriteLine(NewtonMethodSolutions.s1);
            Console.WriteLine(NewtonMethodSolutions.s2);
            Console.WriteLine(NewtonMethodSolutions.s3);

            Console.WriteLine();

            ChordMethodCalculator Calculator3 = new ChordMethodCalculator(Function);
            (float s1, float s2, float s3) ChordMethodSolutions = Calculator3.PrintSolutions(EPSILON);

            Console.WriteLine("Chord method:");
            Console.WriteLine(NewtonMethodSolutions.s1);
            Console.WriteLine(NewtonMethodSolutions.s2);
            Console.WriteLine(NewtonMethodSolutions.s3);
        }
    }
}
