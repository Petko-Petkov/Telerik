namespace MobilePhone
{
    using System;

    public class Call
    {
        private DateTime startCall;

        private DateTime endCall;

        private double length;


        public Call(DateTime start, DateTime end, string dialedNum)
        {
            this.StartCall = start;
            this.EndCall = end;
            this.DialedPhone = dialedNum;
            this.Length = (end - start).TotalSeconds;
        }


        public DateTime StartCall
        {
            get { return this.startCall; }
            set { this.startCall = value; }
        }

        public DateTime EndCall
        {
            get { return this.endCall; }
            set { this.endCall = value; }
        }

        public double Length
        {
            get { return this.length; }
            set { this.length = value; }
        }

        public string DialedPhone { get; set; }
    }
}
