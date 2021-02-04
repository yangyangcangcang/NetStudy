using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WuQiang.AOP.Console
{
    public class UserProcessor : IUserProcessor
    {
        public User GetUser(User user)
        {
            return user;
        }

        public void RegUser(User user)
        {
            System.Console.WriteLine("用户已注册");
        }
    }
}
