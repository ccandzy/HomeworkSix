using HomeworkSix.Model;
using HomeworkSix.Common.UnityAOP;

namespace HomeworkSix.Interface
{
    [UserHandler(Order = 1)]
    [ExceptionHandler(Order = 3)]
    [LogHandler(Order = 2)]
    [AfterLogHandler(Order = 5)]
    public interface IUserService
    {
        void Register(User user);
    }
}
