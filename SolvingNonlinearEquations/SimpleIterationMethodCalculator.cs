using FunctionCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class SimpleIterationMethodCalculator
    {
        public MathFunction Function { get; set; }
        public float[] Lambdas { get; set; }

        public SimpleIterationMethodCalculator(MathFunction _function)
        {
            if (_function == null) throw new ArgumentNullException(nameof(_function));
            Function = _function;
            Lambdas = new float[3] { -0.0967f, 0.058f, -0.003775f };
        }

        private float g(float epsilon, float q) => (q - 1) / q * epsilon;

        public float Solve(float left_border, float right_border, float lambda, float epsilon = 0.001f)
        {
            float x = left_border, previousX = left_border;
            while (true)
            {
                float absDerivative = Math.Abs(Function.CalculateDerivative(x, lambda));

                if (absDerivative < 0.5)
                    if (Math.Abs(x - previousX) <= epsilon) break;
                else
                    if (Math.Abs(x - previousX) <= g(epsilon, absDerivative)) break;
                
                previousX = x;
                x = Function.Calculate(x, lambda);
            }
            return x;
        }

        public (float, float, float) PrintSolutions(float epsilon = 0.00000001f)
        {
            return (
                Solve(-2, -1, Lambdas[0], epsilon),
                Solve(1, 2, Lambdas[1], epsilon),
                Solve(8, 9, Lambdas[2], epsilon)
                );
        }
    }
}
