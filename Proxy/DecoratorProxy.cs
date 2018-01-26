using HomeworkSix.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class DecoratorProxy : IUserService
    {
        private IUserService _userService;

        public DecoratorProxy(IUserService userService)
        {
            _userService = userService;
        }

        private void BeforeRegister()
        {
            Console.WriteLine("Before Regiser");
        }

        public void Register()
        {
            BeforeRegister();
            _userService.Register();
            AfterRegister();
        }

        private void AfterRegister()
        {
            Console.WriteLine("After Regiser");
        }
    }
}
