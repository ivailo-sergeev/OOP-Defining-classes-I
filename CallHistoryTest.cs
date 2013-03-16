using GSMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallHistoryTest
{
    class Test
    {
        static void Main(string[] args)
        {
            GSM phone = new GSM("S3", "Samsung", 1000, "Pesho", new Battery("T1", 33, 34, BatteryType.NiCd), new Display());
            phone.AddCall(new Call(DateTime.Now, "0521512512", new TimeSpan(1, 30, 20)));
            phone.AddCall(new Call(DateTime.Now, "0521512512", new TimeSpan(3, 30, 20)));
            phone.AddCall(new Call(DateTime.Now, "0521512512", new TimeSpan(3, 30, 30)));

            TimeSpan longestDuration = phone.CallHistory[0].Duration;
            int index = 0;

            for (int i = 1; i < phone.CallHistory.Count; i++)
            {
                if (longestDuration < phone.CallHistory[i].Duration)
                {
                    longestDuration = phone.CallHistory[i].Duration;
                    index = i;
                }
            }

            phone.DeleteCall(index);
            PrintCallHistory(phone);
        }
        private static void PrintCallHistory(GSM phone)
        {
            foreach (var item in phone.CallHistory)
            {
                Console.WriteLine(item);
            }
        }
        }
    }
}
