namespace SolvingNonlinearEquations
{
    public class SimpleIterationMethodCalculator
    {
        public MathFunction Function { get; set; }

        public SimpleIterationMethodCalculator(MathFunction _function)
        {
            if (_function == null) throw new ArgumentNullException(nameof(_function));
            Function = _function;
        }

        private float g(float epsilon, float q) => (q - 1) / q * epsilon;

        public float Solve(float left_border, float right_border, float lambda, float epsilon = 0.001f)
        {
            float x = left_border, previousX = left_border;
            while (true)
            {
                float absDerivative = Math.Abs(CalculateDerivativeFi(x, lambda));

                if (absDerivative < 0.5)
                    if (Math.Abs(x - previousX) <= epsilon) break;
                else
                    if (Math.Abs(x - previousX) <= g(epsilon, absDerivative)) break;
                
                previousX = x;
                x = CalculateFi(x, lambda);
            }
            return x;
        }

        private float CalculateFi(float x, float lambda)
        {
            return (float) Function.Calculate(x) * lambda + x;
        }

        private float CalculateDerivativeFi(float x, float lambda)
        {
            return (float) lambda * Function.CalculateDerivative(x) + 1;
        }
    }
}
