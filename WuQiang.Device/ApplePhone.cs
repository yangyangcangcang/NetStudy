using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Unity;
using WuQiang.Interface;

namespace WuQiang.Device
{
    public class ApplePhone: IPhone
    {
       [Unity.Dependency]//属性注入     
        public IMicrophone iMicrophone { get; set; }
        public IHeadphone iHeadphone { get; set; }
        public IPower iPower { get; set; }

        
        public ApplePhone()
        {
            Console.WriteLine($"{this.GetType().Name} 构造函数");
        }

        [InjectionConstructor]//构造函数注入，默认找参数最多的构造函数
        public ApplePhone(IHeadphone headphone)
        {
            this.iHeadphone = headphone;
            Console.WriteLine($"{this.GetType().Name} 带参数的构造函数");
        }

        [InjectionMethod]//方法注入
        public void Init(IPower power)
        {
            this.iPower = power;
        }

        public void Call()
        {
            Console.WriteLine($"{this.GetType().Name}打电话");
        }
    }
}
