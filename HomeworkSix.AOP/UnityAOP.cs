using HomeworkSix.Interface;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;
using Unity;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;

namespace HomeworkSix.AOP
{
    public class UnityAOP
    {
        public static IUnityContainer UnityContainer = null;

        static UnityAOP()
        {
            var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            UnityContainer = new UnityContainer().LoadConfiguration(section);

            UnityContainer.AddNewExtension<Interception>().Configure<Interception>()
                    .SetInterceptorFor<IUserService>(new InterfaceInterceptor());
        }
    }
}
