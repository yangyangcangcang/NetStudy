using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using Unity;


namespace WuQiang.WepApi.WebApp.Unity
{
    /// <summary>
    /// UnityContainer 应该单例
    /// </summary>
    public class UnityContainerFactory
    {

        private static IUnityContainer _IUnityContainer = null;

        static UnityContainerFactory()
        {
            ExeConfigurationFileMap fileMap = new ExeConfigurationFileMap();
            //找配置文件的路径
            fileMap.ExeConfigFilename = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CfgFiles", "Unity.config");
            Configuration Configuration = ConfigurationManager.OpenMappedExeConfiguration(fileMap, ConfigurationUserLevel.None);
            UnityConfigurationSection section = (UnityConfigurationSection)Configuration.GetSection(UnityConfigurationSection.SectionName);

            _IUnityContainer = new UnityContainer();
            section.Configure(_IUnityContainer, "webApiContainer");
        }

        public static IUnityContainer CreateContainer()
        {
            return _IUnityContainer;
        }

    }
}