using Microsoft.AspNetCore.Mvc;
using Portal_Carros_API.Domain.Models;
using Portal_Carros_API.Services;
using System.Net;
using System.Net.Http;

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
                new TurboCar { Id = 1, Consumption = 10.0, TankCapacity = 55, CurrentFuel = 25, AverageSpeed = 16, CarModel = "Peugeot 208 GT"},
                new TurboCar { Id = 2, Consumption = 11.3, TankCapacity = 44, CurrentFuel = 21, AverageSpeed = 25, CarModel = "Citroen DS3"},
                new BasicCar { Id = 3, Consumption = 10.2, TankCapacity = 50, CurrentFuel = 10, AverageSpeed = 46, CarModel = "Chevrolet Chevette"},
                new EconomyCar { Id = 4, Consumption = 6.7, TankCapacity = 80, CurrentFuel = 50, AverageSpeed = 20, CarModel = "BMW 328i"},
                new TurboCar { Id = 5, Consumption = 9.5, TankCapacity = 40, CurrentFuel = 36, AverageSpeed = 14, CarModel = "Volkswagen Gol"}
            };
            return carList;
        }

        [HttpGet("GetCarsAutonomy")]
        public List<Cars> GetCarsAutonomy()
        {
            var carList = new List<Cars>
            {
                new TurboCar { Id = 1, Consumption = 10.0, TankCapacity = 55, CurrentFuel = 25, AverageSpeed = 16, CarModel = "Peugeot 208 GT"},
                new TurboCar { Id = 2, Consumption = 11.3, TankCapacity = 44, CurrentFuel = 21, AverageSpeed = 25, CarModel = "Citroen DS3"},
                new BasicCar { Id = 3, Consumption = 10.2, TankCapacity = 50, CurrentFuel = 10, AverageSpeed = 46, CarModel = "Chevrolet Chevette"},
                new EconomyCar { Id = 4, Consumption = 6.7, TankCapacity = 80, CurrentFuel = 50, AverageSpeed = 20, CarModel = "BMW 328i"},
                new TurboCar { Id = 5, Consumption = 9.5, TankCapacity = 40, CurrentFuel = 36, AverageSpeed = 14, CarModel = "Volkswagen Gol"}
            };
            return carList;
        }

        [HttpPut("RefuelCarByModel")]

        public ActionResult RefuelCarByModel(string carModel, double fuelQuantity)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);
                
                return Ok(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        [HttpPut("ActivateTurbo")]
        public ActionResult ActivateTurbo(string carModel)
        {
            try
            {
                TurboCar peugeot208GT = new TurboCar { Id = 1, Consumption = 10.0, TankCapacity = 55, CurrentFuel = 25, AverageSpeed = 16, CarModel = "Peugeot 208 GT" };
                peugeot208GT.TurboModeActivate();
                return Ok(peugeot208GT);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        [HttpPut("ActivateEconomyMode")]
        public IActionResult ActivateEconomyMode(string carModel)
        {
            try
            {
                EconomyCar bmw328 = new EconomyCar { Id = 4, Consumption = 6.7, TankCapacity = 80, CurrentFuel = 50, AverageSpeed = 20, CarModel = "BMW 328i" };
                bmw328.EconomicModeActivate();
                return Ok(bmw328);
            }
            catch(Exception ex)
            {
                throw;
            }
        }
        [HttpGet("GetBiggerAutonomy")]
        public Cars GetBiggerAutonomy()
        {
            return new TurboCar { Id = 1, Consumption = 10.0, TankCapacity = 55, CurrentFuel = 25, AverageSpeed = 16, CarModel = "Peugeot 208 GT" };
        }
        [HttpGet("GetFastestCar")]
        public Cars GetFastestCar()
        {
            return new TurboCar { Id = 1, Consumption = 10.0, TankCapacity = 55, CurrentFuel = 25, AverageSpeed = 16, CarModel = "Peugeot 208 GT" };
        }
    }
}
