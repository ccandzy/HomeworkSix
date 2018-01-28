using HomeworkSix.Common.UnityAOP.Handler;
using Unity;
using Unity.Interception.PolicyInjection.Pipeline;
using Unity.Interception.PolicyInjection.Policies;

namespace HomeworkSix.Common.UnityAOP
{
    public class UserHandlerAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            ICallHandler handler = new UserHandler() { Order = this.Order };
            return handler;
        }
    }
}
