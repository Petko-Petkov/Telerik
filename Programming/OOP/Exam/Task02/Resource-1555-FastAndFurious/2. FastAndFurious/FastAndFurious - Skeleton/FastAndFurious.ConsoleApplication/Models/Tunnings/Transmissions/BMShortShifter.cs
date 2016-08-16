using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Transmissions.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Transmissions
{
    public class BMShortShifter : Transmission
    {
        private const decimal price = 2799;
        private const int weight = 5700;
        private const int acceleration = 28;
        private const int topSpeed = 0;
        private const TunningGradeType gradeType = TunningGradeType.HighGrade;
        private const TransmissionType transmissionType = TransmissionType.ManualShortShifter;

        public BMShortShifter() : base(price, weight, acceleration, topSpeed, gradeType, transmissionType)
        {
        }
    }
}
