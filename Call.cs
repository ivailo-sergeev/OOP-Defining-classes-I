using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMClasses
{
    public class Call
    {
        private DateTime _dateTime;
        private string _dialed;
        private TimeSpan _duration;

        public Call(DateTime dateTime, string dialed, TimeSpan duration)
        {
            this._dateTime = dateTime;
            this._dialed = dialed;
            this._duration = duration;
        }

        public DateTime DateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }
        
        public string Dialed
        {
            get { return _dialed; }
            set { _dialed = value; }
        }
        
        public TimeSpan Duration
        {
            get { return _duration; }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this._dateTime, this._dialed, this._duration);
        }
    }
}
