﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;

namespace ExemploBlog
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
                WebHost.CreateDefaultBuilder(args)
                    .UseStartup<Startup>()
                    .Build();
    }
}
