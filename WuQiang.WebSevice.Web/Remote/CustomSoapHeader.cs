using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WuQiang.WebSevice.Web.Remote
{
    /// <summary>
    /// 必须继承自 System.Web.Services.Protocols.SoapHeader
    /// </summary>
    public class CustomSoapHeader:System.Web.Services.Protocols.SoapHeader
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }

        /// <summary>
        /// 必须存在无参数的构造函数
        /// </summary>
        public CustomSoapHeader()
        {

        }

        
        public CustomSoapHeader(string username,string password)
        {
            this.UserName = username;
            this.PassWord = password;
        }


        public bool Validate()
        {
            if (UserName.Contains("s")&& PassWord.Contains("1"))
            {
                return true;
            }
            return false;
        }

    }
}