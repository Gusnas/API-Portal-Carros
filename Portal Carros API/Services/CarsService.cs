
using Portal_Carros_API.Domain.Helpers;
using Portal_Carros_API.Domain.Models;

namespace Portal_Carros_API.Services
{
    public class CarsService
    {
        public static void RefuelCar(Cars car, double fuelQuantity)
        {
            double refuel = car.CurrentFuel + fuelQuantity;

            if (refuel <= car.TankCapacity)
                car.CurrentFuel += fuelQuantity;
            else
                throw new Exception("O valor a ser abastecido ultrapassa a capacidade do tanque");
        }

        public static void TurboModeActivate(Cars car)
        {
            if (car.CarType != ECarsType.Turbo)
                throw new Exception("O carro selecionado não possui modo turbo");

            if (car.IsTurboActive)
            {
                car.Consumption /= 0.70;
                car.AverageSpeed /= 1.15;
                car.IsTurboActive = false;
            }
            else
            {
                car.Consumption *= 0.70;
                car.AverageSpeed *= 1.15;
                car.IsTurboActive = true;
            }
        }

        public static void EconomicModeActivate(Cars car)
        {
            if (car.CarType != ECarsType.Economic)
                throw new Exception("O carro selecionado não possui modo econômico");

            if (car.IsEconomyModeActive)
            {
                car.Consumption /= 1.1;
                car.IsEconomyModeActive = false;
            }
            else
            {
                car.Consumption *= 1.10;
                car.IsEconomyModeActive = true;
            }
        }

        public static Cars GetFastestCar(List<Cars> carList, double distance)
        {
            Cars carAverageSpeed = null;
            double time = 0;
            double currentTime = 0;

            foreach (Cars car in carList)
            {
                if (carAverageSpeed == null)
                {
                    time = distance / car.AverageSpeed;
                    carAverageSpeed = car;
                }
                else
                {
                    currentTime = distance / car.AverageSpeed;
                    if (currentTime < time)
                    {
                        time = currentTime;
                        carAverageSpeed = car;
                    }
                }
            }

            return carAverageSpeed;
        }

        public static Cars GetBiggerAutonomy(List<Cars> carList)
        {
            Cars carAutonomy = null;

            foreach (Cars car in carList)
            {
                if (carAutonomy == null)
                    carAutonomy = car;
                else
                {
                    if (carAutonomy.Autonomy < car.Autonomy)
                        carAutonomy = car;
                }
            }

            return carAutonomy;
        }
    }
}
