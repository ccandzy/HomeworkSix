using HomeworkSix.Common.UnityAOP.Handler;
using Unity;
using Unity.Interception.PolicyInjection.Pipeline;
using Unity.Interception.PolicyInjection.Policies;

namespace HomeworkSix.Common.UnityAOP
{
    public class UserNameHandlerAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            ICallHandler handler = new UserNameHandler() { Order = this.Order };
            return handler;
        }
    }
}
