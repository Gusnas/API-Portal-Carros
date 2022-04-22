namespace Portal_Carros_API.Domain.Models
{
    public class BasicCar : Cars
    {
        public override double Autonomy => this.Consumption * this.CurrentFuel;
    }
}
