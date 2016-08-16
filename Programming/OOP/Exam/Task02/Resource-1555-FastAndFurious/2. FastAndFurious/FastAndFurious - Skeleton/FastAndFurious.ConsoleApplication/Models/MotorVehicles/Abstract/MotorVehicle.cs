using System;
using System.Collections.Generic;
using System.Linq;
using FastAndFurious.ConsoleApplication.Common.Constants;
using FastAndFurious.ConsoleApplication.Common.Exceptions;
using FastAndFurious.ConsoleApplication.Common.Utils;
using FastAndFurious.ConsoleApplication.Contracts;

namespace FastAndFurious.ConsoleApplication.Models.MotorVehicles.Abstract
{
    public abstract class MotorVehicle : IMotorVehicle, IWeightable, IValuable
    {
        private readonly int id;
        private decimal price;
        private ICollection<ITunningPart> tunningParts;

        public MotorVehicle(decimal price, int weight, int topSpeed, int acceleration)
        {
            this.Price = price;
            this.Weight = weight;
            this.TopSpeed = topSpeed;
            this.Acceleration = acceleration;
            this.tunningParts = new List<ITunningPart>();
            this.id = DataGenerator.GenerateId();
        }

        public decimal Price
        {
            get
            {
                return this.price + this.TunningParts.Sum(x => x.Price);
            }
            private set { this.price = value; }
        }
        public int Weight
        {
            get; protected set;
        }
        public int Acceleration { get; protected set; }

        public int TopSpeed { get; protected set; }

        public IEnumerable<ITunningPart> TunningParts
        {
            get
            {
                return this.tunningParts;
            }
        }

        public int Id { get { return this.id; } }

        public void AddTunning(ITunningPart part)
        {
            if (!this.tunningParts.Contains(part))
            {
                this.tunningParts.Add(part);
            };
        }
        public TimeSpan Race(int trackLengthInMeters)
        {
            // Oohh boy, you shouldn't have missed the PHYSICS class in high school.
            throw new NotImplementedException();
        }
        public bool RemoveTunning(ITunningPart part)
        {
            if (this.tunningParts.Contains(part))
            {
                return this.tunningParts.Remove(part);
            }

            else return false;
        }
    }
}
