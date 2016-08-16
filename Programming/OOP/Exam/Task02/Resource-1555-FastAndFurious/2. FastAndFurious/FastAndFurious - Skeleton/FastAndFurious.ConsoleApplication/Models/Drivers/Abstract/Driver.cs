using System;
using System.Collections.Generic;
using System.Linq;
using FastAndFurious.ConsoleApplication.Common.Constants;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Common.Utils;
using FastAndFurious.ConsoleApplication.Contracts;

namespace FastAndFurious.ConsoleApplication.Models.Drivers.Abstract
{
    public abstract class Driver : IDriver
    {
        private readonly int id;
        private IMotorVehicle activeVehicle;
        private ICollection<IMotorVehicle> vehicles;

        public Driver(string name, GenderType gender)
        {
            this.id = DataGenerator.GenerateId();
            this.Name = name;
            this.Gender = gender;
            this.vehicles = new List<IMotorVehicle>();
        }

        public IMotorVehicle ActiveVehicle
        {
            get
            {
                return this.activeVehicle;
            }
            private set
            {
                this.activeVehicle = value;
            }
        }

        public GenderType Gender
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

        public string Name
        {
            get; private set;
        }

        public IEnumerable<IMotorVehicle> Vehicles
        {
            get
            {
                return this.vehicles;
            }
        }

        public void AddVehicle(IMotorVehicle vehicle)
        {
            if (!this.vehicles.Contains(vehicle))
            {
                this.vehicles.Add(vehicle);
            }
        }
        public bool RemoveVehicle(IMotorVehicle vehicle)
        {
            if (this.vehicles.Contains(vehicle))
            {
                this.vehicles.Remove(vehicle);
                return true;
            }

            return false;
        }
        public void SetActiveVehicle(IMotorVehicle vehicle)
        {
            if (this.ActiveVehicle != vehicle)
            {
                this.ActiveVehicle = vehicle;
            }
        }
    }
}
