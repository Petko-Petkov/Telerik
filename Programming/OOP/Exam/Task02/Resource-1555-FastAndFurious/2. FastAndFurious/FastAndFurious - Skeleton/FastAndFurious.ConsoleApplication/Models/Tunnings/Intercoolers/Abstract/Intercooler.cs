using System;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Common.Utils;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.Intercoolers.Abstract
{
    public abstract class Intercooler : IIntercooler, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
    {
        private readonly int id;

        public Intercooler(
            decimal price,
            int weight,
            int acceleration,
            int topSpeed,
            TunningGradeType gradeType,
            IntercoolerType intercoolerType)
        {
            this.id = DataGenerator.GenerateId();
            this.Price = price;
            this.Weight = weight;
            this.Acceleration = acceleration;
            this.TopSpeed = TopSpeed;
            this.GradeType = gradeType;
            this.IntercoolerType = intercoolerType;
        }

        public int Acceleration
        {
            get; private set;
        }

        public TunningGradeType GradeType
        {
            get; private set;
        }

        public int Id
        {
            get
            {
                return this.id;
            }
        }

        public IntercoolerType IntercoolerType
        {
            get; private set;
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
