using FunctionCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            while (Math.Abs(x - previousX) > epsilon)
            {
                previousX = x;
                x -= Function.Calculate(x) / Function.CalculateDerivative(x);
            }

            return previousX;
        }

        public (float, float, float) PrintSolutions(float epsilon = 0.001f)
        {
            return (
                Solve(-2, -1, epsilon),
                Solve(1, 2, epsilon),
                Solve(8, 9, epsilon)
                );
        }
    }
}
