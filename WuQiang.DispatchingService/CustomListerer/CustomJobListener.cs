using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WuQiang.DispatchingService.CustomListerer
{
    /// <summary>
    /// 可以做些记录 
    /// </summary>
    public class CustomJobListener : IJobListener
    {
        public string Name => "CustomJobListener";


        /// <summary>
        /// 执行中断  触发
        /// </summary>
        /// <param name="context"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task JobExecutionVetoed(IJobExecutionContext context, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(()=> {
                Console.WriteLine("this is JobExecutionVetoed");
            });
        }

        /// <summary>
        /// 即将被执行 触发
        /// </summary>
        /// <param name="context"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task JobToBeExecuted(IJobExecutionContext context, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("this is JobToBeExecuted");
            });
        }

        /// <summary>
        /// 执行完毕后  触发
        /// </summary>
        /// <param name="context"></param>
        /// <param name="jobException"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException, CancellationToken cancellationToken = default(CancellationToken))
        {
            await Task.Run(() =>
            {
                Console.WriteLine("this is JobWasExecuted");
            });
        }
    }
}
