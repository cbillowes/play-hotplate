namespace HotPlate.Core
{
    public class AverageCellCalculator
    {
        public float GetAverage(HotPlate hotPlate, int row, int column)
        {
            var up = GetValueAboveCell(hotPlate, row, column);
            var left = (float)hotPlate[row, column - 1];
            var right = (float)hotPlate[row, column + 1];
            var down = (float)hotPlate[row + 1, column];
            var sum = up + left + right + down;
            return (sum / 4);
        }

        private float GetValueAboveCell(HotPlate hotPlate, int row, int column)
        {
            var aboveRowIndex = row - 1;
            return (float)hotPlate[row - 1, column];
        }
    }
}