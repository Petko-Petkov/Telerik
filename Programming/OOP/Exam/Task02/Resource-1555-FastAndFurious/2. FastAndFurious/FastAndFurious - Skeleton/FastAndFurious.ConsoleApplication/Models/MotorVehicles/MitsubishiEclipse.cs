namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;

    public class MitsubishiEclipse : MotorVehicle
    {
        private const int MitsubishiEclipseWeightInGrams = 1400000;
        private const int MitsubishiEclipseAccelerationBonus = 24;
        private const int MitsubishiEclipseTopSpeedBonus = 230;
        private const decimal MitsubishiEclipsePriceInUSADollars = 29999;

        public MitsubishiEclipse() 
            : base(MitsubishiEclipsePriceInUSADollars, MitsubishiEclipseWeightInGrams, MitsubishiEclipseTopSpeedBonus, MitsubishiEclipseAccelerationBonus)
        {
        }
    }
}
