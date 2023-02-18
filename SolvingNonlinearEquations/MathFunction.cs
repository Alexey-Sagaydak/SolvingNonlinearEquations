using System.Security.Cryptography.X509Certificates;

namespace SolvingNonlinearEquations
{
    public class MathFunction
    {
        private readonly Func<float, float> function;

        private readonly Func<float, float> derivative;

        public MathFunction(Func<float, float> _function, Func<float, float> _derivative)
        {
            function= _function;
            derivative = _derivative;
        }
        
        public float Calculate(float x)
        {
            return function(x);
        }

        public float CalculateDerivative(float x)
        {
            return derivative(x); 
        }
    }
}