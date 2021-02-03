using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace WuQiang.SOA.WebserviceTest
{
    [TestClass]//表示单元测试类
    public class UnitTestWebservice
    {
        [TestInitialize]//初始化，一定先执行
        public void Init()
        {
            Console.WriteLine("start");
        }


        [TestMethod]//表示测试方法
        public void TestMethod()
        {

            using (WebSeviceTest.MyWebServiceSoapClient client = new WebSeviceTest.MyWebServiceSoapClient())
            {
                string content = client.HelloWorld(new WebSeviceTest.CustomSoapHeader()
                {
                    UserName = "s99",
                    PassWord = "17879"
                });
                int nResult1 = client.Plus(1, 2);
                //断言
                Assert.AreEqual(nResult1, 3);
                int nResult2 = client.Minus(1, 2);
                Assert.AreEqual(nResult2, 3);

            }

        }
    }
}
