using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WuQiang.Interface;

namespace WuQiang.Device
{
    public class Microphone:IMicrophone
    {
        public Microphone()
        {
            Console.WriteLine("Microphone 被构造了");
        }
    }
}
