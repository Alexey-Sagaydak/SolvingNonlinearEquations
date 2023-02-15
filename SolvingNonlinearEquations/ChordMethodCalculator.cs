﻿namespace SolvingNonlinearEquations
{
    public class ChordMethodCalculator
    {
        public MathFunction Function { get; set; }

        public ChordMethodCalculator(MathFunction _function)
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
                x -= (right_border - previousX) * Function.Calculate(previousX) /
                    (Function.Calculate(right_border) - Function.Calculate(previousX));
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