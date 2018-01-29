using HomeworkSix.Interface;
using HomeworkSix.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSix.AOP
{
    public class DecoratorAOP : IUserService
    {
        private IUserService _userService;

        public DecoratorAOP(IUserService userService)
        {
            _userService = userService;
        }

        private void BeforeRegister()
        {
            Console.WriteLine("Before Regiser");
        }

        public void Register(User user)
        {
            BeforeRegister();
            _userService.Register(user);
            AfterRegister();
        }

        private void AfterRegister()
        {
            Console.WriteLine("After Regiser");
        }

        public void Login(User user)
        {
            _userService.Login(user);
        }

        public void Logout(User user)
        {
            _userService.Logout(user);
        }
    }
}
