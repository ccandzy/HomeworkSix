using HomeworkSix.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSix.Services
{
    public class UserService : IUserService
    {
        public void Register()
        {
            Console.WriteLine("Register Successful");
        }
    }
}
