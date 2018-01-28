using HomeworkSix.Factory;
using HomeworkSix.Interface;
using HomeworkSix.Model;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Configuration;
using Unity;

namespace HomeworkSix.AOP
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User()
            {
                Name = "cc", Id = 1239, Password = "1234567890"
        };

            {
                #region 装饰器模式实现静态AOP
                //IUserService userService = SimpleFactory.CreateService<IUserService>("IUserService");
                //userService = new DecoratorAOP(userService);
                //userService.Register(user);
                #endregion
            }
            {
                #region 延迟代理模式实现静态AOP
                //IUserService userService = new ProxyAOP();
                //userService.Register(user);
                #endregion
            }
            {
                #region
               
                IUserService userService =UnityAOP.UnityContainer.Resolve<IUserService>();
                userService.Register(user);

                //IUserService userService = container.Resolve<IUserService>("UserServiceEx");
                //userService.Register();


                #endregion
            }

            Console.Read();
        }
    }
}
