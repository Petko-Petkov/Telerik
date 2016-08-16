namespace StudentSystem.Models.Contracts
{
    public interface IStudent
    {
        int Id { get; }

        string Name { get; set; }
    }
}
