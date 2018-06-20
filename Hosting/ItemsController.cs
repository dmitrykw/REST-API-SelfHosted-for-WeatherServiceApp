using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Http;

namespace Hosting
{
     public class ItemsController : ApiController
    {

        public List<Item> GetAllItems()
        {            
            List<Item> items = WeatherFiles.GetAllCity();
            return items;
        }

         //public List<Item> GetItemById(string cityname)
       //    {            
            //var item = items.FirstOrDefault((i) => i.FileName == cityname);
            //   if (item == null)
            //   {
            //      throw new HttpResponseException(HttpStatusCode.NotFound);
            //  }
           // List<Item> items = WeatherFiles.GetCity("moskva");
           // return items;            
          //}

        public List<Item> GetItemsByCity(string city)
          {
            List<Item> items = WeatherFiles.GetCity(city);
            return items;
            //return items.Where(i => string.Equals(i.Category, category,
            //          StringComparison.OrdinalIgnoreCase));
        }




        //Функция для преобразования названия города, которое ввел пользователь в стандартное название для подстановки в URL
        string GetCityNameForURL(string UserInputCity)
        {
            //Приводим все буквы к нижнему регистру
            UserInputCity = UserInputCity.ToLower();

            string OutputCity = "";  //Объявляем переменную для результата


            // перебираем условия транслитерации
            switch (UserInputCity)
            {
                case "москва":
                    OutputCity = "moskva";
                    break;
                case "мск":
                    OutputCity = "moskva";
                    break;
                case "санкт-петербург":
                    OutputCity = "sankt-peterburg";
                    break;
                case "питер":
                    OutputCity = "sankt-peterburg";
                    break;
                case "спб":
                    OutputCity = "sankt-peterburg";
                    break;

                //По умолчанию используем автоматичесскую транслитерацию
                default:
                    OutputCity = Autotransliteration.Convert(UserInputCity);
                    break;

            }

            return OutputCity;
        }




    }
}
