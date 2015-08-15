using System.Collections.Generic;
using System.Linq;

namespace HotPlate.Core
{
    public class AverageTemperatureCalculator
    {
        private List<float> averages;
        
        public float GetAverage(float[,] cells, int row, int column)
        {
            averages = new List<float>();
            AddTemperatures(cells, row, column);
            return averages.Average();
        }

        private void AddTemperatures(float[,] cells, int row, int column)
        {
            AddTopTemperature(cells, row, column);
            AddRightTemperature(cells, row, column);
            AddBottomTemperature(cells, row, column);
            AddLeftTemperature(cells, row, column);
        }

        private void AddTopTemperature(float[,] cells, int row, int column)
        {
            if (row - 1 >= 0)
            {
                averages.Add(cells[row - 1, column]);
            }
        }

        private void AddRightTemperature(float[,] cells, int row, int column)
        {
            if (column + 1 <= cells.GetUpperBound(1))
            {
                averages.Add(cells[row, column + 1]);
            }
        }

        private void AddBottomTemperature(float[,] cells, int row, int column)
        {
            if (row + 1 <= cells.GetUpperBound(0))
            {
                averages.Add(cells[row + 1, column]);
            }
        }

        private void AddLeftTemperature(float[,] cells, int row, int column)
        {
            if (column - 1 >= 0)
            {
                averages.Add(cells[row, column - 1]);
            }
        }
    }
}