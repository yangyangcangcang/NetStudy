using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace WuQiang.AOP.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User() { Name="张三",Age=19};
            IUnityContainer unityContainer = UnityContainerFactory.CreateContainer();
            IUserProcessor iUserProcessor = unityContainer.Resolve<IUserProcessor>();
            iUserProcessor.RegUser(user);
            iUserProcessor.GetUser(user);


            System.Console.ReadKey();
        }
    }
}
