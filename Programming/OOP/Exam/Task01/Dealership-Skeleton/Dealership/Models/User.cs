namespace Dealership.Models
{
    using System;
    using System.Collections.Generic;
    using Common.Enums;
    using Dealership.Contracts;
    using Common;
    using System.Linq;
    using System.Text;
    public class User : IUser
    {
        protected const string ValidateNullMessage = "{0} cannot be null!";

        private string firstName;
        private string lastName;
        private string password;
        private string username;

        public User(string username, string firstName, string lastName, string password, string role)
        {
            this.Username = username;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Password = password;
            this.Role = (Role)Enum.Parse(typeof(Role), role);
            this.Vehicles = new List<IVehicle>();
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                Validator.ValidateNull(value, string.Format(ValidateNullMessage, "Firstname"));
                Validator.ValidateIntRange(
                    value.Length,
                    Constants.MinNameLength,
                    Constants.MaxNameLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Firstname", Constants.MinNameLength, Constants.MaxNameLength));

                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                Validator.ValidateNull(value, string.Format(ValidateNullMessage, "Lastname"));
                Validator.ValidateIntRange(
                    value.Length,
                    Constants.MinNameLength,
                    Constants.MaxNameLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Lastname", Constants.MinNameLength, Constants.MaxNameLength));

                this.lastName = value;
            }
        }

        public string Password
        {
            get { return this.password; }
            private set
            {
                Validator.ValidateNull(value, string.Format(MyConstants.ValidateNullMessage, "Password"));
                Validator.ValidateSymbols(value, Constants.PasswordPattern, string.Format(Constants.InvalidSymbols, "Password"));
                Validator.ValidateIntRange(
                    value.Length,
                    Constants.MinPasswordLength,
                    Constants.MaxPasswordLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Password", Constants.MinPasswordLength, Constants.MaxPasswordLength));

                this.password = value;
            }
        }

        public Role Role { get; set; }

        public string Username
        {
            get
            {
                return this.username;
            }
            private set
            {
                Validator.ValidateNull(value, string.Format(Constants.UserCannotBeNull, "Username"));
                Validator.ValidateSymbols(value, Constants.UsernamePattern, string.Format(Constants.InvalidSymbols, "Username"));
                Validator.ValidateIntRange(
                    value.Length,
                    Constants.MinNameLength,
                    Constants.MaxNameLength,
                    string.Format(Constants.StringMustBeBetweenMinAndMax, "Username", Constants.MinNameLength, Constants.MaxNameLength));

                this.username = value;
            }
        }

        public IList<IVehicle> Vehicles
        {
            get; private set;
        }

        public void AddComment(IComment commentToAdd, IVehicle vehicleToAddComment)
        {
            vehicleToAddComment.Comments.Add(commentToAdd);
        }

        public void AddVehicle(IVehicle vehicle)
        {
            if (this.Vehicles.Count >= 5 && this.Role != Role.VIP) 
            {
                throw new ArgumentException(MyConstants.NotVip);
            }
            if (this.Role == Role.Admin)
            {
                throw new ArgumentException(MyConstants.IsAdmin);
            }
            this.Vehicles.Add(vehicle);
        }

        public string PrintVehicles()
        {
            var result = new StringBuilder();
            var counter = 1;

            result.AppendLine(string.Format("--USER {0}--", this.Username));
            if (this.Vehicles.Any())
            {
                foreach (var vehicle in this.Vehicles)
                {
                    result.Append(counter + ". " + vehicle.ToString());
                    counter++;
                }
            }
            else
            {
                result.Append("--NO VEHICLES--");
            }

            return result.ToString().Trim();
        }

        public void RemoveComment(IComment commentToRemove, IVehicle vehicleToRemoveComment)
        {
            if (!vehicleToRemoveComment.Comments.Contains(commentToRemove))
            {
                throw new ArgumentException(MyConstants.CommentDoesNotExist);
            }
            if (commentToRemove.Author != this.Username)
            {
                throw new ArgumentException(MyConstants.NotAuthor);
            }
            vehicleToRemoveComment.Comments.Remove(commentToRemove);
        }

        public void RemoveVehicle(IVehicle vehicle)
        {
            this.Vehicles.Remove(vehicle);
        }

        public override string ToString()
        {
            var userFormat = string.Format(Constants.UserToString, this.Username, this.FirstName, this.LastName);
            userFormat += string.Format(", Role: {0}", this.Role);
            return userFormat;
        }
    }
}
