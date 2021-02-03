using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using WuQiang.WepApi.WebApp.Unity;

namespace WuQiang.WepApi.WebApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API 配置和服务
            config.DependencyResolver = new UnityDependencyResolver(UnityContainerFactory.CreateContainer());


            // 将 Web API 配置为仅使用不记名令牌身份验证。
            config.SuppressDefaultHostAuthentication();//特性路由
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API 路由
            config.MapHttpAttributeRoutes();

            //一般不指定action 因为restful 是以资源为目标的，没有操作的概念   操作是由httpMthod来实现
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
               name: "UserApi",
               routeTemplate: "userapi/{controller}/{action}/{id}",
               defaults: new { id = RouteParameter.Optional }
           );

        }
    }
}
