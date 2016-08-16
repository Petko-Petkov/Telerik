namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class GSMTest
    {
        public static void Main()
        {
            var gsms = new List<GSM>
            {
                new GSM("Galaxy 6", "Samsung", 800.00m, new Battery(BatteryType.LiIon, "model", 500, 100), new Display(5.3)),
                new GSM("6", "IPhone", 1200.00m, new Battery(BatteryType.LiIon, "model", 800, 400), new Display()),
                new GSM("Model", "LG", 400.00m, new Battery(BatteryType.NiCd, "model", 300, 100), new Display(4.5)),
                new GSM("Lumia 930", "Nokia", 500.00m, new Battery(BatteryType.NiMH, "model 3", 400, 200), new Display()),
                new GSM("Neshto si", "Sony", 450.00m, new Battery(BatteryType.NiCd, "model", 343, 140), new Display(4.8)),
                new GSM("Galaxy 4", "Samsung", 550.00m, new Battery(BatteryType.LiIon, "model", 400, 150), new Display())
            };

            foreach (var gsm in gsms)
            {
                Console.WriteLine(gsm);
            }

            Console.WriteLine(GSM.iPhone4s);

            var testCallsGsm = new GSM();
            testCallsGsm.AddCall(new Call(DateTime.Now, DateTime.Now.AddSeconds(234), "+359888787878"));
            testCallsGsm.AddCall(new Call(DateTime.Now, DateTime.Now.AddSeconds(434), "+35988865161"));
            testCallsGsm.AddCall(new Call(DateTime.Now, DateTime.Now.AddSeconds(2234), "+359887846163"));
            testCallsGsm.AddCall(new Call(DateTime.Now, DateTime.Now.AddSeconds(624), "+359885525056"));
            testCallsGsm.AddCall(new Call(DateTime.Now, DateTime.Now.AddSeconds(12352), "+359884651625"));

            Console.WriteLine("Before removing the longest call from call history the price is - {0:F2}", testCallsGsm.CalculatePrice(0.37));

            var longestcall = testCallsGsm.CallHistory.OrderByDescending(x => x.Length).FirstOrDefault();
            testCallsGsm.CallHistory.Remove(longestcall);
            Console.WriteLine("After removing the longest call from call history the price is - {0:F2}", testCallsGsm.CalculatePrice(0.37));
            testCallsGsm.ClearHistory();
            Console.WriteLine("After removing all the calls from call history the price is - {0:F2}", testCallsGsm.CalculatePrice(0.37));
        }
    }
}
