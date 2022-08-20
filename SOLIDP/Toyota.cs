using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDP
{
    public class Toyota : BaseCar, IEmailSendable
    {
        public override double GetPerCostKm()
        {
            return 1;
        }

        public void SendTripInfoEmailToDriver(DriverInfo driver)
        {
            throw new NotImplementedException();
        }
    }
}
