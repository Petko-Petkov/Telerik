using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Transmissions.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Transmissions
{
    public class TWMPerformanceTransmission : Transmission
    {

        private const decimal price = 1599;
        private const int weight = 4799;
        private const int acceleration = 15;
        private const int topSpeed = 0;
        private const TunningGradeType gradeType = TunningGradeType.LowGrade;
        private const TransmissionType transmissionType = TransmissionType.ManualShortShifter;

        public TWMPerformanceTransmission() : base(price, weight, acceleration, topSpeed, gradeType, transmissionType)
        {
        }
    }
}
