namespace Portal_Carros_API.Domain.Models
{
    public abstract class Cars
    {
        public int Id { get; set; }
        public double Consumption { get; set; }

        public double TankCapacity { get; set; }

        public double CurrentFuel { get; set; }

        public double AverageSpeed { get; set; }

        public string CarModel { get; set; }

        public virtual double Autonomy { get; set; }

    }
}
