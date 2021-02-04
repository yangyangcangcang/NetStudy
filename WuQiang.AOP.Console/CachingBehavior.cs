using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Interception.InterceptionBehaviors;
using Unity.Interception.PolicyInjection.Pipeline;

namespace WuQiang.AOP.Console
{
    public class CachingBehavior : IInterceptionBehavior
    {
        private static Dictionary<string, object> CachingDictionary = new Dictionary<string, object>();

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
            System.Console.WriteLine("CachingBehavior");
            string key = $"{input.MethodBase.Name}_{Newtonsoft.Json.JsonConvert.SerializeObject(input.Inputs)}";
            if (CachingDictionary.ContainsKey(key))
            {
                return input.CreateMethodReturn(CachingDictionary[key]);
            }else
            {
                IMethodReturn methodReturn =  getNext().Invoke(input, getNext);
                CachingDictionary.Add(key, methodReturn);
                return methodReturn;
            }
        }
    }
}
