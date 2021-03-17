using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Text; 

namespace file_manager
{
    /// <summary>
    /// Класс, в котором содержатся списки с командами для пользвателя.
    /// </summary>
    public static class CommandList
    {
        // Список, в котором находятся команды, которые выодятся в главном меню
        private static List<string> listOfommands = new List<string>() 
        { 
        "1 - просмотр списка дисков компьютера и выбор диска",  // done
        "2 - открыть директорию(папку)",                        // done 
        "3 - операции с файлом", //done
        "4 - создание простого текстового файла в выбранной пользователем кодировке",  //done
        "5 - конкатенация содержимого двух или более текстовых(.txt) файлов и вывод результата" + '\n' + "в консоль в кодировке UTF-8",
        "для выхода введите любую другую цифру"
        };

        // Список, в котором находятся команды для работы с диском.
        private static List<string> listOfDriversOperations = new List<string>()
        {
            "1 - просмотр файлов на диске",  // done
            "2 - просмотр директорий на диске",  // done
            "3 - создать простой текстовый файл на диске (.txt)",  //done
            "для выхода введите любую другую цифру"
        };

        // Список, в котором находятся команды для работы с файлом.
        private static List<string> listOfFileOperations = new List<string>()
        {
            "1 - вывести файл (только для .txt), кодировка, которая стоит по умолчанию",   // done
            "2 - копирование файла",  
            "3 - перемещение файла в выбранную пользователем директорию",
            "4 - удаление файла",
            "5 - вывести файл в кодировке UTF-32",
            "6 - вывести файл в кодировке UTF-8 ",
            "7 - вывести файл в кодировке Unicode",
            "8 - вывести в кодировке BigEndianUnicode",
            "для выхода введите любую другую цифру"
        };

        // Список, в котором находятся команды для работы с директориями.
        private static List<string> listOfDirectoriesOperations = new List<string>()
        {
           "1 - просмотреть файлы в дериктории (перейти в следующую дерикторию) ",
           "2 - просмотреть другие дериктории в выбранной (перейти в следующую дерикторию) ",
           "3 - создать простой текстовый(.txt) файл в этой дериктории",
           "для выхода введите любую другую цифру"
        };

        public static List<string> ListOfCommands
            {
            get { return listOfommands; }
            }

        /// <summary>
        /// Метод класса, который выводит список команд главного меню в консоль.
        /// </summary>
        /// <param name="username"></param>
        public static void CommandListMessage(string username)
        {
            Console.WriteLine(username + ", введи номер команды из списка:");
            for (int i = 0; i < ListOfCommands.Count; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine(ListOfCommands[i]);
            }
        }

        /// <summary>
        /// Метод класса, который выводит команды для работы с диском в консоль. 
        /// </summary>
        public static void CommandListForChosenDisk()
        {
            for (int i = 0; i < listOfDriversOperations.Count; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine(listOfDriversOperations[i]);
            }
        }

        /// <summary>
        /// Метод класса, который выводит команды для работы с файлом в консоль.
        /// </summary>
        public static void CommandListForFiles()
        {
            for(int i = 0; i < listOfFileOperations.Count; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine(listOfFileOperations[i]);
            }
        }

        /// <summary>
        /// Метод класса, который выводит команды для работы с дерикториями в консоль.
        /// </summary>
        public static void CommandListForDirectories()
        {
            for(int i = 0; i < listOfDirectoriesOperations.Count; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine(listOfDirectoriesOperations[i]);
            }
        }
    }
    class Program
    {
        
        /// <summary>
        /// Функция для ввода целого значения, номер команды.
        /// </summary>
        /// <returns></returns>
        public static int InputCommandNum()
        {
            int num;
            // Пользователь будет вводить значение, пока не введет число
            while(int.TryParse(Console.ReadLine(), out num) != true)
            {
                Console.WriteLine("ты ввел некорректные данные " + username + '\n' + "попробуй еще раз");
            }
            return num;
        }

        /// <summary>
        /// функция, где в зависимости от выбранной пользователем команды вызывается другая функция.
        /// </summary>
        public static void CommandBase(int commandNum)
        {
            switch(commandNum)
            {
                // Вывод дисков в консоль.
                case 1:
                    ShowListOfDisks();
                    break;
                // Команда для ввода пути к дериктории.
                case 2:
                    EnterDirectoryForOpening();
                    break;
                // Команда для ввода пути к файлу.
                case 3:
                    GoToFile();
                    break;
                // Команда для создания нового файла.
                case 4:
                    EnterDirectoryForMakingNewFile();
                    break;
                // Команда для конкатенации файлов.
                case 5:
                    FileConcatanation();
                    break;
                // выход, если пльзователь ввел иное значение.
                default:
                    break;
            }
        }

        /// <summary>
        /// Функция, где в зависимости от выбранной пользователем команды вызывается другая функция (Если имя файла не выбрано).
        /// Входные данные: номер команды, файлы находящиеся в директории, название диска
        /// </summary>
        /// <param name="commandNum"></param>
        /// <param name="filesFromDisk"></param>
        /// <param name="diskName"></param>
        public static void FileCommandBase(int commandNum, FileInfo[] filesFromDisk, string diskName)
        {
            string fileName;
            switch (commandNum)
            {
                // Печать файла.
                case 1:
                    Console.WriteLine(username + ", введи название файла (формат: file.txt)");
                    // Проверка корректности введенного названия файла.
                    while (IsFileNameCorrect(filesFromDisk, out fileName) != true)
                    {
                        Console.WriteLine(username + ", что-то не то, попробуй еще раз");
                    }
                    PrintFileInDefaultEncoding(diskName + fileName);
                    break;
                // Копирование файла.
                case 2:
                    Console.WriteLine(username + ", введи название файла (формат: file.txt)");
                    // Проверка корректности введенного названия файла.
                    while (IsFileNameCorrect(filesFromDisk, out fileName) != true)
                    {
                        Console.WriteLine(username + ", что-то не то, попробуй еще раз");
                    }
                    CopyFile(diskName + fileName);
                    break;
                // Перемещение файла.
                case 3:
                    Console.WriteLine(username + ", введи название файла (формат: file.txt) ");
                    // Проверка корректности введенного названия файла.
                    while (IsFileNameCorrect(filesFromDisk, out fileName) != true)
                    {
                        Console.WriteLine(username + ", что-то не то, попробуй еще раз");
                    }
                    MoveFile(diskName + fileName);
                    break;
                // Удаление файла.
                case 4:
                    Console.WriteLine(username + ", введи название файла (формат: file.txt) ");
                    // Проверка корректности введенного названия файла.
                    while (IsFileNameCorrect(filesFromDisk, out fileName) != true)
                    {
                        Console.WriteLine(username + ", что-то не то, попробуй еще раз");
                    }
                    DeleteFile(diskName + fileName);
                    break;
                // Печать файла в кодировке UTF32.
                case 5:
                    Console.WriteLine(username + ", введи название файла (формат: file.txt)");
                    // Проверка корректности введенного названия файла.
                    while (IsFileNameCorrect(filesFromDisk, out fileName) != true)
                    {
                        Console.WriteLine(username + ", что-то не то, попробуй еще раз");
                    }
                    PrintFileInAnotherEncoding(diskName + fileName, Encoding.UTF32);
                    break;
                // Печать файла в кодировке UTF8.
                case 6:
                    Console.WriteLine(username + ", введи название файла (формат: file.txt)");
                    // Проверка корректности введенного названия файла.
                    while (IsFileNameCorrect(filesFromDisk, out fileName) != true)
                    {
                        Console.WriteLine(username + ", что-то не то, попробуй еще раз");
                    }
                    PrintFileInAnotherEncoding(diskName + fileName, Encoding.UTF8);
                    break;
                // Печать файла в кодировке Unicode.
                case 7:
                    Console.WriteLine(username + ", введи название файла (формат: file.txt)");
                    // Проверка корректности введенного названия файла.
                    while (IsFileNameCorrect(filesFromDisk, out fileName) != true)
                    {
                        Console.WriteLine(username + ", что-то не то, попробуй еще раз");
                    }
                    PrintFileInAnotherEncoding(diskName + fileName, Encoding.Unicode);
                    break;
                // Печать файла в кодировке BigEndianUnicode.
                case 8:
                    Console.WriteLine(username + ", введи название файла (формат: file.txt)");
                    // Проверка корректности введенного названия файла.
                    while (IsFileNameCorrect(filesFromDisk, out fileName) != true)
                    {
                        Console.WriteLine(username + ", что-то не то, попробуй еще раз");
                    }
                    PrintFileInAnotherEncoding(diskName + fileName, Encoding.BigEndianUnicode);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Функция, где в зависимости от выбранной пользователем команды вызывается другая функция (Если имя файла выбрано).
        /// Входные данные: номер команды и путь к файлу.
        /// </summary>
        /// <param name="commandNum"></param>
        /// <param name="wayToFile"></param>
        public static void FileCommandBase(int commandNum, string wayToFile)
        {
            switch (commandNum)
            {
                // Печать файла.
                case 1:
                    PrintFileInDefaultEncoding(wayToFile);
                    break;
                // Копирование файла.
                case 2:
                    CopyFile(wayToFile);
                    break;
                // Пермещение файла.
                case 3:
                    MoveFile(wayToFile);
                    break;
                // Удаление файла.
                case 4:
                    DeleteFile(wayToFile);
                    break;
                // Печать файла в кодировке UTF32.
                case 5:
                    PrintFileInAnotherEncoding(wayToFile, Encoding.UTF32);
                    break;
                // Печать файла в кодировке UTF8.
                case 6:
                    PrintFileInAnotherEncoding(wayToFile, Encoding.UTF8);
                    break;
                // Печать файла в кодировке Unicode.
                case 7:
                    PrintFileInAnotherEncoding(wayToFile, Encoding.Unicode);
                    break;
                // Печать файла в кодировке BigEndianUnicode.
                case 8:
                    PrintFileInAnotherEncoding(wayToFile, Encoding.BigEndianUnicode);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Функция, возвращающая кодировку, которую выбрал пользователь.
        /// </summary>
        /// <param name="commandNum"></param>
        /// <returns></returns>
        public static Encoding ChosenEncoding(int commandNum)
        {
            switch(commandNum)
            {
                case 1:
                    return Encoding.UTF8;
                case 2:
                    return Encoding.Unicode;
                case 3:
                    return Encoding.ASCII;
                default:
                    return Encoding.Default;
            }
        }

        /// <summary>
        /// Функция, в которой пользователь создает новый txt файл.
        /// </summary>
        /// <param name="wayHere"> путь к дерриктории </param>
        public static void CreateNewTxtFile(string wayHere)
        {
            Console.WriteLine(username + ", выберите кодировку, в которой хотите создать файл" + '\n' + "1 - UTF-8" + '\n' + "2 - Unicode" + '\n' + "3 - ASCII" + '\n' + " любая другая цифра - это кодировка по умолчанию");
            // Пользователь вводит номер кодировки, в которой хочет создать файл.
            int decision = InputCommandNum();
            Encoding enc = ChosenEncoding(decision);
            Console.WriteLine(username + ", введите имя файла (формат: name");
            string name = Console.ReadLine();
            try
            {
                // Создание файла в выбранной кодировке.
                File.WriteAllText(wayHere + Path.DirectorySeparatorChar + name + ".txt" , "new file", enc);
            }
            catch
            {
                Console.WriteLine("ошибка, не получилось создать новый файл");
            }
        }

        /// <summary>
        /// Функция, где в зависимости от выбранной команды вызывается другая функция для работы с дерикториями.
        /// </summary>
        /// <param name="commandNum"></param>
        /// <param name="directoriesFrom"></param>
        /// <param name="wayHere"></param>
        public static void DirectoryCommandBase(int commandNum, DirectoryInfo[] directoriesFrom, string wayHere)
        {
            string directoryName;
            switch(commandNum)
            {
                // Показать файлы в дериктории.
                case 1:
                    Console.WriteLine(username + ", введи название дериктории(папки) (формат: directory)");
                    while(IsDirectoryNameCorrect(directoriesFrom, out directoryName) != true)
                    {
                        Console.WriteLine(username + ", что-то не то, попробуй еще раз");
                    }
                    ShowDirectoryFiles(wayHere + directoryName);
                    break;
                // Показать другие дериктории в выбранной.
                case 2:
                    Console.WriteLine(username + ", введи название дериктории(папки) (формат: directory)");
                    while (IsDirectoryNameCorrect(directoriesFrom, out directoryName) != true)
                    {
                        Console.WriteLine(username + ", что-то не то, попробуй еще раз");
                    }
                    ShowDirectories(wayHere + Path.DirectorySeparatorChar + directoryName);
                    break;
                // Создание нового файла в данной дериктории.
                case 3:
                    CreateNewTxtFile(wayHere);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Функция, где в зависимости от выбранной команды вызывается другая функция для работы с дерикториями.
        /// </summary>
        /// <param name="commandNum"></param>
        /// <param name="wayHere"></param>
        public static void DirectoryCommandBase(int commandNum, string wayHere)
        {
            switch (commandNum)
            {
                // Показать файлы в выбранной дериктории.
                case 1:
                    ShowDirectoryFiles(wayHere);
                    break;
                // Показать дериктории в выбранной.
                case 2: 
                    ShowDirectories(wayHere);
                    break;
                // Создать файл в данной дериктории.
                case 3:
                    CreateNewTxtFile(wayHere);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Функция, которая выыодит спиок дисков и их свойства.
        /// </summary>
        public static void ShowListOfDisks()
        {
            // Получения данных о дисках, расположенных на компьютере.
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            // Вывод информации о каждом диске.
            for(int i = 0; i < allDrives.Length; i++)
            {
                
                Thread.Sleep(150);
                Console.WriteLine('\n' + "Имя: " + allDrives[i].Name);
                Thread.Sleep(150);
                Console.WriteLine("Тип: " + allDrives[i].DriveType);
                Thread.Sleep(150);
                try
                {
                    Console.WriteLine("Объем диска: " + allDrives[i].TotalSize + " байт");
                }
                catch(Exception)
                {
                    Console.WriteLine("Объем диска: Информация не доступна");
                }
                Thread.Sleep(150);
                try
                {
                    Console.WriteLine("Объем свободного места: " + allDrives[i].TotalFreeSpace + " байт");
                }
                catch(Exception)
                {
                    Console.WriteLine("Объем свободного места: Информация не доступна");
                }
                Thread.Sleep(150);
                try
                {
                    Console.WriteLine("Корневой каталог: " + allDrives[i].RootDirectory);
                }
                catch(Exception)
                {
                    Console.WriteLine("Корневой каталог: Информация не доступна");
                }
            }

            Console.WriteLine("Вот список команд для диска: ");
            // Вывод списка команд для работы с дисками.
            CommandList.CommandListForChosenDisk();
            int decision = InputCommandNum();
            DriveCommandBase(decision, allDrives);
        }

        /// <summary>
        /// Ввод имени диска.
        /// </summary>
        /// <param name="allDrives"></param>
        /// <returns></returns>
        public static string DiskNameInput(DriveInfo[] allDrives)
        {
            Console.WriteLine(username + ", введите имя диска. Формат: " + "C");
            string diskName;
            // Ввод и проверка на корректностью
            while (IsThisDiskNameCorrect(allDrives, out diskName) != true)
            {
                Console.WriteLine(username + " такой диск не существует, попробуйте ввести еще раз");
            }
            return diskName;
        }

        /// <summary>
        /// Функция, где пользователь выбирает к какому диску применит команду.
        /// </summary>
        /// <param name="allDrives"></param>
        public static void DriveCommandBase(int commandNum, DriveInfo[] allDrives)
        {
            Console.Clear();
            switch (commandNum)
            {
                // Показ файлов на диске.
                case 1:
                    ShowDirectoryFiles(DiskNameInput(allDrives) + Path.DirectorySeparatorChar);
                    break;
                // Показ дерикторий да диске.
                case 2:
                    ShowDirectories(DiskNameInput(allDrives) + Path.DirectorySeparatorChar);
                    break;
                // Создание простого файла на диске.
                case 3:
                    CreateNewTxtFile(DiskNameInput(allDrives) + Path.DirectorySeparatorChar);
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Функция, которая выводит файлы, находящиеся в выбранной дерикториb и выводит команды применимые к файлам.
        /// </summary>
        /// <param name="wayHere"></param>
        public static void ShowDirectoryFiles(string wayHere)
        {
            Console.Clear();
            try
            {
                // Получение информации о дериктории.
                DirectoryInfo diskDirectory = new DirectoryInfo(wayHere);
                // Получение файлов в дериктории.
                FileInfo[] filesFromDisk = diskDirectory.GetFiles();
                if (filesFromDisk.Length > 0)
                {
                    Console.WriteLine(username + ", вот файлы с выбранного пути " + wayHere + '\n');
                    for (int i = 0; i < filesFromDisk.Length; i++)
                    {
                        Thread.Sleep(100);
                        Console.WriteLine(filesFromDisk[i].Name);
                    }
                    Console.WriteLine('\n' + username + ", вот список операций с файлом");
                    // Вывод команд, применимых к файлам.
                    CommandList.CommandListForFiles();
                    int descision = InputCommandNum();
                    FileCommandBase(descision, filesFromDisk, wayHere);
                }
                else
                {
                    Console.WriteLine(" В выбранной вами дериктории нет файлов. Введите любой символ для выхода");
                    Console.ReadKey();
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Ошибка, что-то пошло не так. Введите любой символ.");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Функция, которая выводит папки на выбранном диске.
        /// </summary>
        /// <param name="diskName"></param>
        public static void ShowDirectories(string wayHere)
        {
            Console.Clear();
            try
            {
                // Получаем информацию о дериктории.
                DirectoryInfo diskDirectory = new DirectoryInfo(@wayHere);
                // Получаем информацию о дерикториях, находящихся в выбранной.
                DirectoryInfo[] directoriesFrom = diskDirectory.GetDirectories();
                if (directoriesFrom.Length > 0)
                {
                    for (int i = 0; i < directoriesFrom.Length; i++)
                    {
                        Thread.Sleep(100);
                        Console.WriteLine(directoriesFrom[i].Name);
                    }
                    Console.WriteLine(username + ", вот список операций, применимых к директориям(папкам)" + '\n');
                    CommandList.CommandListForDirectories();
                    int descision = InputCommandNum();
                    DirectoryCommandBase(descision, directoriesFrom, wayHere );
                }
                else
                {
                    Console.WriteLine("в данной дериктории нет других дерикторий. Хотите создать файл в этой дерктории? 1 - да, нет - любое другое число");
                    int decision = InputCommandNum();
                    if (decision == 1)
                        CreateNewTxtFile(wayHere);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Ошибка, что-то пошло не так. Введите любой символ для выхода");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Функция удаления файла.
        /// </summary>
        /// <param name="wayToFile"></param>
        public static void DeleteFile(string wayToFile)
        {
            Console.WriteLine("удаление файла " + wayToFile);
            try
            {
                File.Delete(@wayToFile);
                Console.WriteLine("Файл {0} удален", wayToFile);
            }
            catch(Exception)
            {
                Console.WriteLine("Упс, что-то пошло не так" + '\n');
            }
        }

        /// <summary>
        /// Функция перемещения файла.
        /// </summary>
        /// <param name="wayToFile"></param>
        public static void MoveFile(string wayToFile)
        {
            Console.WriteLine(username + ", куда вы хотите переместить файл {0} ? ", wayToFile + '\n' + "введите полный путь, куда вы хотите переместить файл(пример: D:{0}my_files{0}newFileName)", Path.DirectorySeparatorChar);
            string wayToNewFile = Console.ReadLine();
            try
            {
                // Перемещение файла.
                File.Move(@wayToFile, @wayToNewFile);
            }
            catch(Exception)
            {
                Console.WriteLine("Ошибка, возможно вы ввели неверный путь");
                RusmeFileOperations(wayToFile); 
            }
           
        }

        /// <summary>
        /// Функция, которая копирует файл в выбранную дерикторию.
        /// </summary>
        /// <param name="wayToFile"></param>
        public static void CopyFile(string wayToFile)
        {
            Console.WriteLine(username + ", куда вы хотите скопировать файл {0} ? ", wayToFile + '\n' + @"введите полный путь, куда вы хотите скопировать файл(пример: D:{1}my_files{1}your_new_filename)", Path.DirectorySeparatorChar);
            string wayToNewFile = Console.ReadLine();
            try
            {
                // Копирование файла.
                File.Copy(@wayToFile, @wayToNewFile + Path.GetExtension(wayToFile));
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка, возможно вы ввели неверный путь");

            }
            finally
            {
                RusmeFileOperations(wayToFile);
            }
        }

        /// <summary>
        /// Функция, которая печатает файл .txt  в кодировке установленной по умолчанию.
        /// </summary>
        /// <param name="wayToFile"></param>
        public static void PrintFileInDefaultEncoding(string wayToFile)
        {
            Console.Clear();
            Console.WriteLine("имя файла: " + wayToFile + '\n' + '\n');
            try
            {
                // Программа выбрасывает ошибку, еси файл иного формата.
                if (Path.GetExtension(@wayToFile) != ".txt")
                {
                    throw new Exception();
                }
                // Программа считывает строки из файла.
                string[] chosenFile = File.ReadAllLines(@wayToFile);
                for (int i = 0; i < chosenFile.Length; i++)
                {
                    Thread.Sleep(50);
                    Console.WriteLine(chosenFile[i]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка, возможно вы выбрали файл не того формата" + '\n');
            }
            finally
            {
                RusmeFileOperations(wayToFile);
            }
        }

        /// <summary>
        /// Маленькая функция, которая предлагает пользователю продолжить работать с файлом.
        /// </summary>
        /// <param name="wayToFile"></param>
        public static void RusmeFileOperations(string wayToFile)
        {
            Console.WriteLine('\n' + username + ", хотите провести еще какую-нибудь операцию с данным файлом? ({0})", wayToFile);
            CommandList.CommandListForFiles();
            int descision = InputCommandNum();
            FileCommandBase(descision, wayToFile);
        }

        /// <summary>
        /// Вывод файла в консоль в разных кодировках
        /// </summary>
        /// <param name="wayToFile"></param>
        /// <param name="enc"></param>
        public static void PrintFileInAnotherEncoding(string wayToFile, Encoding enc)
        {
            Console.Clear();
            Console.WriteLine("имя файла: " + wayToFile + '\n' + '\n');
            try
            {
                // Программа выбрасывает ошибку, еси файл иного формата.
                if (Path.GetExtension(@wayToFile) != ".txt")
                {
                    throw new Exception();
                }

                // Считываем строки из файла.
                StreamReader sr = new StreamReader(@wayToFile, enc, true);
                string str = sr.ReadLine();
                while (str != null)
                {
                    Console.WriteLine(str);
                    str = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка, возможно вы выбрали файл не того формата");
            }
            finally
            {
                RusmeFileOperations(wayToFile);
            }
        }

        /// <summary>
        /// Функция, которая проверяет есть ли введенный диск на компьютере.
        /// </summary>
        /// <param name="allDrives"></param>
        /// <param name="diskName"></param>
        /// <returns></returns>
        public static bool IsThisDiskNameCorrect(DriveInfo[] allDrives, out string diskName)
        {
            diskName = Console.ReadLine() + ':';
            bool correct = false;
            for (int i = 0; i < allDrives.Length; i++)
                if (allDrives[i].Name == diskName + Path.DirectorySeparatorChar)
                    correct = true;
            return correct;
        }

        /// <summary>
        /// Функция, которая проверяет есть ли введенный файл в данной директории.
        /// </summary>
        /// <param name="filesFromDisk"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static bool IsFileNameCorrect(FileInfo[] filesFromDirectory, out string fileName)
        {
            fileName = Console.ReadLine();
            bool correct = false;
            for (int i = 0; i < filesFromDirectory.Length; i++)
                if (string.Equals(filesFromDirectory[i].Name, fileName))
                    correct = true;
            fileName = Path.DirectorySeparatorChar + fileName;
            return correct;
        }

        /// <summary>
        /// Поверка, существует ли ввеенная директория
        /// </summary>
        /// <param name="directoriesFrom"></param>
        /// <param name="directoryName"></param>
        /// <returns></returns>
        public static bool IsDirectoryNameCorrect(DirectoryInfo[] directoriesFrom, out string directoryName)
        {
            directoryName = Console.ReadLine();
            bool correct = false;
            for (int i = 0; i < directoriesFrom.Length; i++)
                if (string.Equals(directoriesFrom[i].Name, directoryName))
                    correct = true;
            directoryName = Path.DirectorySeparatorChar + directoryName;
            return correct;
        }

        /// <summary>
        /// Проверка существования введеенной директории. Если она существует, то происходит переход в эту дерикторию.
        /// </summary>
        public static void EnterDirectoryForOpening()
        {
            Console.Clear();
            Console.WriteLine(username + ", введите путь к дериктории(папке) формат: D:{0}my_files ", Path.DirectorySeparatorChar);
            string wayToDir = Console.ReadLine();
            while(Directory.Exists(@wayToDir) != true)
            {
                Console.WriteLine("что- то не так, возможно данной дериктории не существует. Попробуйте ввести еще раз.");
                wayToDir = Console.ReadLine();
            }
            Console.WriteLine("команды для директорий: ");
            CommandList.CommandListForDirectories();
            int decision = InputCommandNum();
            DirectoryCommandBase(decision, wayToDir);

        }

        /// <summary>
        /// Функция, которая вызывается, когда пользователь хочет ввести путь к файлу.
        /// </summary>
        public static void GoToFile()
        {
            Console.Clear();
            Console.WriteLine(username + ", введите путь к файлу формат: D:{0}my_files{0}file_name.txt ", Path.DirectorySeparatorChar);
            string wayToFile = Console.ReadLine();
            // Пользователь вводит путь к файлу, пока не введет верный.
            while (File.Exists(@wayToFile) != true)
            {
                Console.WriteLine("что- то не так, возможно данного файла не существует. Попробуйте ввести еще раз.");
                wayToFile = Console.ReadLine();
            }
            Console.WriteLine("команды для файлов ");
            CommandList.CommandListForFiles();
            int decision = InputCommandNum();
            FileCommandBase(decision, wayToFile);
        }

        /// <summary>
        /// функция прверяет, является ли введенный путь к файлу корректным.
        /// </summary>
        /// <param name="wayToFile"></param>
        /// <returns></returns>
        public static bool IsTxtFileNameCorrect(out string wayToFile)
        {
            wayToFile = Console.ReadLine();
            if (File.Exists(@wayToFile) != true || Path.GetExtension(@wayToFile) != ".txt")
                return false;
            else
                return true;
        }

        /// <summary>
        /// Ввод директории и вызов функуии, где будет создан новый файл.
        /// </summary>
        public static void EnterDirectoryForMakingNewFile()
        {
            Console.Clear();
            Console.WriteLine(username + ", введите путь к дериктории(папке), где вы хотите создать файл. формат: D:{0}my_files ", Path.DirectorySeparatorChar);
            string wayToDir = Console.ReadLine();
            while (Directory.Exists(@wayToDir) != true)
            {
                Console.WriteLine("что- то не так, возможно данной дериктории не существует. Попробуйте ввести еще раз.");
                wayToDir = Console.ReadLine();
            }
            CreateNewTxtFile(wayToDir);
        }

        /// <summary>
        /// Функция, в которой проходит конкатинация файлов.
        /// </summary>
        public static void FileConcatanation()
        {
            Console.Clear();
            Console.WriteLine("Все файлы должны быть только формата .txt" + '\n' + '\n');
            Console.WriteLine("введите количество файлов");
            int kol = InputCommandNum();
            Console.WriteLine("Теперь вводите файлы. формат: D:{0}my_files{0}file_name.txt ", Path.DirectorySeparatorChar);
            string[] filesForConcanation= new string[kol];
            string wayToFile;
            for (int i = 0; i < kol; i++)
            {
                Console.WriteLine("Введите файл № " + i);
                while (IsTxtFileNameCorrect(out wayToFile) != true)
                {
                    Console.WriteLine("что- то не так, возможно данного файла не существует или это файл не того формата. Попробуйте ввести еще раз.");
                }
                filesForConcanation[i] = wayToFile;
            }
            Console.WriteLine(username + ", теперь введите полный путь к файлу, в который перейдут выбранные вами файлы." + '\n' + "Формат: D:{0}my_files{0}file_name.txt ", Path.DirectorySeparatorChar);
            string concFile = Console.ReadLine();
            while ( Path.GetExtension(@concFile) != ".txt")
            {
                Console.WriteLine("Возможно файл не того формата. Попробуйте ввести еще раз.");
                concFile = Console.ReadLine();
            }
            try
            {
                List<string> allLinesFromAllFiles = new List<string>();
                File.WriteAllText(@concFile, "conc_File", Encoding.Default);
                for(int i = 0; i < kol; i++)
                {
                    string[] str = File.ReadAllLines(@filesForConcanation[i]);
                    for(int n = 0; n < str.Length; n++)
                    {
                        allLinesFromAllFiles.Add(str[n]);
                    }
                }
                File.WriteAllLines(@concFile, allLinesFromAllFiles);
                PrintFileInDefaultEncoding(concFile);
            }
            catch(Exception e)
            {
                //Console.WriteLine(e);
                Console.WriteLine("Какая-то ошибка, введите любой символ");
                Console.ReadKey();
            }

        }

        // Имя пользователя.
       static string username;
       
        static void Main(string[] args)
        {
            username = "username";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to file manager");
            Console.WriteLine("Как мне к вам обращаться?");
            try
            {
                username = Console.ReadLine();
            }
            catch(Exception)
            {
                username = "username";
            }
            Console.WriteLine("хорошо " + username);
            string exit = "YES";
            do
            {
                Thread.Sleep(700);
                Console.Clear();
                CommandList.CommandListMessage(username);
                //CommandListMessage(username);
                int commandNum = InputCommandNum();
                CommandBase(commandNum);

                Console.WriteLine(username + ", ты хочешь продолжить? Если да то введи любой символ, " + '\n' + "если нет, то введи NO");
                exit = Console.ReadLine();
                exit = exit.ToUpper();
            }
            while (exit != "NO");
        }
    }
}
