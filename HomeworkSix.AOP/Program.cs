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
                Name = "ELEVEN", Id = 1239, Password = "1234567890"
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

                Console.WriteLine("**********IOrderService**********");
                Order order = new Order() { Id = 1, OrderNo = "201801290001", Remark = "test" };
                IOrderService orderService = UnityAOP.UnityContainer.Resolve<IOrderService>();
                orderService.Create(order);
                orderService.Cancel(order);
                orderService.Pay(order);
                Console.WriteLine("**********IMenuService**********");
                IMenuService menuService = UnityAOP.UnityContainer.Resolve<IMenuService>();
                menuService.Add();
                menuService.Delete();
                menuService.Update();
                menuService.Select();
                //IUserService userService = container.Resolve<IUserService>("UserServiceEx");
                //userService.Register();


                #endregion
            }

            Console.Read();
        }
    }
}
