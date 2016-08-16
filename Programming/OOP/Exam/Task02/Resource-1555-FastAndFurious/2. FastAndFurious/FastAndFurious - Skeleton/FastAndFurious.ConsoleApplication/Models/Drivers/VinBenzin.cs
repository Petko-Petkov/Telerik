namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    using Common.Constants;
    using Common.Enums;
    using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

    public class VinBenzin : Driver
    {
        public VinBenzin() 
            : base(GlobalConstants.VinBenzinName, GenderType.Male)
        {
        }
    }
}
