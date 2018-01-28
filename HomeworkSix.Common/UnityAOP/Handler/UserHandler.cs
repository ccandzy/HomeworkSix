using HomeworkSix.Model;
using System;
using Unity.Interception.PolicyInjection.Pipeline;

namespace HomeworkSix.Common.UnityAOP.Handler
{
    public class UserHandler : ICallHandler
    {
        public int Order { get; set; }
        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            User user = input.Inputs[0] as User;
            if (user.Password.Length < 10)
            {
                return input.CreateExceptionMethodReturn(new Exception("密码长度不能小于10位"));
            }
            Console.WriteLine("参数检测无误");
            IMethodReturn methodReturn = getNext()(input, getNext);
            return methodReturn;
        }
    }
}
