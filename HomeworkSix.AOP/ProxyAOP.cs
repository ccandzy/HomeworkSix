using HomeworkSix.Factory;
using HomeworkSix.Interface;
using HomeworkSix.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSix.AOP
{
    public class ProxyAOP : IUserService
    {
        private IUserService _userService;

        private void Init()
        {
            _userService = SimpleFactory.CreateService<IUserService>("IUserService");
        }

        private void BeforeRegister()
        {
            Console.WriteLine("Porxy Before Register");
        }

        private void AfterRegister()
        {
            Console.WriteLine("Porxy After Register");
        }

        public void Register(User user)
        {
            if(_userService == null)
            {
                Init();
            }
            BeforeRegister();
            _userService.Register(user);
            AfterRegister();
        }
    }
}
