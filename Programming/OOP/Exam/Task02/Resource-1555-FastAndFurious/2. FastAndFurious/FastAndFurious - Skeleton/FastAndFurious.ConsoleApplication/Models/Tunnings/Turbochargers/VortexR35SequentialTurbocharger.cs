using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers
{
    public class VortexR35SequentialTurbocharger : Turbocharger
    {
        private const decimal price = 699;
        private const int weight = 3900;
        private const int acceleration = 10;
        private const int topSpeed = 85;
        private const TunningGradeType gradeType = TunningGradeType.HighGrade;
        private const TurbochargerType turboType = TurbochargerType.SequentialTurbo;

        public VortexR35SequentialTurbocharger()
            : base(price, weight, acceleration, topSpeed, gradeType, turboType)
        {
        }
    }
}
