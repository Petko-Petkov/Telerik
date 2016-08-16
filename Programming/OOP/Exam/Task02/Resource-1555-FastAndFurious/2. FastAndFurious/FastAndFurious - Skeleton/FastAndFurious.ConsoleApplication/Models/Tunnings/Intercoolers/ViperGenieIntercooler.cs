using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Intercoolers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Intercoolers
{
    public class ViperGenieIntercooler : Intercooler
    {
        private const decimal price = 289;
        private const int weight = 5300;
        private const int acceleration = 0;
        private const int topSpeed = 25;
        private const TunningGradeType gradeType = TunningGradeType.MidGrade;
        private const IntercoolerType intercoolerType = IntercoolerType.ChargeAirIntercooler;

        public ViperGenieIntercooler() : base(price, weight, acceleration, topSpeed, gradeType, intercoolerType)
        {
        }
    }
}
