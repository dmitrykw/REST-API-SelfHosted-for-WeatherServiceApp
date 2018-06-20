using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
namespace Client
{
    class Program
    {
        static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Необходимо задать URL и порт для подключеня");
                Console.WriteLine("Например: http://localhost:81");
                Console.WriteLine("Для получения информации о конкретных городах используется команда вида: Client.exe http://localhost:81 Москва Питер Киев");               
                Console.WriteLine();
                return;
            };

            string hostname = args[0];
            client.BaseAddress = new Uri(hostname);

            
            // ListItem(1);


            if (args.Length >= 2)
            {
                foreach (string arg in args)
                {
                    if (arg != args[0])
                    {
                        ListItems(arg);
                    }

                }
            }
            else { ListAllItems(); }


            Console.WriteLine();
            Console.WriteLine("Press Enter to quit.");
            Console.ReadLine();

        }
        static void ListAllItems()
        {
            HttpResponseMessage resp = client.GetAsync("api/items").Result;
            //resp.EnsureSuccessStatusCode();

            var items = resp.Content.ReadAsAsync<IEnumerable<Hosting.Item>>().Result;
            foreach (var item in items)
            {
                Console.WriteLine("{0} {1} {2}", item.CityName, item.FileName, item.WeatherText);
            }
        }

       // static void ListItem(int id)
       // {
       //     var resp = client.GetAsync(string.Format("api/products/{0}", id)).Result;
       //     //resp.EnsureSuccessStatusCode();
       //
        //    var item = resp.Content.ReadAsAsync<Hosting.Item>().Result;
        //    Console.WriteLine("ID {0}: {1}", id, item.CityName);
       // }

        static void ListItems(string city)
        {
            Console.WriteLine("items in '{0}':", city);

            string query = string.Format("api/items?city={0}", city);

            var resp = client.GetAsync(query).Result;
            resp.EnsureSuccessStatusCode();

            var items = resp.Content.ReadAsAsync<IEnumerable<Hosting.Item>>().Result;
            foreach (var item in items)
            {
                Console.WriteLine(item.CityName);
                Console.WriteLine(item.WeatherText);
            }
        }
    }
}
