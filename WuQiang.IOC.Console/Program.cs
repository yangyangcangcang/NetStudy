using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Lifetime;
using WuQiang.Device;
using WuQiang.Interface;

namespace WuQiang.IOC.Console
{
    /// <summary>
    /// DI依赖注入：
    ///  是用来实现IOC的一种手段
    ///  在构造对象时，可以实现自动的取初始化，对象需要的对象
    ///  有构造函数注入 、属性注入、方法注入
    ///   不管是构造对象、还是注入对象、这里都是靠反射来实现的
    ///   
    /// 有了依赖注入  才能做到无限层级的依赖抽象，做到控制反转
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Test04();
            System.Console.ReadKey();
        }

        /// <summary>
        /// 配置文件
        /// </summary>
        private static void  Test04()
        {
            IUnityContainer myContainer =  UnityContainerFactory.CreateContainer();
            IPhone phone = myContainer.Resolve<IPhone>();
            phone.Call();
        }

        /// <summary>
        /// 生命周期管理 容器成了对象创建的入口 ，可以加入自己的管理逻辑（生命周期）
        /// </summary>
        private static void Test03()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IPhone, AndroidPhone>();//默认  瞬时
            container.RegisterType<IPhone, AndroidPhone>(new TransientLifetimeManager());//  瞬时  每一次都是一个全新生成
            container.RegisterType<IPhone, AndroidPhone>(new ContainerControlledLifetimeManager());// 容器单例 ，单例就不要自己实现
            container.RegisterType<IPhone, AndroidPhone>(new PerThreadLifetimeManager());//线程单例 在同一个线程中是单例的  
            //同一个子容器 形同单例
            container.RegisterType<IPhone, AndroidPhone>(new HierarchicalLifetimeManager());//分级容器单例
            IUnityContainer childContainer = container.CreateChildContainer();//获取子容器
            container.RegisterType<IPhone, AndroidPhone>(new ExternallyControlledLifetimeManager());//外部可释放单例   
            container.RegisterType<IPhone, AndroidPhone>(new PerResolveLifetimeManager());//循环引用    不推荐
        }

        private static void Test02()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IPhone, ApplePhone>();   
            container.RegisterType<IPower, Power>();
            container.RegisterType<IMicrophone, Microphone>();
            container.RegisterType<IHeadphone, Headphone>();
            IPhone phone = container.Resolve<IPhone>();
            phone.Call();
        }

        private void Test01()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IPhone, AndroidPhone>();//接口
            container.RegisterType<AbstractPad, ApplePad>();//抽象类
            //container.RegisterType<ApplePad, ApplePadChild>();//子父类  会覆盖<AbstractPad, ApplePad> 
            container.RegisterType<AbstractPad, ApplePad>("child");//1对多
            container.RegisterType<AbstractPad, ApplePadChild>("grandchild");//1对多
            container.RegisterInstance<ITV>(new AppleTV());//注册实例  但不常用
            IPhone phone = container.Resolve<IPhone>();
            AbstractPad abstractPad = container.Resolve<AbstractPad>();
            AbstractPad childApplePad = container.Resolve<AbstractPad>("child");
            AbstractPad grandchild = container.Resolve<AbstractPad>("grandchild");
        }
    }
}
