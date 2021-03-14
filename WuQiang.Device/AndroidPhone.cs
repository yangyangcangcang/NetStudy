using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WuQiang.Interface;

namespace WuQiang.Device
{
    public class AndroidPhone:IPhone
    {

        public IMicrophone iMicrophone { get; set; }
        public IHeadphone iHeadphone { get; set; }
        public IPower iPower { get; set; }

        public AndroidPhone()
        {
            Console.WriteLine($"{this.GetType().Name} 构造函数");
        }
        public void Call()
        {
            Console.WriteLine($"{this.GetType().Name}打电话");
        }
    }
}
