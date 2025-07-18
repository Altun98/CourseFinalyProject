﻿using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofac.Performance
{
    public class PerformanceAspect : MethodInterception
    {
        private int _interval;
        private Stopwatch _stopwatch;
        public PerformanceAspect(int interval)
        {
            _interval = interval;
            _stopwatch = ServiceTool.ServiceProvider.GetService<Stopwatch>();
        }
        protected override void OnBefore(IInvocation invocation)
        {
            _stopwatch.Start();
        }
        protected override void OnAfter(IInvocation invocation)
        {
            if (_stopwatch.Elapsed.TotalSeconds > _interval)
            {
                string filePath = @"C:\Users\User\Desktop\performans.txt";
                string content = $"Performance: {invocation.Method.DeclaringType.FullName}.{invocation.Method.Name}-- Vaxt:-->{_stopwatch.Elapsed.TotalSeconds}";
                using (StreamWriter sw = new StreamWriter(filePath, append: true))
                {
                    sw.WriteLine(content);
                }
            }
            _stopwatch.Reset();
        }
    }
}
