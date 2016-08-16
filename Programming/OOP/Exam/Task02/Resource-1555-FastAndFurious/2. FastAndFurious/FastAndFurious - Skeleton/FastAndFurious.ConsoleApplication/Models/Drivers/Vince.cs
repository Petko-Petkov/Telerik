namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    using Common.Constants;
    using Common.Enums;
    using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

    public class Vince : Driver
    {
        public Vince() : base(GlobalConstants.VinceName, GenderType.Male)
        {
        }
    }
}
