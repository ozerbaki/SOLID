using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDP
{
    public abstract class BaseCar
    {
        public int TripInfo { get; set; }

        public void Run() { }
        public void Stop() { }

        #region SendTripInfoToDriver
        //Hatalı Kulanım
        //public void SendTripInfoToDriver(DriverInfo driver) 
        //{
        //    if (!string.IsNullOrEmpty(driver.Email)) //Driver'ın Email bilgisi boş değilse
        //    {
        //        //Send Mail
        //    }

        //    if (!string.IsNullOrEmpty(driver.PhoneNumber)) //Driver'ın Email bilgisi boş değilse
        //    {
        //        //Send SMS
        //    }
        //} 
        #endregion

        #region S is single responsibility principle (SRP)
        //public void SendTripInfoEmailToDriver(DriverInfo driver)
        //{
        //    if (!string.IsNullOrEmpty(driver.Email)) //Driver'ın Email bilgisi boş değilse
        //    {
        //        //Send Mail
        //    }
        //}
        //public void SendTripInfoSMSToDriver(DriverInfo driver)
        //{
        //    if (!string.IsNullOrEmpty(driver.PhoneNumber)) //Driver'ın Email bilgisi boş değilse
        //    {
        //        //Send SMS
        //    }
        //}
        #endregion


        public abstract double GetPerCostKm();
    }
}
