using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Intercoolers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Intercoolers
{
    public class EvolutionXPerformanceIntercooler : Intercooler
    {
        private const decimal price = 499;
        private const int weight = 4500;
        private const int acceleration = -5;
        private const int topSpeed = 40;
        private const TunningGradeType gradeType = TunningGradeType.HighGrade;
        private const IntercoolerType intercoolerType = IntercoolerType.AirToLiquidIntercooler;
        
        public EvolutionXPerformanceIntercooler() : base(price, weight, acceleration, topSpeed, gradeType, intercoolerType)
        {
        }
    }
}
