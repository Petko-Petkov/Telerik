namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Transmissions.Abstract
{
    using Common.Enums;
    using Contracts;
    using Tunnings.Abstract;

    public abstract class Transmission : TunningPart, ITransmission
    {
        public Transmission(decimal price, int weight, int acceleration, int topSpeed, TunningGradeType gradeType, TransmissionType transmissionType)
            : base(price, weight, acceleration, topSpeed, gradeType)
        {
            this.TransmissionType = transmissionType;
        }

        public TransmissionType TransmissionType
        {
            get; private set;
        }
    }
}
