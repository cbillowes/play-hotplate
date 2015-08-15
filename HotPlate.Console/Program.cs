using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using HotPlate.Core;

namespace HotPlate.Console
{
    class Program
    {
        private const int size = 6;
        private const float diff = 0.001f;
        private const int delay = 1000;
        private static int turn;
        private static Core.HotPlate hotPlate;
        private static BackgroundWorker backgroundWorker;

        static void Main(string[] args)
        {
            hotPlate = new Core.HotPlate(size);
            PrintHotPlate();
            System.Threading.Thread.Sleep(delay);

            backgroundWorker = new BackgroundWorker { WorkerReportsProgress = true };
            backgroundWorker.DoWork += NextIteration;
            backgroundWorker.RunWorkerCompleted += Completed;
            backgroundWorker.ProgressChanged += ProgressChanged;
            backgroundWorker.RunWorkerAsync();

            System.Console.ReadLine();
        }

        private static void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PrintHotPlate();
        }

        private static void Completed(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private static void NextIteration(object sender, EventArgs e)
        {
            for (var i = 0; i < 10; i++)
            {
                turn = i + 1;
                var calculator = new CellTemperatureCalculator();
                hotPlate.NextState(calculator);
                backgroundWorker.ReportProgress(0);
                System.Threading.Thread.Sleep(delay);
            }

        }

        private static void PrintHotPlate()
        {
            System.Console.Clear();
            System.Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine($"Grid: {size} x {size}");
            System.Console.WriteLine($"Turns: {turn}");
            System.Console.WriteLine($"Diff: {diff}");
            System.Console.WriteLine();

            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
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
            System.Console.WriteLine($"Actual diff: {diff}");
        }

        private static string GetPadding(float temperature)
        {
            var temperatureLength = temperature.ToString("F2").Length;
            var maximumPadding = "      ";
            return maximumPadding.Substring(0, maximumPadding.Length - temperatureLength);
        }

        private static ConsoleColor GetColor(float temperature)
        {
            if (temperature <= 33.33)
            {
                return ConsoleColor.Blue;
            }
            else if (temperature >= 66.66)
            {
                return ConsoleColor.Red;
            }
            return ConsoleColor.Yellow;
        }
    }
}
