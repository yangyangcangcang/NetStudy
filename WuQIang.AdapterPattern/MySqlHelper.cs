using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WuQIang.AdapterPattern.Interface;

namespace WuQIang.AdapterPattern
{
    public class MySqlHelper : IHelper
    {
        public void Add<T>()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"This is {this.GetType().Name} Add");
        }

        public void Delete<T>()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"This is {this.GetType().Name} Delete");
        }

        public void Query<T>()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"This is {this.GetType().Name} Query");
        }

        public void Update<T>()
        {
            //throw new NotImplementedException();
            Console.WriteLine($"This is {this.GetType().Name} Update");
        }
    }
}
