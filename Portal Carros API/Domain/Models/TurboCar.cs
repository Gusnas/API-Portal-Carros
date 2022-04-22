namespace Portal_Carros_API.Domain.Models
{
    public class TurboCar : Cars
    {
        public override double Autonomy => this.Consumption * this.CurrentFuel;

        public void TurboModeActivate()
        {
            this.Consumption *= 0.70;
            this.AverageSpeed *= 1.15;
        }
    }
}
