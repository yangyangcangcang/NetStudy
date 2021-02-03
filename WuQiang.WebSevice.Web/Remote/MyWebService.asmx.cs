using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using WuQiang.WebSevice.Web.Remote;

namespace WuQiang.WebSevice.Web.Remote
{
    /// <summary>
    /// MyWebService 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    // [System.Web.Script.Services.ScriptService]
    public class MyWebService : System.Web.Services.WebService
    {
        public CustomSoapHeader customSoapHeader;


        [WebMethod] //必须标记
        [System.Web.Services.Protocols.SoapHeader("customSoapHeader")]
        public string HelloWorld()
        {
            if (customSoapHeader != null && customSoapHeader.Validate())
            {
                return "Hello World";
            }
            else
            {
                throw new SoapException("身份验证失败",SoapHeaderException.ServerFaultCode);
            }
        }
        [WebMethod]
        public int Plus(int x, int y)
        {
            return x + y;
        }
        [WebMethod]
        public int Minus(int x, int y)
        {
            return x - y;
        }
        [WebMethod]
        public List<WebServiceUser> GetWebServiceUserList()
        {
            return new List<WebServiceUser>()
            {
                new WebServiceUser() {Id=1,Name="张三",Age=10,Sex=0,Description="山西太原人" },
                new WebServiceUser() {Id=1,Name="lisi",Age=11,Sex=1,Description="四川成都人" }
            };
        }

    }
}
