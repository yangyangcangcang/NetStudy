using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WuQiang.WCF.Interface
{
    [ServiceContract(CallbackContract =typeof(ICallBack))]
    public interface ICalculatorSevice
    {
        [OperationContract(IsOneWay =true)]
        void Plus(int x, int y); //IsOneWay =true时 ，有回调不能带返回值
    }
}
