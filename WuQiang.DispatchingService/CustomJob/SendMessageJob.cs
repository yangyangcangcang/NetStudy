using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WuQiang.DispatchingService.CustomJob
{
    [PersistJobDataAfterExecution]//执行后的保留作业数据
    [DisallowConcurrentExecution] //确保上次任务执行完成后 再执行下一次任务
    public class SendMessageJob : IJob
    {
        //每执行一次  就创建一个对象     无状态
        public SendMessageJob()
        {
            //Console.WriteLine("SendMessageJob  执行了");
        }

        /// <summary>
        /// 当前Task内部就是作业体要执行的任务
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task Execute(IJobExecutionContext context)
        {
            await Task.Run(()=> {

                //Thread.Sleep(8000);

                object person1 =  context.JobDetail.JobDataMap.Get("person1");
                string person2 =  context.JobDetail.JobDataMap.GetString("person2");
                string person3 = context.JobDetail.JobDataMap.GetString("person3");
                int age = context.JobDetail.JobDataMap.GetInt("Age");
                Console.WriteLine($"person1：{person1}，person2：{person2}，person3：{person3}，age：{age}，开始任务,时间：{DateTime.Now}");

                object person5 = context.Trigger.JobDataMap.Get("person5");
                object person6 = context.Trigger.JobDataMap.Get("person6");
                int person7_Age = context.Trigger.JobDataMap.GetInt("Age");

                //使用这个MergedJobDataMap 获取参数  以后者为准
                object ages = context.MergedJobDataMap.Get("Age");

                //需要使用上一次结果
                context.JobDetail.JobDataMap.Put("Age", age + 1);

                Console.WriteLine($"person5：{person5}，person6：{person6}，person7_Age：{person7_Age},age:{ages},时间：{DateTime.Now}");

            });
        }
    }
}
