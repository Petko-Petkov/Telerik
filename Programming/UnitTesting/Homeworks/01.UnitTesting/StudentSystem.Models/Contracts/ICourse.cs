namespace StudentSystem.Models.Contracts
{
    using System.Collections.Generic;

    public interface ICourse
    {
        ICollection<IStudent> Students { get; set; }

        void Subscribe(IStudent student);

        void Unsubscribe(IStudent student);
    }
}