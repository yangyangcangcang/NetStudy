using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace WuQiang.AOP.Console
{
    public class ParameterCheckBehavior : IInterceptionBehavior
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
            System.Console.WriteLine("ParameterCheckBehavior");
            User user = input.Inputs[0] as User;
            if (user.Age<18)//检查参数
            {
                //返回一个异常
                return input.CreateExceptionMethodReturn(new Exception("未成年人"));
            }
            else
            {
                System.Console.WriteLine("成年了");
                return getNext().Invoke(input, getNext);
            }
        }
    }
}
