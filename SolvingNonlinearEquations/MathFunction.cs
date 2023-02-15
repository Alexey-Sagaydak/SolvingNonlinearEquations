namespace FunctionCalculator
{
    public class MathFunction
    {
        public float Calculate(float x, float lambda)
        {
            return (float)(Math.Pow(2, x) - 5 * (float)Math.Pow(x, 2) + 10) * lambda + x;
        }

        public float CalculateDerivative(float x, float lambda)
        {
            return (float)(Math.Log(2) * lambda * Math.Pow(2, x) - 10 * lambda * x + 1);
        }

    }
}