using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WuQiang.WCF.Test.WCFConsoleService;
using System.ServiceModel;

namespace WuQiang.WCF.Test
{
    [TestClass]
    public class UnitTestWCF
    {
        [TestMethod]
        public void TestMethodConsoleWCF()
        {

            WCFConsoleService.MathServiceClient client = null;
            try
            {
                client = new WCFConsoleService.MathServiceClient();
                WCFUser user = client.GetUser(1, 2);
                int n = client.PlusInt(1, 5);
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (client != null)
                {
                    client.Abort();
                }
                throw;
            }
        }

        [TestMethod]
        public void TestMethodConsoleWCFTcp()
        {

            WCFTCPConsoleService.MathServiceClient client = null;
            try
            {
                client = new WCFTCPConsoleService.MathServiceClient();
                var user = client.GetUser(1, 2);
                int n = client.PlusInt(1, 5);
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (client != null)
                {
                    client.Abort();
                }
                throw;
            }
        }
        [TestMethod]
        public void TestMethodConsoleCallBackTcpWCF()
        {

            CallBackWCFTcpService.CalculatorSeviceClient client = null;
            try
            {
                InstanceContext instanceContext = new InstanceContext(new CallBackService());
                client = new CallBackWCFTcpService.CalculatorSeviceClient(instanceContext);
                client.Plus(1, 4);
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                if (client != null)
                {
                    client.Abort();
                }
                throw;
            }
        }


    }
}
