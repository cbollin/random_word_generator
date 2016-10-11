using System.IO;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System;


namespace ninjagold2
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello From Programcs");
            IWebHost host = new WebHostBuilder()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            host.Run();
        }
    }
}