using HomeworkSix.Model;
using HomeworkSix.Common.UnityAOP;

namespace HomeworkSix.Interface
{
   
    [UserNameHandler(Order = 1)]
    [UserHandler(Order = 2)]
    [ExceptionHandler(Order = 5)]
    [LogHandler(Order = 3)]
    [AfterLogHandler(Order =6)]
    [SmsHandler(Order =4)]
    public interface IUserService
    {
        void Register(User user);
        void Login(User user);
        void Logout(User user);
    }
}
