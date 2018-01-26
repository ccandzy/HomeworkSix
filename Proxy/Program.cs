using HomeworkSix.Factory;
using HomeworkSix.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IUserService userService = SimpleFactory.CreateService();
            userService = new DecoratorProxy(userService);
            userService.Register();

            Console.Read();
        }
    }
}
