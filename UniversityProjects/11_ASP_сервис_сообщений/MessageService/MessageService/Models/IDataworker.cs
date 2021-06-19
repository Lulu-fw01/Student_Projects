using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MessageService.Models
{
    /// <summary>
    /// Интерфейс для подгрузки данных из json файлов.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDataworker<T>
    {
        /// <summary>
        /// Метод загрузки коллекций из файла.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static List<T> LoadData(string path)
        {
            List<T> objects = new List<T>();
            if (System.IO.File.Exists(path))
            {
                var str = System.IO.File.ReadAllText(path);
                objects = JsonConvert.DeserializeObject<List<T>>(str);
            }

            objects ??= new List<T>();
            return objects;
        }

        /// <summary>
        /// Метод сохранения данных.
        /// </summary>
        /// <param name="path"></param>
        public static void SaveData(string path, List<T> objects) => System.IO.File.WriteAllText(path, JsonConvert.SerializeObject(objects));
        
    }
}
