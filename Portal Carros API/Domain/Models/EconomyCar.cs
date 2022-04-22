namespace Portal_Carros_API.Domain.Models
{
    public class EconomyCar : Cars
    {
        public override double Autonomy => this.Consumption * this.CurrentFuel;

        public void EconomicModeActivate()
        {
            this.Consumption *= 1.10;
            this.Autonomy *= 1.05;
        }
    }
}
