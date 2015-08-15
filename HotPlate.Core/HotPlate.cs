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

        public float[,] Current
        {
            get { return hotPlate; }
            private set { hotPlate = value; }
        }

        public bool CanCellValueChange(int row, int column)
        {
            return (!IsCornerCell(row, column) && !IsCenterCell(row, column));
        }

        public void NextState(CellTemperatureCalculator cellTemperatureCalculator)
        {
            var originalState = Current;
            var nextState = new float[Size, Size];
            for (var row = 0; row < Size; row++)
            {
                for (var column = 0; column < Size; column++)
                {
                    if (CanCellValueChange(row, column))
                    {
                        nextState[row, column] = cellTemperatureCalculator.GetAverage(originalState, row, column);
                    }
                    else
                    {
                        nextState[row, column] = this[row, column];
                    }
                }
            }
            Current = nextState;
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

        private int GetInitialCellValue(int row, int column)
        {
            var temperature = Temperatures.Default;
            if (IsCenterCell(row, column))
                temperature = Temperatures.Highest;
            else if (IsCornerCell(row, column))
                temperature = Temperatures.Lowest;
            return (int)temperature;
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
