namespace MobilePhone
{
    using System.Collections.Generic;
    using System.Linq;

    public class GSM
    {
        private const double secondsInMinute = 60;

        private string model;

        private string manufacturer;

        private decimal price;

        private string owner;

        private Display display;

        private Battery battery;

        public static IPhone4s iPhone4s = new IPhone4s();

        public ICollection<Call> callHistory;



        public GSM():this ("Lumia 950", "Nokia", 555.55m, new Battery(), new Display())
        {

        }

        public GSM(string model, string manufacturer, decimal price, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Battery = battery;
            this.Display = display;
            this.callHistory = new List<Call>();
        }



        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set { this.manufacturer = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public Battery Battery
        {
            get { return this.battery; }
            set { this.battery = value; }
        }


        public Display Display
        {
            get { return this.display; }
            set { this.display = value; }
        }
        
        public ICollection<Call> CallHistory
        {
            get { return this.callHistory; }
        }



        public void AddCall(Call call)
        {
            this.CallHistory.Add(call);
        }

        public void ClearHistory()
        {
            this.callHistory = new List<Call>();
        }

        public double CalculatePrice(double price)
        {
            return this.CallHistory.Sum(x => x.Length / secondsInMinute) * price;
        }

        public override string ToString()
        {
            return string.Format("Manufacturer - {0}, Model - {1} \r\nBattery - {2} \r\nDisplay size - {3}\r\n", this.Manufacturer, this.Model, this.Battery, this.Display.Size);
        }
    }
}
