namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    using Common.Constants;
    using FastAndFurious.ConsoleApplication.Common.Enums;
    using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

    public class LetiSpaghetti : Driver
    {


        public LetiSpaghetti() 
            : base(GlobalConstants.LetiSpaghettiName, GenderType.Female)
        {
        }
    }
}
