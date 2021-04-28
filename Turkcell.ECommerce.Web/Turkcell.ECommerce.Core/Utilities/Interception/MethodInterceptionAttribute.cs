using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Turkcell.ECommerce.Core.Utilities.Interception
{
    public abstract class MethodInterceptionBaseAttribute :Attribute, IAsyncInterceptor, IInterceptor 
    {
        public int Priority { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {

        }

        public void InterceptAsynchronous(IInvocation invocation)
        {
        }

        public void InterceptAsynchronous<TResult>(IInvocation invocation)
        {
        }

        public void InterceptSynchronous(IInvocation invocation)
        {
        }
    }
}
