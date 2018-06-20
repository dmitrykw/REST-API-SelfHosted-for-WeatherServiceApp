using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Hosting
{
    static class WeatherFiles
    {

        public static string filesPath { get; set; }
        
       


        public static List<Item> GetAllCity()
        {                      


            List<string> filesList = new List<string>();
            //Задаем разрешенные расширения
            var allowedExtensions = new[] { ".txt"};
            //Используем Linc для вычленения нужных файлов из общего списка файлов
            filesList = Directory.GetFiles(filesPath, "*.*", SearchOption.AllDirectories).Where(file => allowedExtensions.Any(file.ToLower().EndsWith)).ToList();

            List<Item> items = new List<Item>();     
            

            foreach (string file in filesList)
            {
                using (FileStream fstream = File.OpenRead(file))
                {
                    // преобразуем строку в байты
                    byte[] array = new byte[fstream.Length];
                    // считываем данные
                    fstream.Read(array, 0, array.Length);
                    // декодируем байты в строку
                    string textFromFile = System.Text.Encoding.UTF8.GetString(array);
                    items.Add(new Item { CityName = Path.GetFileNameWithoutExtension(file), FileName = fstream.Name, WeatherText = textFromFile });                    
                }
            }
            return items;

        }


        public static List<Item> GetCity(string CityName)
        {
            List<string> filesList = new List<string>();
            //Задаем разрешенные расширения
            var allowedExtensions = new[] { ".txt" };
            //Используем Linc для вычленения нужных файлов из общего списка файлов
           filesList = Directory.GetFiles(filesPath, "*.*", SearchOption.AllDirectories).Where(file => allowedExtensions.Any(file.ToLower().EndsWith)).ToList();

            List<Item> items = new List<Item>();          

             string FileName = GetCityNameForURL(CityName);

            foreach (string file in filesList)
            {
                if (Path.GetFileNameWithoutExtension(file) == FileName)
                {
                    using (FileStream fstream = File.OpenRead(file))
                    {
                        // преобразуем строку в байты
                        byte[] array = new byte[fstream.Length];
                        // считываем данные
                        fstream.Read(array, 0, array.Length);
                        // декодируем байты в строку
                        string textFromFile = System.Text.Encoding.UTF8.GetString(array);
                        items.Add(new Item { CityName = Path.GetFileNameWithoutExtension(file), FileName = fstream.Name, WeatherText = textFromFile });
                    }
                }
            }
            return items;
        }




        //Функция для преобразования названия города, которое ввел пользователь в стандартное название для подстановки в URL
        static string GetCityNameForURL(string UserInputCity)
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
