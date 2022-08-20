using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDP
{
    public class Mercedes : BaseCar, IEmailSendable, ISMSSendable, IMultipleEmailSendable
    {
        public override double GetPerCostKm()
        {
            return 2;
        }

        public void SendTripInfoEmailToDriver(DriverInfo driver)
        {
            throw new NotImplementedException();
        }

        public void SendTripInfoEmailToDrivers(List<DriverInfo> drivers)
        {
            throw new NotImplementedException();
        }

        public void SendTripInfoSMSToDriver(DriverInfo driver)
        {
            throw new NotImplementedException();
        }
    }
}
