
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
    public class MagnaflowExhaust : Exhaust
    {

        private const decimal price = 379;
        private const int weight = 12800;
        private const int acceleration = 5;
        private const int topSpeed = 25;
        private const TunningGradeType gradeType = TunningGradeType.LowGrade;
        private const ExhaustType exhaustType = ExhaustType.NickelChromePlated;

        public MagnaflowExhaust() : base(price, weight, acceleration, topSpeed, gradeType, exhaustType)
        {
        }
    }
}
