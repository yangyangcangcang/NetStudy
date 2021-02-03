using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WuQiang.WebSevice.Web.Remote.WCFDome
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“MyWCF”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 MyWCF.svc 或 MyWCF.svc.cs，然后开始调试。
    public class MyWCF : IMyWCF
    {
        public void DoWork()
        {
            Console.WriteLine("DoWork");
        }

        public string GetContent()
        {
            //throw new NotImplementedException();
            return "你好 WCF";
        }

        public List<WebServiceUser> GetUserList()
        {
            return new List<WebServiceUser>()
            {
                new WebServiceUser() {Id=1,Name="张三",Age=10,Sex=0,Description="山西太原人" },
                new WebServiceUser() {Id=1,Name="lisi",Age=11,Sex=1,Description="四川成都人" }
            };
        }
    }
}
