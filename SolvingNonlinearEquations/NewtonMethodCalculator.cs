namespace SolvingNonlinearEquations
{
    public class NewtonMethodCalculator
    {
        public MathFunction Function { get; set; }

        public NewtonMethodCalculator(MathFunction _function)
        {
            if (_function == null) throw new ArgumentNullException(nameof(_function));
            Function = _function;
        }

        public float Solve(float left_border, float right_border, float epsilon = 0.001f)
        {
            float x = right_border, previousX = x + epsilon * 2;
            if (Function.CalculateSecondDerivative(right_border) * Function.Calculate(right_border) >= 0)
                x = left_border;
            else
                x = right_border;
            Console.WriteLine();
            while (Math.Abs(x - previousX) > epsilon)
            {
                previousX = x;
                x -= Function.Calculate(x) / Function.CalculateDerivative(x);
                Console.WriteLine(x);
            }

            Console.WriteLine();

            return previousX;
        }
    }
}
