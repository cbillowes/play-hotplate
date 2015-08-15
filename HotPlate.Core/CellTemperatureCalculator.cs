using System.Collections.Generic;
using System.Linq;

namespace HotPlate.Core
{
    public class CellTemperatureCalculator
    {
        public float GetAverage(float[,] cells, int row, int column)
        {
            var averages = new List<float>();
            if (HasTop(row)) averages.Add(GetTop(cells, row, column));
            if (HasRight(cells, column)) averages.Add(GetRight(cells, row, column));
            if (HasBottom(cells, row)) averages.Add(GetBottom(cells, row, column));
            if (HasLeft(column)) averages.Add(GetLeft(cells, row, column));
            return averages.Average();
        }

        private bool HasTop(int row) => row - 1 >= 0;

        private bool HasRight(float[,] cells, int column) => column + 1 <= cells.GetUpperBound(1);

        private bool HasBottom(float[,] cells, int row) => row + 1 <= cells.GetUpperBound(0);

        private bool HasLeft(int column) => column - 1 >= 0;

        private float GetTop(float[,] cells, int row, int column) => cells[row - 1, column];

        private float GetRight(float[,] cells, int row, int column) => cells[row, column + 1];

        private float GetBottom(float[,] cells, int row, int column) => cells[row + 1, column];

        private float GetLeft(float[,] cells, int row, int column) => cells[row, column - 1];
    }
}