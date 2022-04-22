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

        public double Autonomy => Consumption * CurrentFuel;

        public ECarsType CarsType { get; set; }

    }
}
