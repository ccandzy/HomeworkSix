using HomeworkSix.Interface;
using HomeworkSix.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSix.Factory
{
    public class SimpleFactory
    {
        public static IUserService CreateService()
        {
            return new UserService();
        }
    }
}
