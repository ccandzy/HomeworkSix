using HomeworkSix.Factory;
using HomeworkSix.Interface;
using System;

namespace HomeworkSix.AOP
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                #region 装饰器模式实现静态AOP
                IUserService userService = SimpleFactory.CreateService<IUserService>("IUserService");
                userService = new DecoratorAOP(userService);
                userService.Register();
                #endregion
            }
            {
                #region 延迟代理模式实现静态AOP
                IUserService userService = new ProxyAOP();
                userService.Register();
                #endregion
            }


            Console.Read();
        }
    }
}
