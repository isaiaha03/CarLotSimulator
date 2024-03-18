using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class CarLot
    {
        public List<Car> Cars { get; } = new List<Car>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }
    }
}
