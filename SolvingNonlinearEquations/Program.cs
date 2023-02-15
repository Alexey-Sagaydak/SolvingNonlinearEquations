using ConsoleApp3;
using FunctionCalculator;

public static class Program
{
    public static void Main()
    {
        SimpleIterationMethodCalculator Calculator1 = new SimpleIterationMethodCalculator(new MathFunction());
        (float s1, float s2, float s3) SimpleIterationMethodSolutions = Calculator1.PrintSolutions();

        Console.WriteLine("Метод простых итераций:");
        Console.WriteLine(SimpleIterationMethodSolutions.s1);
        Console.WriteLine(SimpleIterationMethodSolutions.s2);
        Console.WriteLine(SimpleIterationMethodSolutions.s3);
    }
}