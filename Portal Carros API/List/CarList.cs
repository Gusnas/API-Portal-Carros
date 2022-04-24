using Portal_Carros_API.Domain.Helpers;
using Portal_Carros_API.Domain.Models;

namespace Portal_Carros_API.List
{
    public class CarList
    {
        private static List<Cars> carList = new List<Cars>()
            {
                new Cars { Id = 1, Consumption = 10.0, TankCapacity = 55, CurrentFuel = 25, AverageSpeed = 16, CarModel = "peugeot 208 gt", CarType = ECarsType.Turbo},
                new Cars { Id = 2, Consumption = 11.3, TankCapacity = 44, CurrentFuel = 21, AverageSpeed = 25, CarModel = "citroen ds3", CarType = ECarsType.Turbo},
                new Cars { Id = 3, Consumption = 10.2, TankCapacity = 50, CurrentFuel = 10, AverageSpeed = 46, CarModel = "chevrolet chevette", CarType = ECarsType.Basic},
                new Cars { Id = 4, Consumption = 6.7, TankCapacity = 80, CurrentFuel = 50, AverageSpeed = 20, CarModel = "bmw 328i", CarType = ECarsType.Economic},
                new Cars { Id = 5, Consumption = 9.5, TankCapacity = 40, CurrentFuel = 36, AverageSpeed = 14, CarModel = "volkswagen gol", CarType = ECarsType.Turbo}
            };

        public static List<Cars> GetCarList()
        {
            return carList;
        }
    }
}
