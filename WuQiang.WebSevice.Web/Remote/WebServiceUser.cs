using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WuQiang.WebSevice.Web.Remote
{
    [DataContract]//WCF 中标准规范实体 需要添加    有无参构造函数是可以省略的   一般来说遵守约定
    public class WebServiceUser
    {
        [DataMember] //有了 DataContract ，必须DataMember
        public int Id { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public int Sex { get; set; }
        [DataMember(Name ="ShortName")] //给该字段 起别名 在调用时改变
        public string Name { get; set; }
        public string Description { get; set; }
    }
}