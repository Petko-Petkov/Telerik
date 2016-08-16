using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    public class NissanGTR : MotorVehicle
    {
        private const int NissanGTRWeightInGrams = 1850000;
        private const int NissanGTRAccelerationBonus = 45;
        private const int NissanGTRTopSpeedBonus = 30;
        private const decimal NissanGTRPriceInUSADollars = 125000;

        public NissanGTR() 
            : base(NissanGTRPriceInUSADollars, NissanGTRWeightInGrams, NissanGTRTopSpeedBonus, NissanGTRAccelerationBonus)
        {
        }
    }
}
