namespace SolvingNonlinearEquations
{
    public class MathFunction
    {
        public float CalculateFi(float x, float lambda)
        {
            return (float)(Math.Pow(2, x) - 5 * (float)Math.Pow(x, 2) + 10) * lambda + x;
        }

        public float CalculateDerivativeFi(float x, float lambda)
        {
            return (float)(Math.Log(2) * lambda * Math.Pow(2, x) - 10 * lambda * x + 1);
        }

        public float Calculate(float x)
        {
            return (float)(Math.Pow(2, x) - 5 * (float)Math.Pow(x, 2) + 10);
        }

        public float CalculateDerivative(float x)
        {
            return (float)(Math.Log(2) * Math.Pow(2, x) - 10 * x);
        }
    }
}