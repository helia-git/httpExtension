using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HttpExtension
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
   
    public static class HttpContextExtension
    {
        public static void SetSession(this HttpContext context, string key,string data)
        {
            context.Session.SetString(key, data);
        }
        public static T GetSession<T>(this HttpContext context, string key)
        {
            string data = context.Session.GetString(key);

            return JsonConvert.DeserializeObject<T>(data);
        }
    }
    
}

