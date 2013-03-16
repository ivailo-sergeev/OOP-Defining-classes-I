using System;

namespace GSMClasses
{
    public class Battery
    {
        private string _model;
        private int _hoursIdle;
        private int _hoursTalk;
        private BatteryType _batteryType;


        public Battery(string model = null, int hoursIdle = 0, int hoursTalk = 0, BatteryType batteryType= 0)
        {
            this._model = model;
            this._hoursIdle = hoursIdle;
            this._hoursTalk = hoursTalk;
            this._batteryType = batteryType;
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public int HoursIdle
        {
            get { return _hoursIdle; }
            set { _hoursIdle = value; }
        }
        
        public int HoursTalk
        {
            get { return _hoursTalk; }
            set { _hoursTalk = value; }
        }


        public BatteryType BatteryType
        {
            get { return _batteryType; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", this.Model, this.HoursIdle, this.HoursTalk, this.BatteryType);
        }
    }
}
