using Portal_Carros_API.Domain.Helpers;
using Microsoft.AspNetCore.Mvc;
using Portal_Carros_API.Domain.Models;

namespace Portal_Carros_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;

        public CarsController(ILogger<CarsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetCars")]
        public IEnumerable<Cars> GetCars()
        {
            var carList = new List<Cars>
            {
                new Cars { Id = 1, Consumption = 10.0, TankCapacity = 55, CurrentFuel = 25, AverageSpeed = 16, CarModel = "Peugeot 208 GT", CarsType = ECarsType.Turbo},
                new Cars { Id = 2, Consumption = 11.3, TankCapacity = 44, CurrentFuel = 21, AverageSpeed = 25, CarModel = "Citroen DS3", CarsType = ECarsType.Turbo},
                new Cars { Id = 3, Consumption = 10.2, TankCapacity = 50, CurrentFuel = 10, AverageSpeed = 46, CarModel = "Chevrolet Chevette", CarsType = ECarsType.Basic},
                new Cars { Id = 4, Consumption = 6.7, TankCapacity = 80, CurrentFuel = 50, AverageSpeed = 20, CarModel = "BMW 328i", CarsType = ECarsType.Basic},
                new Cars { Id = 5, Consumption = 9.5, TankCapacity = 40, CurrentFuel = 36, AverageSpeed = 14, CarModel = "Volkswagen Gol", CarsType = ECarsType.Economic}
            };
            return carList;
        }

        [HttpGet("GetCarsAutonomy")]
        public List<Cars> GetCarsAutonomy()
        {
            var carList = new List<Cars>
            {
                new Cars { Id = 1, Consumption = 10.0, TankCapacity = 55, CurrentFuel = 25, AverageSpeed = 16, CarModel = "Peugeot 208 GT", CarsType = ECarsType.Turbo},
                new Cars { Id = 2, Consumption = 11.3, TankCapacity = 44, CurrentFuel = 21, AverageSpeed = 25, CarModel = "Citroen DS3", CarsType = ECarsType.Turbo},
                new Cars { Id = 3, Consumption = 10.2, TankCapacity = 50, CurrentFuel = 10, AverageSpeed = 46, CarModel = "Chevrolet Chevette", CarsType = ECarsType.Basic},
                new Cars { Id = 4, Consumption = 6.7, TankCapacity = 80, CurrentFuel = 50, AverageSpeed = 20, CarModel = "BMW 328i", CarsType = ECarsType.Basic},
                new Cars { Id = 5, Consumption = 9.5, TankCapacity = 40, CurrentFuel = 36, AverageSpeed = 14, CarModel = "Volkswagen Gol", CarsType = ECarsType.Economic}
            };
            return carList;
        }

        [HttpPost("RefuelCarByModel")]

        public string RefuelCarByModel()
        {
            return "teste";
        }



        [HttpPut("ActivateTurbo")]
        public string ActivateTurbo()
        {
            return "";
        }

        [HttpPut("ActivateEconomyMode")]
        public string ActivateEconomyMode()
        {
            return "";
        }
        [HttpGet("GetBiggerAutonomy")]
        public Cars GetBiggerAutonomy()
        {
            return new Cars { Id = 1, Consumption = 10.0, TankCapacity = 55, CurrentFuel = 25, AverageSpeed = 16, CarModel = "Peugeot 208 GT", CarsType = ECarsType.Turbo };
        }
        [HttpGet("GetFastestCar")]
        public Cars GetFastestCar()
        {
            return new Cars { Id = 1, Consumption = 10.0, TankCapacity = 55, CurrentFuel = 25, AverageSpeed = 16, CarModel = "Peugeot 208 GT", CarsType = ECarsType.Turbo };
        }
    }
}
