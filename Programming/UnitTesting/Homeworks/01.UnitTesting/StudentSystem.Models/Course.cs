namespace StudentSystem.Models
{
    using System;
    using System.Collections.Generic;
    using StudentSystem.Models.Contracts;

    public class Course : ICourse
    {
        public Course(string name)
        {
            this.Name = name;
            this.Students = new HashSet<IStudent>();
        }

        public string Name { get; set; }

        public ICollection<IStudent> Students { get; set; }
        
        public void Subscribe(IStudent student)
        {
            if (this.Students.Contains(student))
            {
                return;
            }

            if (this.Students.Count < 30)
            {
                this.Students.Add(student);
            }
        }
        
        public void Unsubscribe(IStudent student)
        {
            if (this.Students.Contains(student))
            {
                this.Students.Remove(student);
            }
        }
    }
}
