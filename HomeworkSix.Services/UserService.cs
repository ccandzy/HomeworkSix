using HomeworkSix.Interface;
using HomeworkSix.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSix.Services
{
    public class UserService : IUserService
    {
        public void Register(User user)
        {
            Console.WriteLine($"{user.Name} Register Successful");
        }
    }
}
