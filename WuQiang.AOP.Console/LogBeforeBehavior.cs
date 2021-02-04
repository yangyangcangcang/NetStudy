using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace WuQiang.AOP.Console
{
    public class LogBeforeBehavior : IInterceptionBehavior
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
            System.Console.WriteLine("LogBeforeBehavior");
            System.Console.WriteLine(input.MethodBase.Name);

            foreach (var item in input.Inputs)
            {
               
                System.Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(item));
            }
            return getNext().Invoke(input, getNext);

        }
    }
}
