using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WuQiang.WCF.Interface;
using WuQiang.WCF.Model;

namespace WuQiang.WCF.MathService
{
    public class MathService : IMathService
    {
        public WCFUser GetUser(int x, int y)
        {
            return new WCFUser() {Id=1,Name="zhangsn",Age=12,Sex=1,Description="上海人" };
            //throw new NotImplementedException();
        }

        public int Minus(int x, int y)
        {
            return x - y;
            //throw new NotImplementedException();
        }

        public int PlusInt(int x, int y)
        {
            return x + y;
            //throw new NotImplementedException();
        }

        public List<WCF.Model.WCFUser> UserList()
        {
            return  new List<WCFUser>() {
                new WCFUser() { Id = 1, Name = "zhangsn", Age = 12, Sex = 1, Description = "上海人" },
                new WCFUser() { Id = 2, Name = "zhangsn2", Age = 13, Sex = 2, Description = "北京人" },
                new WCFUser() { Id = 3, Name = "zhangsn3", Age = 14, Sex = 1, Description = "重庆人" }
            };
            //throw new NotImplementedException();
        }
    }
}
