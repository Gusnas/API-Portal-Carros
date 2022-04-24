using Xunit;
using Portal_Carros_API.Domain.Models;
using Portal_Carros_API.Domain.Helpers;
using Portal_Carros_API.Services;
using System;

namespace PortalCarrosApi.UnitTests
{
    public class PortalCarrosUnitTest
    {
        [Fact]
        public void RefuelCarTest_ReturnPositive()
        {
            Cars car = new Cars(10.0, 55, 25, 16, "peugeot 208 gt", ECarsType.Turbo);
            CarsService.RefuelCar(car, 5);
            Assert.Equal(30, car.CurrentFuel);
        }

        [Fact]
        public async void RefuelCarTest_ReturnNegative()
        {
            Cars car = new Cars(10.0, 55, 25, 16, "peugeot 208 gt", ECarsType.Turbo);
            string expectedException = "O valor a ser abastecido ultrapassa a capacidade do tanque";
            Exception actualException = null;
            try
            {
                CarsService.RefuelCar(car, 31);
            }
            catch(Exception ex)
            {
                actualException = ex;
            }
            Assert.Equal(expectedException, actualException.Message);
        }

        [Fact]
        public void TurboModeActivateTest_ReturnPositive()
        {
            Cars car = new(10.0, 55, 25, 16, "peugeot 208 gt", ECarsType.Turbo);
            CarsService.TurboModeActivate(car);
            Assert.Equal(7, car.Consumption);
            Assert.Equal(18.4, car.AverageSpeed);
        }

        [Fact]
        public void TurboModeActivateTest_ReturnNegative()
        {
            Cars car = new(10.0, 55, 25, 16, "peugeot 208 gt", ECarsType.Economic);
            string expectedException = "O carro selecionado não possui modo turbo";
            Exception actualException = null;
            try
            {
                CarsService.TurboModeActivate(car);
            }
            catch (Exception ex)
            {
                actualException = ex;
            }
            Assert.Equal(expectedException, actualException.Message);
        }

        [Fact]
        public void EconomicModeActivateTest_ReturnPositive()
        {
            Cars car = new(10.0, 55, 25, 16, "peugeot 208 gt", ECarsType.Economic);
            CarsService.EconomicModeActivate(car);
            Assert.Equal(11, car.Consumption);
        }

        [Fact]
        public void EconomicModeActivateTest_ReturnNegative()
        {
            Cars car = new(10.0, 55, 25, 16, "peugeot 208 gt", ECarsType.Turbo);
            string expectedException = "O carro selecionado não possui modo econômico";
            Exception actualException = null;
            try
            {
                CarsService.EconomicModeActivate(car);
            }
            catch (Exception ex)
            {
                actualException = ex;
            }
            Assert.Equal(expectedException, actualException.Message);
        }
    }
}