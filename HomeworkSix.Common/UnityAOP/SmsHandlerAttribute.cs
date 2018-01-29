using HomeworkSix.Common.UnityAOP.Handler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Interception.PolicyInjection.Pipeline;
using Unity.Interception.PolicyInjection.Policies;

namespace HomeworkSix.Common.UnityAOP
{
    public class SmsHandlerAttribute : HandlerAttribute
    {
        public override ICallHandler CreateHandler(IUnityContainer container)
        {
            ICallHandler callHandler = new SmsHandler() { Order = this.Order };
            return callHandler;
        }
    }
}
