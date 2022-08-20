using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDP
{
    public class FuelCostCalculator
    {
        public double Calculate(BaseCar car)
        {
            //if (car is Toyota)
            //{
            //   return car.TripInfo * 1;
            //}
            //else if (car is Mercedes)
            //{
            //    return car.TripInfo * 2;
            //}
            //else
            //{
            //    return car.TripInfo * 3;
            //}
            return car.TripInfo * car.GetPerCostKm();
        }
    }
}
