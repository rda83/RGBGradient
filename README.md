# Gradient calculator library

C# library to Calculate RGB gradient value between two different colors.

Demo:

  ```csharp
  Color beginVal = Color.FromArgb(0, 255, 0);
  Color endVal = Color.FromArgb(255, 0, 0);
  
  GradientCalculator gradientCalculator = new GradientCalculator();         

  int totalSteps = 5;
  for (int i = 1; i <= totalSteps; i++)
  {
      var nextColor = gradientCalculator.GetGradientStep(beginVal, endVal, i, totalSteps);
      Console.WriteLine($"R: {nextColor.R}, G: {nextColor.G}, B:{nextColor.B}", nextColor);
  }
  ```
  
  Output:
  
  ```
  R: 0, G: 255, B:0
  R: 102, G: 153, B:0
  R: 153, G: 102, B:0
  R: 204, G: 51, B:0
  R: 255, G: 0, B:0
  ```
