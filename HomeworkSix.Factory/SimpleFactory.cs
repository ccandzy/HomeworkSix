
using System.Configuration;
using System.Reflection;

namespace HomeworkSix.Factory
{
    public class SimpleFactory
    {
        public static T CreateService<T>(string interfaceName)
        {
            string factoryName = ConfigurationManager.AppSettings[interfaceName];
            if (factoryName == null) return default(T);
            string sNameSpace = factoryName.Split(',')[0];
            string sClass = factoryName.Split(',')[1];
            var instanceModel = Assembly.Load(sNameSpace);
            var userService = (T)instanceModel.CreateInstance(sClass);
            return userService;
        }
    }
}
