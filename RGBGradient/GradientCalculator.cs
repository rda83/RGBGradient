using System;
using System.Drawing;

namespace RGBGradient
{
    public class GradientCalculator
    {
        /// <summary>Returns an instance of Color with RGB values corresponding to the given gradient step.</summary>
        /// <param name="beginVal">Begin gradient value.</param>
        /// <param name="endVal">End gradient value.</param>
        /// <param name="stepNumber">Сalculated gradient step.</param>
        /// <param name="totalSteps">Total of gradient steps.</param> всего шагов
        /// <returns>
        ///   Instance of Color with RGB values corresponding to the given gradient step.
        /// </returns>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// totalSteps - Value must be greater than zero.
        /// or
        /// stepNumber - Value must be greater than zero.
        /// or
        /// stepNumber - Number of the current step cannot be greater than the total number of steps.
        /// </exception>
        public Color GetGradientStep(Color beginVal, Color endVal, int stepNumber, int totalSteps)
        {
            if (totalSteps <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(totalSteps), 
                    "Value must be greater than zero.");
            }

            if (stepNumber <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(stepNumber),
                    "Value must be greater than zero.");
            }

            if (stepNumber > totalSteps)
            {
                throw new ArgumentOutOfRangeException(nameof(stepNumber),
                    "Number of the current step cannot be greater than the total number of steps.");
            }

            if (stepNumber == 1)
            {
                return Color.FromArgb(beginVal.R, beginVal.G, beginVal.B);
            }

            return  Color.FromArgb(1,
                NextGradientVal(beginVal.R, endVal.R, stepNumber, totalSteps),
                NextGradientVal(beginVal.G, endVal.G, stepNumber, totalSteps),
                NextGradientVal(beginVal.B, endVal.B, stepNumber, totalSteps));
        }

        private static int NextGradientVal(int begin, int end, int stepNumber, int totalSteps)
        {
            var cost = (Convert.ToDouble(end) - Convert.ToDouble(begin)) / totalSteps;

            var nextVal = begin + (cost * stepNumber);

            if (nextVal > 255)
            {
                return 255;
            }
            else if (nextVal < 0)
            {
                return 0;
            }
            return (int)nextVal;
        }
    }
}
