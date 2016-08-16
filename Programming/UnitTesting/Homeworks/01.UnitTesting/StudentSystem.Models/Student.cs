namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    using StudentSystem.Models.Contracts;
    using Utils;

    public class Student : IStudent
    {
        private int id;
        private string name;

        public Student(string name)
        {
            this.Id = DataGenerator.GenerateId();
            this.Name = name;
            this.Courses = new HashSet<ICourse>();
        }

        public int Id {
            get { return this.id; }
            private set
            {
                if (value < 10000 || value > 99999)
                {
                    throw new ArgumentOutOfRangeException("Id", $"ID should be in the range {Constants.ID_MIN_VALUE} - {Constants.ID_MAX_VALUE}.");
                }

                this.id = value;
            }
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"{this.Name} cannot be empty");
                }

                this.name = value;
            }
        }

        public ICollection<ICourse> Courses { get; set; }
    }
}
