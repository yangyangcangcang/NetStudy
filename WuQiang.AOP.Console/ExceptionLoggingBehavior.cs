using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace WuQiang.AOP.Console
{
    public class ExceptionLoggingBehavior : IInterceptionBehavior
    {
        public bool WillExecute
        {
            get
            {
                return true;
            }
        }

        public IEnumerable<Type> GetRequiredInterfaces()
        {
            return Type.EmptyTypes;
        }

        public IMethodReturn Invoke(IMethodInvocation input, GetNextInterceptionBehaviorDelegate getNext)
        {
            System.Console.WriteLine("ExceptionLoggingBehavior");
            IMethodReturn methodReturn =  getNext().Invoke(input, getNext);
            if (methodReturn.Exception==null)
            {
                System.Console.WriteLine("无异常");
            }
            else
            {
                System.Console.WriteLine($"异常：{methodReturn.Exception.Message}");
            }
            return methodReturn;
        }
    }
}
