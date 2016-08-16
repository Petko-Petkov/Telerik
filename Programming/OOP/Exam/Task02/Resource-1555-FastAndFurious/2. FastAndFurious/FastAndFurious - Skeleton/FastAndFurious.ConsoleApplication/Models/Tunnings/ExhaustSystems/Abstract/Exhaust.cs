using System;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Common.Utils;

namespace FastAndFurious.ConsoleApplication.Models.Tunnings.ExhaustSystems.Abstract
{
    public abstract class Exhaust : IExhaust, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable 
    {
        private readonly ExhaustType exhaustType;
        private readonly int id;

        public Exhaust(
           decimal price,
           int weight,
           int acceleration,
           int topSpeed,
           TunningGradeType gradeType,
           ExhaustType exhaustType)
        {
            this.id = DataGenerator.GenerateId();
            this.Price = price;
            this.Weight = weight;
            this.Acceleration = acceleration;
            this.TopSpeed = topSpeed;
            this.ExhaustType = exhaustType;
        }

        public int Acceleration
        {
            get; private set;
        }

        public ExhaustType ExhaustType
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
