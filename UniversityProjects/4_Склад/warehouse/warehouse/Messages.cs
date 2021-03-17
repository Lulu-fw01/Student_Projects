using System;
using System.IO;

namespace warehouse
{
    partial class Program
    {
        /// <summary>
        /// Сообщение о том, что не удалось выполнить операцию.
        /// </summary>
        public static void OperationFeltMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Что-то пошло не так и не удалось выполнить данную операцию.");
            Console.ResetColor();
        }

        /// <summary>
        /// Метод который печатает содержимое файла.
        /// </summary>
        /// <param name="path"></param>
        public static void PrintExampleMessage(string path)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                string text = File.ReadAllText(path);
                Console.WriteLine(text);
                Console.ResetColor();
            }
            catch {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("нет доступа к файлу с примером");
                Console.ResetColor();
            }
            
        }
        
        /// <summary>
        /// Вывод в консоль списка команд.
        /// </summary>
        public static void PrintContainerCommands()
        {
            PrintExampleMessage(@"../../../ContainerOperationsMessage.txt");
        }

        /// <summary>
        /// Вывод в консоль команд добавления нового контейнера.
        /// </summary>
        public static void HowToAddNewContainerCommands()
        {
            Console.WriteLine("Как вы хотите добавить новый контейнер?");
            Console.WriteLine("1 - Ввод данных в консоль" + '\n' + "2 - Считать данные из файла");
        }

        /// <summary>
        /// Вывод в консоль команд добавления нового склада.
        /// </summary>
        public static void HowToMakeNewWarehouseCommands()
        {
            Console.WriteLine("Создание склада.\n1 - Ввод данных в консоль. \n2 - Считать данные из файла.");
        }

        /// <summary>
        /// Вывод в консоль сообщения о том, что в файле неверные данные.
        /// </summary>
        public static void WrongDataInFileMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Неверные данные в файле.");
            Console.ResetColor();
        }

        /// <summary>
        /// Вывод в консоль примера ввода склада из файла.
        /// </summary>
        public static void WarehouseExampleFileMessage()
        {
            PrintExampleMessage(@"../../../WarehouseExampleFile.txt");
            Console.WriteLine($"Введите полный путь к файлу (формат: D:{Path.DirectorySeparatorChar}yourDirectory{Path.DirectorySeparatorChar}yourFile.txt )");
        }

        /// <summary>
        /// Вывод в консоль примера ввода контейнера через файл.
        /// </summary>
        public static void ContainerExampleFileMessage()
        {
            PrintExampleMessage(@"../../../ContainerExampleFile.txt");
            Console.WriteLine($"Введите полный путь к файлу (формат: D:{Path.DirectorySeparatorChar}yourDirectory{Path.DirectorySeparatorChar}yourFile.txt )");
        }

        /// <summary>
        /// Вывод в консоль примера ввода файла с набором команд.
        /// </summary>
        public static void CommandsExampleFileMessage()
        {
            PrintExampleMessage(@"../../../CommandsExampleFile.txt");
            Console.WriteLine($"Введите полный путь к файлу (формат: D:{Path.DirectorySeparatorChar}yourDirectory{Path.DirectorySeparatorChar}yourFile.txt )");
        }

    }
}