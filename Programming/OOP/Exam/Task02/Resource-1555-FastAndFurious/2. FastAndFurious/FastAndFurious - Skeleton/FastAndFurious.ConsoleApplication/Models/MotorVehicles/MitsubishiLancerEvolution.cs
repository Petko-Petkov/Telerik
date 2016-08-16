
using FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles
{
    public class MitsubishiLancerEvolution : MotorVehicle
    {
        private const int MitsubishiLancerEvolutionWeightInGrams = 1780000;
        private const int MitsubishiLancerEvolutionAccelerationBonus = 20;
        private const int MitsubishiLancerEvolutionTopSpeedBonus = 300;
        private const decimal AcuraIntegraTypeRPriceInUSADollars = 56999;

        public MitsubishiLancerEvolution() 
            : base(AcuraIntegraTypeRPriceInUSADollars, MitsubishiLancerEvolutionWeightInGrams, MitsubishiLancerEvolutionTopSpeedBonus, MitsubishiLancerEvolutionAccelerationBonus)
        {
        }
    }
}
