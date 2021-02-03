using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WuQiang.WCF.Test
{
    public class CallBackService : CallBackWCFTcpService.ICalculatorSeviceCallback
    {
        public void Show(int x, int y, int result)
        {
            //throw new NotImplementedException();
            Console.WriteLine($"[回调函数]:x={x},y={y},result={result}");
        }
    }
}
