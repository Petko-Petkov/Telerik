namespace FastAndFurious.ConsoleApplication.Models.Tunnings.EngineControlUnits.Abstract
{
    using System;
    using FastAndFurious.ConsoleApplication.Common.Enums;
    using FastAndFurious.ConsoleApplication.Contracts;
    using FastAndFurious.ConsoleApplication.Common.Utils;

    public abstract class EngineControlUnit : IEngineControlUnit, ITunningPart, IAccelerateable, ITopSpeed, IWeightable, IValuable
    {
        private EngineControlUnitType engineControlUnitType;
        private readonly int id;

        public EngineControlUnit(
            decimal price,
            int weight,
            int acceleration,
            int topSpeed,
            TunningGradeType gradeType,
            EngineControlUnitType engineControlUnitType)
        {
            this.id = DataGenerator.GenerateId();
            this.Price = price;
            this.Weight = weight;
            this.Acceleration = acceleration;
            this.TopSpeed = topSpeed;
        }

        public int Acceleration
        {
            get; private set;
        }

        public EngineControlUnitType EngineControlUnitType
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
