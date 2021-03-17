using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace warehouse
{
    /// <summary>
    /// Класс описывающий ящик.
    /// </summary>
    internal sealed class VegetableStorageClass
    {
        // id объекта класса ящик.
        private readonly string id;
        // Вес ящика(масса).
        private readonly int weight;
        // Цена за килограмм.
        private int priceForKilo;

        /// <summary>
        /// ID объекта ящик.
        /// </summary>
        public string ID
        {
            get { return id; }
        }

        private static int nowIDNum;
        /// <summary>
        /// Строка нужная для получения нового ID для ящика.
        /// </summary>
        public static string NowIDNum {
            get
            {
                nowIDNum++;
                return '.' + Convert.ToString(nowIDNum);
            }
            
        }
        static VegetableStorageClass()
        {
            nowIDNum = -1;
        }

        
        /// <summary>
        /// Конструктор, принимающий в качестве параметров , ID, вес ящика и цену за килограмм.
        /// </summary>
        /// <param name="id">
        /// ID объекта.
        /// </param>
        /// <param name="weight">
        /// Вес ящика.
        /// </param>
        /// <param name="priceForKilo">
        /// Цена за килограмм.
        /// </param>
        public VegetableStorageClass(string id, int weight, int priceForKilo)
        {
            this.id = id;
            this.weight = weight;
            this.priceForKilo = priceForKilo;
        }

        /// <summary>
        /// Вес ящика.
        /// </summary>
        public int Weight
        {
            get { return weight; }
        }

        /// <summary>
        /// Цена за килограмм.
        /// </summary>
        public int PriceForKilo
        {
            get { return priceForKilo; }
            set { priceForKilo = value; }
        }

        /// <summary>
        /// Вывод информации о ящике.
        /// </summary>
        /// <param name="indent">
        /// Отступ от левого края.
        /// </param>
        public void PrintInfo(int indent)
        {
            string idStr = $"- ящик ID: {id};";
            string str = $"  вес ящика: {weight}; цена за килограмм: {priceForKilo}; цена ящика: {GetStoragePrice()}";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(idStr.PadLeft(idStr.Length + indent, ' '));
            Console.ResetColor();
            Console.Write(str.PadLeft(str.Length + indent, ' ') + '\n');
        }

        /// <summary>
        /// Метод, Возвращающий цену ящика.
        /// </summary>
        /// <returns></returns>
        public double GetStoragePrice()
        {
            return weight * priceForKilo;
        }

        /// <summary>
        /// Сохранение информации о ящике.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="indent"></param>
        public void SaveStorageInfo(string path, int indent)
        {
            try
            {
                string idStr = $"- ящик ID: {id}; \n";
                string str = $"  вес ящика: {weight}; цена за килограмм: {priceForKilo}; цена ящика: {GetStoragePrice()}";
                File.AppendAllText(path, idStr.PadLeft(idStr.Length + indent, ' '));
                File.AppendAllText(path, str.PadLeft(str.Length + indent, ' ') + '\n');
                InfoWasSaved();
            }
            catch
            {
                InfoWasntSaved();
            }
        }

        /// <summary>
        /// Сообщение о том, что информация о ящике была сохранена.
        /// </summary>
        private void InfoWasSaved()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Информация о ящике с ID {id} была сохранена в файл.");
            Console.ResetColor();
        }

        /// <summary>
        ///  Сообщение о том, что информация о ящике не сохранена.
        /// </summary>
        private void InfoWasntSaved()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Не получилось сохранить информацию о ящике с ID {id} в файл.");
            Console.ResetColor();
        }
    }
}
