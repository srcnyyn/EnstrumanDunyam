using System;
using Castle.DynamicProxy;

namespace Business.Utilities.Interceptors
{
    public class MethodInterception:MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation){}
        protected virtual void OnAfter(IInvocation invocation){}
        protected virtual void OnException(IInvocation invocation,Exception ex){}
        protected virtual void OnSuccess(IInvocation invocation){}
        public override void Intercept(IInvocation invocation)
        {
            var isSuccess=true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                isSuccess=false;
                OnException(invocation,ex);
            }
            finally
            {
                if(isSuccess)
                    OnSuccess(invocation);
            }
            OnAfter(invocation);
        }
    }
}