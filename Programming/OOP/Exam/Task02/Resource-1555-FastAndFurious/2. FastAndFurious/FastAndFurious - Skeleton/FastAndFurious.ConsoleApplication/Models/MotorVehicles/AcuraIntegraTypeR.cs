namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;

    public class AcuraIntegraTypeR : MotorVehicle
    {
        private const int AcuraIntegraTypeRWeightInGrams = 1700000;
        private const int AcuraIntegraTypeRAccelerationBonus = 15;
        private const int AcuraIntegraTypeRTopSpeedBonus = 200;
        private const decimal AcuraIntegraTypeRPriceInUSADollars = 24999;

        public AcuraIntegraTypeR() 
            : base(AcuraIntegraTypeRPriceInUSADollars, AcuraIntegraTypeRWeightInGrams, AcuraIntegraTypeRTopSpeedBonus, AcuraIntegraTypeRAccelerationBonus)
        {
        }
    }
}
