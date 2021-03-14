using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WuQiang.Interface;

namespace WuQiang.Device
{
    public class Headphone:IHeadphone
    {
        public Headphone()
        {
            Console.WriteLine("Headphone 被构造");
        }
    }
}
