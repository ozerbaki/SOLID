using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDP
{
    public interface IMultipleEmailSendable
    {
        public void SendTripInfoEmailToDrivers(List<DriverInfo> drivers);
    }
}
