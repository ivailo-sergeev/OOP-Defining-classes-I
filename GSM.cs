using System;
using System.Collections.Generic;

namespace GSMClasses
{
    public class GSM
    {
        private string _model;
        private string _manufacturer;
        private int _price;
        private string _owner;
        private Battery _battery;
        private Display _display;
        private static GSM _IPhone4S = new GSM("4S", "Apple", 1000, "Pesho",
            new Battery("T1", 32, 33, BatteryType.NiMH), new Display(45, 10000));


        public GSM(string model, string manufacturer, int price = 0,
            string owner = null, Battery battery = null, Display display = null)
        {
            this._model = model;
            this._manufacturer = manufacturer;
            this._price = price;
            this._owner = owner;
            this._battery = battery;
            this._display = display;
            this.CallHistory = new List<Call>();
        }

        public List<Call> CallHistory
        {
            get;
            set;
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        

        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }
        

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }
        

        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }
        

        public Battery Battery
        {
            get { return _battery; }
            set { _battery = value; }
        }
        

        public Display Display
        {
            get { return _display; }
            set { _display = value; }
        }

        public static GSM IPhone4S
        {
            get { return _IPhone4S; }
        }

        public void AddCall(Call call)
        {
            CallHistory.Add(call);
        }

        public void DeleteCall(int index)
        {
            if (index >= CallHistory.Count)
            {
                Console.WriteLine("Unreachable call");
            }
            else
            {
                CallHistory.RemoveAt(index);
            }
        }

        public void ClearHistoty()
        {
            CallHistory.Clear();
        }

        public decimal TotalPrice(decimal price)
        {
            TimeSpan durationSum = new TimeSpan();
            for (int i = 0; i < CallHistory.Count; i++)
            {
                durationSum = durationSum + CallHistory[i].Duration;
            }
            return (decimal)durationSum.TotalMinutes * price;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}", this.Model, this.Manufacturer, this.Price,
                this.Owner, this.Battery, this.Display);
        }

    }
}
