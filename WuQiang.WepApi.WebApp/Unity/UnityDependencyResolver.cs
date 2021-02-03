using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;
using Unity;

namespace WuQiang.WepApi.WebApp.Unity
{
    public class UnityDependencyResolver : IDependencyResolver
    {
        private IUnityContainer _IUnityContainer = null;
        public UnityDependencyResolver(IUnityContainer unityContainer)
        {
            this._IUnityContainer = unityContainer;
        }
        /// <summary>
        /// 表示每次请求
        /// </summary>
        /// <returns></returns>
        public IDependencyScope BeginScope()
        {
            var child = this._IUnityContainer.CreateChildContainer();
            return new UnityDependencyResolver(child);
        }

        public void Dispose()
        {
            if (this._IUnityContainer!=null)
            {
                this._IUnityContainer.Dispose();
            }
        }
        /// <summary>
        /// 获取单个服务
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public object GetService(Type serviceType)
        {
            try
            {
                return this._IUnityContainer.Resolve(serviceType);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _IUnityContainer.ResolveAll(serviceType);
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}