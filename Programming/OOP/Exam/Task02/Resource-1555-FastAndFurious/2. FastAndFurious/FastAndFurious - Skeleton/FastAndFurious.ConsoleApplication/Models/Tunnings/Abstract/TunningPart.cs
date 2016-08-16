namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Abstract
{
    using Common.Enums;
    using Contracts;
    using Common.Utils;
    public abstract class TunningPart : ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
    {
        private readonly int id;

        public TunningPart(decimal price, int weight, int acceleration, int topSpeed, TunningGradeType gradeType)
        {
            this.id = DataGenerator.GenerateId();
            this.Price = price;
            this.Weight = weight;
            this.Acceleration = acceleration;
            this.TopSpeed = TopSpeed;
            this.GradeType = gradeType;
        }
        public int Acceleration
        {
            get; protected set;
        }

        public TunningGradeType GradeType
        {
            get; protected set;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public decimal Price
        {
            get; private set;
        }

        public int TopSpeed
        {
            get; private set;
        }

        public int Weight
        {
            get; private set;
        }
    }
}
