using System;
using Unity.Interception.PolicyInjection.Pipeline;

namespace HomeworkSix.Common.UnityAOP.Handler
{
    public class SmsHandler : ICallHandler
    {
        public int Order { get; set; }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            IMethodReturn methodReturn = getNext()(input, getNext);
            Console.WriteLine("发送短信");
            return methodReturn;
        }
    }
}
