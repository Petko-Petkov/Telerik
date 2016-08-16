namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    using Common.Constants;
    using Common.Enums;
    using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

    public class Jessi : Driver
    {
        public Jessi() : base(GlobalConstants.JessiName, GenderType.Male)
        {
        }
    }
}
