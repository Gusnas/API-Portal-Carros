using Microsoft.AspNetCore.Mvc;
using Portal_Carros_API.Domain.Models;
using Portal_Carros_API.List;
using Portal_Carros_API.Services;
using System.Text.Json;

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
        public ActionResult GetCars()
        {
            try
            {
                List<Cars> getCarList = CarList.GetCarList();
                if (getCarList == null)
                    return BadRequest("Lista de carros não cadastrada");

                return Ok(getCarList);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetCarsAutonomy")]
        public ActionResult GetCarsAutonomy()
        {
            try
            {
                List<Cars> getCarList = CarList.GetCarList();
                if (getCarList == null)
                    return BadRequest("Lista de carros não cadastrada");

                List<double> autonomy = new List<double>();
                foreach (Cars car in getCarList)
                {
                    autonomy.Add(car.Autonomy);
                }

                return Ok(autonomy);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpPut("RefuelCarByModel")]
        public ActionResult RefuelCarByModel(string carModel, double fuelQuantity)
        {
            try
            {
                List<Cars> getCarList = CarList.GetCarList();
                if (getCarList == null)
                    return BadRequest("Lista de carros não cadastrada");

                Cars car = getCarList.Find(x => x.CarModel == carModel);

                if (car != null)
                    CarsService.RefuelCar(car, fuelQuantity);

                return Ok(car);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("ActivateTurbo")]
        public ActionResult ActivateTurbo(string carModel)
        {
            try
            {
                carModel.ToLower();

                List<Cars> getCarList = CarList.GetCarList();
                if (getCarList == null)
                    return BadRequest("Lista de carros não cadastrada");

                Cars car = getCarList.Find(x => x.CarModel == carModel);

                if (car != null)
                    CarsService.TurboModeActivate(car);
                else
                    return BadRequest("Carro não encontrado");

                return Ok(car);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("ActivateEconomyMode")]
        public IActionResult ActivateEconomyMode(string carModel)
        {
            try
            {
                carModel.ToLower();

                List<Cars> getCarList = CarList.GetCarList();

                Cars car = getCarList.Find(x => x.CarModel == carModel);

                if (car != null)
                    CarsService.EconomicModeActivate(car);
                else
                    return BadRequest("Carro não encontrado");

                return Ok(car);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetBiggerAutonomy")]
        public ActionResult GetBiggerAutonomy()
        {
            try
            {
                List<Cars> getCarList = CarList.GetCarList();
                if (getCarList == null)
                    return BadRequest("Lista de carros não cadastrada");

                Cars carAutonomy = CarsService.GetBiggerAutonomy(getCarList);

                return Ok(carAutonomy);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetFastestCar")]
        public ActionResult GetFastestCar(double distance)
        {
            try
            {
                List<Cars> getCarList = CarList.GetCarList();
                if (getCarList == null)
                    return BadRequest("Lista de carros não cadastrada");

                Cars carAverageSpeed = CarsService.GetFastestCar(getCarList, distance);

                return Ok(carAverageSpeed);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
