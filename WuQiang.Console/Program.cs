﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WuQiang.DispatchingService;

namespace WuQiang.Console
{
    /// <summary>
    /// SOA 
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DispatchingManager.Init().GetAwaiter().GetResult();

            System.Console.ReadKey();
        }
    }
}
