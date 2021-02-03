using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WuQiang.ChainPattern
{
    public abstract class AbstractAuditor
    {
        public string Name { get; set; }
        public abstract void Audit(ApplyContext context);

        private AbstractAuditor _Auditor = null;
        public void SetNext(AbstractAuditor auditor)
        {
            this._Auditor = auditor;
        }

        public void AuditNext(ApplyContext context)
        {
            if (this._Auditor==null)
            {
                return;
            }
            this._Auditor.Audit(context);
        }

    }
}
