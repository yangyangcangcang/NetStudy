using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WuQiang.WebSevice.Web.Remote.WCFDome
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IMyWCF”。
    [ServiceContract]//必须标记 
    public interface IMyWCF
    {
        [OperationContract]//必须标记 
        void DoWork();

        [OperationContract]
        string GetContent();
        [OperationContract]
        List<WebServiceUser> GetUserList();
    }
}
