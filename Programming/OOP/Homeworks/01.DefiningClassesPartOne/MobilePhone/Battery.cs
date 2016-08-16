namespace MobilePhone
{
    public class Battery
    {
        public BatteryType Type { get; set; }

        public string Model { get; set; }

        public double HoursIdle { get; set; }

        public double HoursTalk { get; set; }


        public Battery() : this(BatteryType.LiIon, "model", 400, 150)
        {
                
        }

        public Battery(BatteryType type, string model, double hoursIdle, double hoursTalk)
        {
            this.Type = type;
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }


        public override string ToString()
        {
            return string.Format("Model - {0}, Battery Type - {1}", this.Model, this.Type); 
        }
    }
}
