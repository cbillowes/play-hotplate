namespace HotPlate.Core
{
    public class CellTemperatureCalculator
    {
        private readonly float[,] cells;

        public CellTemperatureCalculator(float[,] cells)
        {
            this.cells = cells;
        }
        
        public float GetAverage(int row, int column)
        {
            var top = (row - 1 >= 0) ? cells[row - 1, column] : 0f;
            var right = (column + 1 <= cells.GetUpperBound(1)) ? cells[row, column + 1] : 0f;
            var bottom = (row + 1 <= cells.GetUpperBound(0)) ? cells[row + 1, column] : 0f;
            var left = (column - 1 >= 0) ? cells[row, column - 1] : 0f;

            return (top + right + bottom + left)/4;
        }
    }
}