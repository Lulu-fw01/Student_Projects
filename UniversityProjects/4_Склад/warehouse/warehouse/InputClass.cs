using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace warehouse
{
    /// <summary>
    ///  Статический класс с методами ввода разных данных.
    /// </summary>
    internal static class InputClass
    {
        /// <summary>
        /// Ввод пути к файлу для сохранения инфрмации.
        /// </summary>
        /// <returns></returns>
        public static string FileForSavingInfoInput()
        {
            Console.WriteLine($"Введите путь к файлу в который хотите сохранить информацию. Формат: D:{Path.DirectorySeparatorChar}yourDirectory{Path.DirectorySeparatorChar}fileName.txt");
            string path = Console.ReadLine();
            if (Path.GetExtension(path) != ".txt")
            {
                path = path + ".txt";
            }
            return path;
        }

        /// <summary>
        /// Метод ввода пути к файлу.
        /// </summary>
        /// <returns>
        /// Возвращает путь к файлу (строку).
        /// </returns>
        public static string FilePathInput()
        {
            string path = Console.ReadLine();
            bool isCorrect = false;
            if (File.Exists(@path) == true && Path.GetExtension(@path) == ".txt")
            { isCorrect = true; }
            while (isCorrect == false)
            {
                Console.WriteLine("Неверный путь, попробуйте еще раз");
                path = Console.ReadLine();
                if (File.Exists(@path) == true && Path.GetExtension(@path) == ".txt")
                    isCorrect = true;
            }
            return path;
        }

        /// <summary>
        /// Метод ввода целого числа.
        /// </summary>
        /// <returns>
        /// Возвращает целое число больше нуля.
        /// </returns>
        private static int NumInput()
        {
            int num;
            while (int.TryParse(Console.ReadLine(), out num) != true || num < 0)
            {
                Console.WriteLine("Вы ввели некорректные данные, попробуйте еще раз: ");
            }
            return num;
        }

        /// <summary>
        /// Метод ввода цены.
        /// </summary>
        /// <returns></returns>
        public static int PriceInput()
        {
            Console.WriteLine("Цена должна быть в рублях, больше нуля(> 0) и должна быть целым числом.");
            return NumInput();
        }

        /// <summary>
        /// Метод ввод количества контейнеров.
        /// </summary>
        /// <returns></returns>
        public static int NumContainersInput()
        {
            Console.WriteLine("Введите целое число.");
            int num = NumInput();
            while(num == 0)
            {
                Console.WriteLine("на складе не может быть 0 контейнеров, попробуйте ввести другое число");
                num = NumInput();
            }
            return num;
        }

        /// <summary>
        /// Метод ввода количества ячеек для ящика в контейнере. 
        /// </summary>
        /// <returns></returns>
        public static int NumOfPlacesIncontainerInput()
        {
            Console.WriteLine("Введите целое число.");
            int num = NumInput();
            while (num == 0)
            {
                Console.WriteLine("В контейнере не может быть 0 ящиков, попробуйте ввести другое число");
                num = NumInput();
            }
            return num;
        }

        /// <summary>
        /// Метод ввода веса.
        /// </summary>
        /// <returns></returns>
        public static int WeightInput()
        {
            Console.WriteLine("Введите целое число.");
            int num = NumInput();
            while (num == 0)
            {
                Console.WriteLine("Вес не может быть равен 0. Попробуйте еще раз");
                num = NumInput();
            }
            return num;
        }

        /// <summary>
        /// Метод ввода количества ящиков.
        /// </summary>
        /// <returns></returns>
        public static int NumOfNewStorages()
        {
            Console.WriteLine("Введите целое число.");
            int num = NumInput();
            return num;
        }

        /// <summary>
        /// Метод ввода команды.
        /// </summary>
        /// <returns></returns>
        public static int CommandNumInput()
        {
            Console.WriteLine("Введите номер команды(целое число)");
            int num = NumInput();
            return num;
        }

    }
}
