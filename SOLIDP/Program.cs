using System;

namespace SOLIDP
{
    class Program
    {
        static void Main(string[] args)
        {
            DriverInfo driver = new DriverInfo() { FullName = "Baki Özer", Email = "ozerbaki@hotmail.com.tr", PhoneNumber = "5554443322" };

            Mercedes mercedes = new Mercedes();
            //mercedes.SendTripInfoToDriver(driver);
            mercedes.SendTripInfoEmailToDriver(driver);
            mercedes.SendTripInfoSMSToDriver(driver);


            Toyota toyota = new Toyota();
            toyota.SendTripInfoEmailToDriver(driver);
            toyota.SendTripInfoSMSToDriver(driver);

            //BaseCar baseCar = new BaseCar();
            //Bunu yapmaya izin vermiyoruz.

            var calculate = new FuelCostCalculator();
            var cost = calculate.Calculate(mercedes);

            Console.WriteLine(cost.ToString());
        }
    }
}
