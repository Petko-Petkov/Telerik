namespace Dealership.Models
{
    using System;
    using Contracts;
    using Dealership.Common.Enums;
    using Common;
    public class Car : Vehicle, ICar
    {
        private const int WheelsCount = 4;

        private int seats;

        public Car(string make, string model, decimal price, int seats) 
            : base(make, model, WheelsCount, price)
        {
            this.Type = VehicleType.Car;
            this.Seats = seats;
        }

        public int Seats
        {
            get { return this.seats; }
            private set
            {
                Validator.ValidateNull(value, string.Format(ValidateNullMessage, "Seats"));
                Validator.ValidateIntRange(value, Constants.MinSeats, Constants.MaxSeats,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax, "Seats", Constants.MinSeats, Constants.MaxSeats));
                this.seats = value;
            }
        }

        public override string ToString()
        {
            return string.Format(base.ToString(), "Seats", this.Seats);
        }
    }
}
