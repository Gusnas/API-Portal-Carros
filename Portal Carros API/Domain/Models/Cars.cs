using Portal_Carros_API.Domain.Helpers;

namespace Portal_Carros_API.Domain.Models
{
    public class Cars
    {
        public int Id { get; set; }
        public double Consumption { get; set; }

        public double TankCapacity { get; set; }

        public double CurrentFuel { get; set; }

        public double AverageSpeed { get; set; }

        public string CarModel { get; set; }

        public double Autonomy { get { return this.Consumption * this.CurrentFuel; } set { } }

        public ECarsType CarType { get; set; }

        public bool IsTurboActive { get; set; }

        public bool IsEconomyModeActive { get; set; }

        public Cars(double consumption, double tankCapacity, double currentFuel, double averageSpeed, string carModel, ECarsType carType)
        {
            Consumption = consumption;
            TankCapacity = tankCapacity;
            CurrentFuel = currentFuel;
            AverageSpeed = averageSpeed;
            CarModel = carModel;
            CarType = carType;
        }

        public Cars(int id, double consumption, double tankCapacity, double currentFuel, double averageSpeed, string carModel, ECarsType carType)
        {
            Id = id;
            Consumption = consumption;
            TankCapacity = tankCapacity;
            CurrentFuel = currentFuel;
            AverageSpeed = averageSpeed;
            CarModel = carModel;
            CarType = carType;
        }
    }
}
