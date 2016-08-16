namespace Dealership.Models
{
    using System;
    using Contracts;
    using Common;
    using Common.Enums;
    public class Truck : Vehicle, ITruck
    {
        private const int WheelsCount = 8;
        private const string Capacity = "Weight Capacity";

        private int capacity;
        public Truck(string make, string model, decimal price, int capacity) : base(make, model, WheelsCount, price)
        {
            this.WeightCapacity = capacity;
            this.Type = VehicleType.Truck;
        }

        public int WeightCapacity
        {
            get
            {
                return this.capacity;
            }
            private set
            {
                Validator.ValidateNull(value, string.Format(ValidateNullMessage, "Weight capacity"));
                Validator.ValidateIntRange(
                    value,
                    Constants.MinCapacity,
                    Constants.MaxCapacity,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax, "Weight capacity", Constants.MinCapacity, Constants.MaxCapacity ));

                this.capacity = value;
            }
        }

        public override string ToString()
        {
            return string.Format(base.ToString(), Capacity, this.WeightCapacity.ToString()+"t");
        }
    }
}
