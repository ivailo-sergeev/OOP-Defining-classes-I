using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSMClasses;

namespace GSMTest
{
    class Test
    {
        static void Main(string[] args)
        {
            GSM[] phones = {
                new GSM("S3", "Samsung", 1000, "Pesho", new Battery("T1", 33, 34, BatteryType.NiCd), new Display()),
                new GSM("S3", "Samsung", 1000, "Pesho", new Battery("T1", 33, 34, BatteryType.NiCd), new Display()),
                new GSM("S3", "Samsung", 1000, "Pesho", new Battery("T1", 33, 34, BatteryType.NiCd), new Display()),
                new GSM("S3", "Samsung", 1000, "Pesho", new Battery("T1", 33, 34, BatteryType.NiCd), new Display())
            };

            foreach (var item in phones)
            {
                Console.WriteLine(item);
            }
            
    }
}
