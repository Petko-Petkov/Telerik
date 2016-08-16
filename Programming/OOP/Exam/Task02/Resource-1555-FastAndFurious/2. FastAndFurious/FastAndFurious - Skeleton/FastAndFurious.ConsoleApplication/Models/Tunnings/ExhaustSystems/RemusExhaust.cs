using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
    public class RemusExhaust : Exhaust
    {
        private const decimal price = 679;
        private const int weight = 11500;
        private const int acceleration = 8;
        private const int topSpeed = 32;
        private const TunningGradeType gradeType = TunningGradeType.MidGrade;
        private const ExhaustType exhaustType = ExhaustType.StainlessSteel;

        public RemusExhaust() : base(price, weight, acceleration, topSpeed, gradeType, exhaustType)
        {
        }
    }
}
