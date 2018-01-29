using HomeworkSix.Model;
using System;
using Unity.Interception.PolicyInjection.Pipeline;

namespace HomeworkSix.Common.UnityAOP.Handler
{
    public class UserNameHandler : ICallHandler
    {
        public int Order { get; set; }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            User user = input.Inputs[0] as User;
            if (user.Name != "ELEVEN")
            {
                return input.CreateExceptionMethodReturn(new Exception("用户名必须为ELEVEN"));
            }
            Console.WriteLine("用户名必须为ELEVEN");
            IMethodReturn methodReturn = getNext()(input, getNext);
            return methodReturn;
        }
    }
}
