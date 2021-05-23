using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WuQiang.DispatchingService.CustomJob;
using WuQiang.DispatchingService.CustomListerer;

namespace WuQiang.DispatchingService
{
    public class DispatchingManager
    {
       public async static Task Init()
        {
            //创建单元（时间轴/载体）
            StdSchedulerFactory factory = new StdSchedulerFactory();
            IScheduler scheduler = await  factory.GetScheduler();
            await scheduler.Start();


            scheduler.ListenerManager.AddJobListener(new CustomJobListener());
            scheduler.ListenerManager.AddTriggerListener(new CustomTriggerListener());
            scheduler.ListenerManager.AddSchedulerListener(new CustomSchedulerListener());
            
            //Job (作业)
            IJobDetail jobDetail = JobBuilder.Create<SendMessageJob>()
                                                .WithIdentity("SendMessageJob","group1")//指定分组
                                               .WithDescription("this is Send Message Job")//添加描述
                                               .Build();

            //通过 jobDetail，传入参数
            jobDetail.JobDataMap.Add("person1","张三");
            jobDetail.JobDataMap.Add("person2", "李四");
            jobDetail.JobDataMap.Add("person3", "王五");
            jobDetail.JobDataMap.Add("Age", 8);

            //时间策略
            //ITrigger trigger = TriggerBuilder.Create()
            //                      .WithIdentity("SendMessageTrigger", "group1")
            //                      //.StartAt(new DateTimeOffset()) //从某个时间点开始
            //                      .StartNow()  //马上执行了一次
            //                      .WithSimpleSchedule(w=>w.WithIntervalInSeconds(5).WithRepeatCount(3))//WithRepeatCount =>最多执行三次   WithIntervalInSeconds=>5秒执行   .RepeatForever() =>循环往复
            //                      .Build();


            //Cron
            ITrigger trigger = TriggerBuilder.Create()
                                 .WithIdentity("SendMessageTrigger", "group1")
                                 .StartAt(new DateTimeOffset(DateTime.Now.AddSeconds(10))) //从某个时间点开始
                                 //.StartNow()  //马上执行了一次
                                 .WithCronSchedule("5/10 * * * * ?")//从5开始每间隔10s执行一次
                                 .WithDescription("This is test job ")
                                 .Build();

            //通过 ITrigger 传入参数
            trigger.JobDataMap.Add("person5", "赵六");
            trigger.JobDataMap.Add("person6", "王琦");
            trigger.JobDataMap.Add("Age", 90);
            //把时间策略和作业加入到单元上
            await scheduler.ScheduleJob(jobDetail, trigger);


        }

    }
}
