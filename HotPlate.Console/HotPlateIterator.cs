using System.Threading;
using HotPlate.Core;

namespace HotPlate.Console
{
    public class HotPlateIterator
    {
        private readonly Core.HotPlate hotPlate;

        public HotPlateIterator(Core.HotPlate hotPlate)
        {
            this.hotPlate = hotPlate;
        }

        public void Iterate()
        {
            var calculator = new TemperatureCalculator();
            hotPlate.NextState(calculator);
        }
    }
}
