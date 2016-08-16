namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems
{
    using FastAndFurious.ConsoleApplication.Common.Enums;
    using FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems.Abstract;

    public class BorlaExhaust : Exhaust
    {
        private const decimal price = 1299;
        private const int weight = 14600;
        private const int acceleration = 12;
        private const int topSpeed = 40;
        private const TunningGradeType gradeType = TunningGradeType.HighGrade;
        private const ExhaustType exhaustType = ExhaustType.CeramicCoated;

        public BorlaExhaust() : base(price, weight, acceleration, topSpeed, gradeType, exhaustType)
        {
        }
    }
}
