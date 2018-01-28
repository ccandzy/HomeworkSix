using HomeworkSix.Model;
using System;
using Unity.Interception.PolicyInjection.Pipeline;

namespace HomeworkSix.Common.UnityAOP.Handler
{
    public class LogHandler: ICallHandler
    {
        public int Order { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input">方法调用的参数列表</param>
        /// <param name="getNext"></param>
        /// <returns></returns>
        public IMethodReturn Invoke(IMethodInvocation input, GetNextHandlerDelegate getNext)
        {
            User user = input.Inputs[0] as User;
            string message = $"RegUser:Username:{user.Name},Password:{user.Password}";
            Console.WriteLine("日志已记录，Message:{0},Ctime:{1}", message, DateTime.Now);
            return getNext()(input, getNext);
        }
    }
}
