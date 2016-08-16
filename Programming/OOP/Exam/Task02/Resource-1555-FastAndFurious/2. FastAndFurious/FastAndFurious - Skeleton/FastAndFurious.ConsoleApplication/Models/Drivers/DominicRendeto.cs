namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    using Common.Constants;
    using Common.Enums;
    using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

    public class DominicRendeto : Driver
    {
        public DominicRendeto() : base(GlobalConstants.DominicRendetoName, GenderType.Male)
        {
        }
    }
}
