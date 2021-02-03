using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WuQiang.WCF.MathService;

namespace WuQiang.WCF.Console
{
    public class ServiceInit
    {
        public static void Process()
        {
            List<ServiceHost> hostList = new List<ServiceHost>() {
                new ServiceHost(typeof(WuQiang.WCF.MathService.MathService)),
                new ServiceHost(typeof(WuQiang.WCF.MathService.CalculatorSevice))
            };

            foreach (var host in hostList)
            {
                host.Opening += (s,e)=> {
                    System.Console.WriteLine($"{host.GetType().FullName} 服务打开");
                };
                host.Opened += (s, e) => {
                    System.Console.WriteLine($"{host.GetType().FullName} 服务已经打开");
                };
                host.Open();
            }

            System.Console.ReadLine();

            foreach (var host in hostList)
            {
                host.Close();
            }
        }
    }
}
