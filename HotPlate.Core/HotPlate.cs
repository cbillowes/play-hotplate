using System;
using System.Collections.Generic;

namespace HotPlate.Core
{
    public class HotPlate
    {
        private float[,] hotPlate;

        public HotPlate(int size)
        {
            Size = size;
            hotPlate = hotPlate = new float[size, size];
            Initialize();
        }

        public int Size;
        public float this[int row, int column] => hotPlate[row, column];
        public float HighestDiff { get; private set; }

        public float[,] Current
        {
            get { return hotPlate; }
            private set { hotPlate = value; }
        }

        public bool CanCellValueChange(int row, int column)
        {
            return (!IsCornerCell(row, column) && !IsCenterCell(row, column));
        }

        public void NextState(TemperatureCalculator temperatureCalculator)
        {
            HighestDiff = 0;
            var currentState = Current;
            var nextState = new float[Size, Size];
            for (var row = 0; row < Size; row++)
            {
                for (var column = 0; column < Size; column++)
                {
                    if (CanCellValueChange(row, column))
                    {
                        nextState[row, column] = temperatureCalculator.GetAverage(currentState, row, column);
                    }
                    else
                    {
                        nextState[row, column] = this[row, column];
                    }
                    HighestDiff = GetHighestDiff(currentState, nextState, row, column);
                }
            }
            Current = nextState;
        }

        private float GetHighestDiff(float[,] currentState, float[,] nextState, int row, int column)
        {
            var currentValue = currentState[row, column];
            var nextValue = nextState[row, column];
            var diff = Math.Abs(currentValue - nextValue);
            return diff > HighestDiff ? diff : HighestDiff;
        }

        private void Initialize()
        {
            for (var row = 0; row < Size; row++)
            {
                for (var column = 0; column < Size; column++)
                {
                    hotPlate[row, column] = GetInitialCellValue(row, column);
                }
            }
        }

        private float GetInitialCellValue(int row, int column)
        {
            var temperature = Temperatures.Medium;
            if (IsCenterCell(row, column))
                temperature = Temperatures.Hot;
            else if (IsCornerCell(row, column))
                temperature = Temperatures.Cold;
            return (float)temperature;
        }

        private bool IsCornerCell(int row, int column)
        {
            var upperBounds = Size - 1;
            if (row == 0)
            {
                return column == 0 || column == upperBounds;
            }
            if (row == upperBounds)
            {
                return column == 0 || column == upperBounds;
            }
            return false;
        }

        private bool IsCenterCell(int row, int column)
        {
            var isCenter = false;
            var centerCell = Size / 2;
            var hasMultipleCenterCells = (Size % 2 == 0);
            if (hasMultipleCenterCells)
            {
                if (row == centerCell || row == centerCell - 1)
                {
                    isCenter = (column == centerCell || column == centerCell - 1);
                }
            }
            else
            {
                isCenter = row == centerCell && column == centerCell;
            }
            return isCenter;
        }
    }
}
