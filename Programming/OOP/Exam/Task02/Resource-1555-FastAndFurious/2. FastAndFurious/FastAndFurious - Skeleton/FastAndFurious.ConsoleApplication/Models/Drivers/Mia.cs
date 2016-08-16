namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    using Common.Constants;
    using Common.Enums;
    using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

    public class Mia : Driver
    {
        public Mia() : base(GlobalConstants.MiaName, GenderType.Female)
        {
        }
    }
}
