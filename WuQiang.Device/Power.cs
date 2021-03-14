using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WuQiang.Interface;

namespace WuQiang.Device
{
    public class Power: IPower
    {
        public Power()
        {
            Console.WriteLine("Power 被构造了");
        }
    }
}
