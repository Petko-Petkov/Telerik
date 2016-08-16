namespace StudentSystem.Models.Contracts
{
    using System.Collections.Generic;

    public interface ISchool
    {
        ICollection<IStudent> Students { get; set; }

        ICollection<ICourse> Courses { get; set; }
    }
}
