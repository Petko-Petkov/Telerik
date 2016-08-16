using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Models.Tunnings.Transmissions.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Transmissions
{
    public class HurstCompetitionManualShifter : Transmission
    {

        private const decimal price = 1999;
        private const int weight = 6000;
        private const int acceleration = 20;
        private const int topSpeed = 0;
        private const TunningGradeType gradeType = TunningGradeType.MidGrade;
        private const TransmissionType transmissionType = TransmissionType.SemiManualShifter;

        public HurstCompetitionManualShifter() : base(price, weight, acceleration, topSpeed, gradeType, transmissionType)
        {
        }
    }
}
