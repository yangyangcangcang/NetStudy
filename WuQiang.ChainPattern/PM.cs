using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WuQiang.ChainPattern
{
    public class PM : AbstractAuditor
    {
        public override void Audit(ApplyContext context)
        {
            if (context.Hour<9)
            {
                context.AuditResult = true;
                context.AuditRemark = "PM 同意请假";
            }
            else
            {
                base.AuditNext(context);
            }

        }
    }
}
