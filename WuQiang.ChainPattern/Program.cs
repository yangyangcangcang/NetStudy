using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WuQiang.ChainPattern
{
    /// <summary>
    /// 责任链模式：解决一个请求需要多个环节处理，环节可能扩展，变化、调整顺序等问题
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ApplyContext context = new ApplyContext() { Hour = 10 };

            PM pm = new PM() { Name = "PM"};
            AbstractAuditor ceo = new CEO() { Name="ceo"};

            pm.SetNext(ceo);

            pm.Audit(context);

            if (context.AuditResult)
            {
                Console.WriteLine(context.AuditRemark);
            }
            Console.ReadKey();
        }
    }
}
