using System;

namespace HotPlate.Console
{
    public class HotPlatePrinter
    {
        private readonly Core.HotPlate hotPlate;
        private readonly float threshold;
        private readonly int size;

        public HotPlatePrinter(Core.HotPlate hotPlate, float threshold)
        {
            this.hotPlate = hotPlate;
            this.threshold = threshold;
            size = hotPlate.Size;
        }

        public void Print(int turn)
        {
            System.Console.Clear();
            System.Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"Grid: {size} x {size}");
            System.Console.WriteLine($"Turns: {turn}");
            System.Console.WriteLine($"Diff: {threshold}");
            System.Console.WriteLine();

            for (var row = 0; row < size; row++)
            {
                for (var column = 0; column < size; column++)
                {
                    var temperature = hotPlate[row, column];
                    var padding = GetPadding(temperature);
                    System.Console.ForegroundColor = GetColor(temperature);
                    System.Console.Write($"{padding}{temperature:F2} ");
                }
                System.Console.WriteLine();
            }
            System.Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine();
            System.Console.WriteLine($"Actual diff: {hotPlate.HighestDiff}");
        }

        private string GetPadding(float temperature)
        {
            var temperatureLength = temperature.ToString("F2").Length;
            var maximumPadding = "      ";
            return maximumPadding.Substring(0, maximumPadding.Length - temperatureLength);
        }


        private ConsoleColor GetColor(float temperature)
        {
            if (temperature <= 33.33)
            {
                return ConsoleColor.Blue;
            }
            if (temperature >= 66.66)
            {
                return ConsoleColor.Red;
            }
            return ConsoleColor.Yellow;
        }
    }
}
