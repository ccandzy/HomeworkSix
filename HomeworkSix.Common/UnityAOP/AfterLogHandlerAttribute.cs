using HomeworkSix.Common.Handler;
using Unity;
using Unity.Interception.PolicyInjection.Pipeline;
using Unity.Interception.PolicyInjection.Policies;

namespace HomeworkSix.Common.UnityAOP
{
    public class AfterLogHandlerAttribute: HandlerAttribute
    {
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            return new AfterLogHandler() { Order = this.Order };
        }
    }
}
