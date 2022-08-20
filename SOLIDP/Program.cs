using System;
using static SOLIDP.CustomException;

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
            //toyota.SendTripInfoSMSToDriver(driver);

            //BaseCar baseCar = new BaseCar();
            //Bunu yapmaya izin vermiyoruz.

            var cost = CalculateTripPost(mercedes);
            Console.WriteLine(cost.ToString());

            //RunCar();
        }

        private static double CalculateTripPost(BaseCar car)
        {
            var calculate = new FuelCostCalculator();
            return calculate.Calculate(car);
        }

        public void RunCar()
        {
            try
            {
                var mercedes = new Mercedes();
                mercedes.Run();
                mercedes.Stop();
                mercedes.SendTripInfoEmailToDriver(new DriverInfo());
            }
            catch (EngineException ex)
            {
                //new TripInfoLogger().LogToIstanbul(ex.Message);

                new TripInfoLogger(new IstanbulLogger()).Log(ex.Message);
                new TripInfoLogger(new AnkaraLogger()).Log(ex.Message);
               
            }
            catch (AirPressureException ex)
            {
                //new TripInfoLogger().LogToLocal(ex.Message);
                new TripInfoLogger(new LocalLogger()).Log(ex.Message);
            }
        }
    }
}
