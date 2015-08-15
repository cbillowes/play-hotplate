using System;
using System.ComponentModel;
using System.Threading;
using HotPlate.Core;

namespace HotPlate.Console
{
    class Program
    {
        private const int size = 6;
        private const float threshold = 0.001f;
        private const int delay = 1000;
        private static int turn;
        private static Core.HotPlate hotPlate;
        private static HotPlatePrinter hotPlatePrinter;
        private static HotPlateIterator hotPlateIterator;
        private static BackgroundWorker backgroundWorker;

        static void Main(string[] args)
        {
            Initialize();
            InitializeBackgroundWorker();

            System.Console.ReadLine();
        }

        private static void Initialize()
        {
            hotPlate = new Core.HotPlate(size);
            hotPlatePrinter = new HotPlatePrinter(hotPlate, threshold);
            hotPlateIterator = new HotPlateIterator(hotPlate);
            hotPlatePrinter.Print(turn);
            Thread.Sleep(delay);
        }

        private static void InitializeBackgroundWorker()
        {
            backgroundWorker = new BackgroundWorker { WorkerReportsProgress = true };
            backgroundWorker.DoWork += NextIteration;
            backgroundWorker.RunWorkerCompleted += Completed;
            backgroundWorker.ProgressChanged += ProgressChanged;
            backgroundWorker.RunWorkerAsync();
        }

        private static void ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            hotPlatePrinter.Print(turn);
        }

        private static void Completed(object sender, RunWorkerCompletedEventArgs e)
        {
            System.Console.WriteLine("Finished. Press any key to exit.");
        }

        private static void NextIteration(object sender, EventArgs e)
        {
            do
            {
                ++turn;
                hotPlateIterator.Iterate();
                backgroundWorker.ReportProgress(0);
                Thread.Sleep(delay);
            } while (hotPlate.HighestDiff >= threshold);
        }
    }
}
