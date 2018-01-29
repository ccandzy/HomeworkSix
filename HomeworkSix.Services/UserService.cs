using HomeworkSix.Interface;
using HomeworkSix.Model;
using System;

namespace HomeworkSix.Services
{
    public class UserService : IUserService
    {
        public void Login(User user)
        {
            Console.WriteLine($"{user.Name} Login Successful");
        }

        public void Logout(User user)
        {
            Console.WriteLine($"{user.Name} Logout Successful");
        }

        public void Register(User user)
        {
            Console.WriteLine($"{user.Name} Register Successful");
        }
    }
}
