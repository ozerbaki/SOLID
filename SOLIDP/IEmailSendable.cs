using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDP
{
    public interface IEmailSendable
    {
        public void SendTripInfoEmailToDriver(DriverInfo driver);
    }
}
