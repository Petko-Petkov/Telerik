using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Turbochargers
{
    public class ZX8ParallelTwinTurbocharger : Turbocharger
    {
        private const decimal price = 799;
        private const int weight = 3500;
        private const int acceleration = 15;
        private const int topSpeed = 60;
        private const TunningGradeType gradeType = TunningGradeType.HighGrade;
        private const TurbochargerType turboType = TurbochargerType.TwinTurbo;

        public ZX8ParallelTwinTurbocharger(decimal price, int weight, int acceleration, int topSpeed, TunningGradeType gradeType, TurbochargerType type) : base(price, weight, acceleration, topSpeed, gradeType, type)
        {
        }
    }
}
