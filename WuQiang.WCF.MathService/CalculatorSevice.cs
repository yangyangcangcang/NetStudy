using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WuQiang.WCF.Interface;

namespace WuQiang.WCF.MathService
{
    public class CalculatorSevice : ICalculatorSevice
    {
        /// <summary>
        /// 完成计算  然后回调
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public void Plus(int x, int y)
        {
            int nResult = x + y;
            ICallBack callBack = OperationContext.Current.GetCallbackChannel<ICallBack>();
            callBack.Show(1, 2, nResult);
        }
    }
}
