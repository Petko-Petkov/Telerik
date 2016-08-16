
namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;

    public class Nissan350Z : MotorVehicle
    {
        private const int Nissan350ZWeightInGrams = 1280000;
        private const int Nissan350ZAccelerationBonus = 55;
        private const int Nissan350ZTopSpeedBonus = 220;
        private const decimal Nissan350ZPriceInUSADollars = 25999;

        public Nissan350Z() 
            : base(Nissan350ZPriceInUSADollars, Nissan350ZWeightInGrams, Nissan350ZTopSpeedBonus, Nissan350ZAccelerationBonus)
        {
        }
    }
}
