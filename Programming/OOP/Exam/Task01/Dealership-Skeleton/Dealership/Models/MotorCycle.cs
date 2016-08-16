namespace Dealership.Models
{
    using System;
    using Dealership.Contracts;
    using Common;
    using Common.Enums;
    public class Motorcycle : Vehicle, IMotorcycle
    {
        private const int WheelsCount = 2;
        private string category;

        public Motorcycle(string make, string model, decimal price, string category) 
            : base(make, model, WheelsCount, price)
        {
            this.Type = VehicleType.Motorcycle;
            this.Category = category;
        }

        public string Category
        {
            get { return this.category; }
            set
            {
                Validator.ValidateNull(value, string.Format(ValidateNullMessage, "Category"));
                Validator.ValidateIntRange(
                    value.Length,
                    Constants.MinCategoryLength,
                    Constants.MaxCategoryLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Category", Constants.MinCategoryLength, Constants.MaxCategoryLength));
                this.category = value;
            }
        }

        public override string ToString()
        {
            return string.Format(base.ToString(), "Category", this.Category);
        }
    }
}
