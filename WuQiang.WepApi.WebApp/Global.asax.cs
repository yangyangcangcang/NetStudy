using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace WuQiang.WepApi.WebApp
{
    /// <summary>
    /// 路由规则： 
    /// 1、Application_Start -WebApiConfig.Register 把路由规则写入到了一个容器
    /// 2、运行 请求会去容器匹配-找到控制器-然后找action
    ///      2.1 以特性为准  如[httpGet]
    ///      2.2 以Get开头
    ///      2.3 优先匹配 api/values/1 ---> Get(int id)
    ///      
    /// 加入一个资源，同一种操作  可能有多个来源途径
    /// 
    /// 特性路由：
    /// 1、config.MapHttpAttributeRoutes();
    /// 2、控制器/action 都可以写成特性
    /// </summary>
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();//注册区域
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
