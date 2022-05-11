using System;
using System.Drawing;

namespace RGBGradient.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Color endVal = Color.FromArgb(99, 236, 133);
            Color beginVal = Color.FromArgb(255, 191, 133);

            GradientCalculator gradientCalculator = new GradientCalculator();         

            int totalSteps = 10;
            for (int i = 1; i <= totalSteps; i++)
            {
                var nextColor = gradientCalculator.GetGradientStep(beginVal, endVal, i, totalSteps);
                Console.WriteLine($"R: {nextColor.R}, G: {nextColor.G}, B:{nextColor.B}", nextColor);
            }
        }
    }
}
