using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;
namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Необходимо задать путь к папке с файлами погоды, выгруженными с помощью WeatherParser.exe и порт tcp на котором будет запущен http сервис");
                Console.WriteLine("Например: Hosting.exe 'C:\\WeatherParser\\Data' 81");
                Console.WriteLine("По умолчанию используется порт 80");
                return;
            };


            string hostname = "http://localhost:80";
            if (args.Length >= 2){hostname = "http://localhost:" + args[1];}            

            WeatherFiles.filesPath = args[0];
            var config = new HttpSelfHostConfiguration(hostname);


          //  config.Routes.MapHttpRoute(
           // name: "BookRoute",
           // routeTemplate: "api/{controller}/{action}"
           // );


            config.Routes.MapHttpRoute(
                "API Default", "api/{controller}/{id}",
               new { id = RouteParameter.Optional });

            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();

                Console.WriteLine("");                
                
                Console.WriteLine("Hosting started on: " + hostname);
                Console.WriteLine("Weather Files Path: " + args[0]);
                Console.WriteLine("Press Enter to quit.");              

                Console.ReadLine();
            }
        }
    }
}
