using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WuQIang.AdapterPattern
{
    public class RedisHelper
    {

        public void AddRedis<T>()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"This is {this.GetType().Name} Add");
        }

        public void DeleteRedis<T>()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"This is {this.GetType().Name} Delete");
        }

        public void QueryRedis<T>()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"This is {this.GetType().Name} Query");
        }

        public void UpdateRedis<T>()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"This is {this.GetType().Name} Update");
        }

    }
}
