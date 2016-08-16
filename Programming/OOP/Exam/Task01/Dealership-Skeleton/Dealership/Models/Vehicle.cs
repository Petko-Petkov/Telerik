namespace Dealership.Models
{
    using System;
    using System.Collections.Generic;
    using Common.Enums;
    using Dealership.Contracts;
    using Common;
    using System.Text;
    public abstract class Vehicle : IVehicle
    {
        // TODO extract to only one constant
        protected const string MakeCannotBeNull = "Make cannot be null!";
        protected const string ModelCannotBeNull = "Model cannot be null!";
        protected const string PriceCannotBeNull = "Price cannot be null!";
        protected const string WheelsCannotBeNull = "Wheels cannot be null!";
        protected const string ValidateNullMessage = "{0} cannot be null!";

        private string make;
        private string model;
        private int wheelsCount;
        private decimal price;
        private VehicleType type;

        public Vehicle(string make, string model, int wheels, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Wheels = wheels;
            this.Price = price;
            this.Comments = new List<IComment>();
        }

        public IList<IComment> Comments { get; private set; }
        public string Make
        {
            get
            {
                return this.make;
            }
            private set
            {
                Validator.ValidateNull(value, MakeCannotBeNull);
                Validator.ValidateIntRange(value.Length, 
                    Constants.MinMakeLength, 
                    Constants.MaxMakeLength, 
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Make", Constants.MinMakeLength, Constants.MaxMakeLength));
                this.make = value;
            }
        }

        public string Model
        {
            get { return this.model; }
            private set {
                Validator.ValidateNull(value, ModelCannotBeNull);
                Validator.ValidateIntRange(value.Length,
                    Constants.MinModelLength,
                    Constants.MaxModelLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Model", Constants.MinModelLength, Constants.MaxModelLength));
                this.model = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                Validator.ValidateNull(value, PriceCannotBeNull);
                Validator.ValidateDecimalRange(value, Constants.MinPrice, Constants.MaxPrice,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax, "Price", Constants.MinPrice, Constants.MaxPrice));
                this.price = value;
            }
        }

        public VehicleType Type
        {
            get
            {
                return this.type;
            }
            protected set { }
        }

        public int Wheels
        {
            get { return this.wheelsCount; }
            protected set
            {
                Validator.ValidateNull(value, WheelsCannotBeNull);
                Validator.ValidateIntRange(value, Constants.MinWheels, Constants.MaxWheels,
                    string.Format(Constants.NumberMustBeBetweenMinAndMax, "Wheels", Constants.MinWheels, Constants.MaxWheels));
                this.wheelsCount = value;
            }
        }

        public override string ToString()
        {
            var indent = 2;
            var indentStr = new string(' ', indent);
            var formatted = new StringBuilder();
            formatted.AppendLine(this.GetType().Name + ":");
            formatted.AppendLine(indentStr + string.Format("Make: {0}", this.Make));
            formatted.AppendLine(indentStr + string.Format("Model: {0}", this.Model));
            formatted.AppendLine(indentStr + string.Format("Wheels: {0}", this.Wheels));
            formatted.AppendLine(indentStr + string.Format("Price: ${0}", this.Price));
            formatted.AppendLine(indentStr + "{0}: {1}");
            indentStr = new string(' ', 4);
            if (this.Comments.Count == 0)
            {
                formatted.AppendLine(indentStr + "--NO COMMENTS--");
            }
            else
            {
                var dashes = new string('-', 10);
                formatted.AppendLine(indentStr + "--COMMENTS--");
                foreach (var comment in this.Comments)
                {
                    formatted.AppendLine(indentStr + dashes);
                    formatted.AppendLine(indentStr + comment.ToString());
                    formatted.AppendLine(indentStr + dashes);
                }
                formatted.AppendLine(indentStr + "--COMMENTS--");
            }
            return formatted.ToString();
        }
    }
}
