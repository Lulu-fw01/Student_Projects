using System;
using System.Collections.Generic;
using System.IO;

namespace warehouse
{
    partial class Program
    {
        /// <summary>
        /// Выполнение команд из файла.
        /// </summary>
        /// <param name="wh"></param>
        public static void ExcuteCommandsFile(WarehouseClass wh)
        {
            CommandsExampleFileMessage();
            string filePath = InputClass.FilePathInput();
            string[] fileStr = File.ReadAllLines(filePath);
            List<ContainerClass> containerList = new List<ContainerClass>();
            try
            {
                for (int i = 0; i < fileStr.Length; i++)
                {
                    string[] str = fileStr[i].Split(' ');
                    switch(str[0])
                    {
                        case "add":
                            if (str[1] == "container")
                            { containerList.Add(GetContainerFromString(str, wh.ID)); }
                            break;
                        case "storage":
                            if(containerList.Count > 0)
                            {
                                containerList[containerList.Count - 1].AddNewStorage(GetStorageFromString(str, containerList[containerList.Count - 1].ID));
                            }
                            break;
                        case "remove":
                            AddContainerListToWarehouse(wh, containerList);
                            containerList.Clear();
                            if (str[1] == "container")
                            { wh.RemoveContainerAt(GetIdFromString(str)); }
                            break;
                        default:
                            break;
                    }
                }
                AddContainerListToWarehouse(wh, containerList);
                containerList.Clear();
            }
            catch
            {   AddContainerListToWarehouse(wh, containerList);
                containerList.Clear();
                WrongDataInFileMessage(); }
        }

        /// <summary>
        /// Метод, который добавляет список контейнеров на склад.
        /// </summary>
        /// <param name="wh"></param>
        /// <param name="containerList"></param>
        public static void AddContainerListToWarehouse(WarehouseClass wh, List<ContainerClass> containerList)
        {
            for (int k = 0; k < containerList.Count; k++)
            {
                wh.AddContainer(containerList[k]);
            }
        }

        /// <summary>
        /// Метод получения ID из строки, в данной программе используется для исполнения команды remove. 
        /// </summary>
        /// <param name="storegeStr"></param>
        /// <returns></returns>
        public static string GetIdFromString(string[] storegeStr)
        {
            if (storegeStr.Length > 2)
                return storegeStr[2];
            else
                throw new Exception();
        }

        /// <summary>
        /// Метод получения объекта класса ящик из строки 
        /// </summary>
        /// <param name="storegeStr"></param>
        /// <param name="partOfIDStr"></param>
        /// <returns></returns>
        public static VegetableStorageClass GetStorageFromString(string[] storegeStr, string partOfIDStr)
        {
            int weight;
            int price;
            if(int.TryParse(storegeStr[1], out weight) == true && int.TryParse(storegeStr[2], out price) == true)
            {
                return new VegetableStorageClass(partOfIDStr + VegetableStorageClass.NowIDNum, weight, price);
            }
            else
            {
                throw new Exception();
            }
        }

        /// <summary>
        /// Метод получения пустого объекта класса контейнер из строки.
        /// </summary>
        /// <param name="containerStr"></param>
        /// <param name="partOfIDStr"></param>
        /// <returns></returns>
        public static ContainerClass GetContainerFromString(string[] containerStr, string partOfIDStr)
        {
            int numOfStorages;
            if(int.TryParse(containerStr[2], out numOfStorages) == true)
            {
                return new ContainerClass(partOfIDStr + ContainerClass.NowIDNum, numOfStorages); 
            }
            else
            {
                throw new Exception();
            }
        }
       
        /// <summary>
        /// Из этого метода вызываются другие, в которых присходят опреации над складом 
        /// в зависимости от выбранной команды.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="wh"></param>
        public static void FirstOperationsBase(int num, WarehouseClass wh)
        {
            switch(num)
            {
                // Добавление нового контейнера.
                case 1:
                    AddContainerCommand(wh);
                    break;
                    // Удаление контейнера.
                case 2:
                    RemoveContainer(wh);
                    break;
                    // Печать информации о складе.
                case 3:
                    wh.PrintInfo();
                    break;
                    // Выполнение списка команд из файла.
                case 4:
                    ExcuteCommandsFile(wh);
                    break;
                case 5:
                    wh.ClearWarehouse();
                    break;
                case 6:
                    SaveWarehouseInfo(wh);
                    break;
                default:
                    Console.WriteLine("Такой команды нет");
                    break;
            }
        }

        public static void SaveWarehouseInfo(WarehouseClass wh)
        {
            wh.SaveWarehouseInfo(InputClass.FileForSavingInfoInput());
        }

        /// <summary>
        /// Функция удаление контейнера.
        /// </summary>
        /// <param name="wh"></param>
        public static void RemoveContainer(WarehouseClass wh)
        {
            Console.WriteLine("Введите ID контейнера, который выхотите удалить ( формат: 00.1.2");
            string id = Console.ReadLine();
            wh.RemoveContainerAt(id);
        }

        /// <summary>
        /// Выбор способа добавления контейнера.
        /// </summary>
        /// <param name="wh"></param>
        public static void AddContainerCommand(WarehouseClass wh)
        {
            
            HowToAddNewContainerCommands();
            switch(InputClass.CommandNumInput())
            {
                // Ввод данных в консоль.
                case 1:
                    GetNewContainerFromConsole(wh);
                    break;
                // Получение данных из файла.
                case 2:
                    GetNewContainerFromFile(wh);
                    break;
                default:
                    Console.WriteLine("Такого варианта нет");
                    break;
            }
        }

        /// <summary>
        /// Метод создания нового контейнера из консоли.
        /// </summary>
        /// <param name="wh"></param>
        public static void GetNewContainerFromConsole(WarehouseClass wh)
        {
            try
            {
                Random rnd = new Random();
                string containerID = wh.ID + ContainerClass.NowIDNum;
                int containerMaxWeight = rnd.Next(50, 1000);
                Console.WriteLine("Сколько всего мест должно быть в данном контейнере?");
                int numOfPlaces = InputClass.NumOfPlacesIncontainerInput();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"ID вашего контейнера: {containerID}");
                Console.WriteLine($"Максимальный вес, который может вместить контейнер: {containerMaxWeight} кг");
                Console.ResetColor();
                Console.WriteLine("Сколько ящиков вы хотите добавить в контейнер сейчас?");
                int numOfStorages = InputClass.NumOfNewStorages();
                List<VegetableStorageClass> storageList = new List<VegetableStorageClass>();
                for (int i = 0; i < numOfStorages; i++)
                {
                    storageList.Add(GetNewStorageConsole(containerID));
                }
                wh.AddContainer(new ContainerClass(containerID, numOfPlaces, containerMaxWeight, storageList));
            }
            catch(Exception)
            {
                OperationFeltMessage();
            }
        }

        /// <summary>
        /// Метод создания нового ящика из консоли.
        /// </summary>
        /// <param name="partOfId"></param>
        /// <returns></returns>
        public static VegetableStorageClass GetNewStorageConsole(string partOfId)
        {
            Console.WriteLine("Введите вес ящика(в килограммах):");
            int weight = InputClass.WeightInput();
            Console.WriteLine("Введите цену за килограмм:");
            int price = InputClass.PriceInput();
            string newID = partOfId + VegetableStorageClass.NowIDNum;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"ID вашего ящика: {newID}  \n");
            Console.ResetColor();
            return new VegetableStorageClass(newID, weight, price);
        }

        /// <summary>
        /// Выбор способа создания нового склада.
        /// </summary>
        /// <param name="commandNum"></param>
        /// <param name="wh"></param>
        /// <returns></returns>
        public static bool GetNewWarehouseBase(int commandNum, out WarehouseClass wh)
        {
            try
            {
                switch (commandNum)
                {
                    // Ввод данных в консоль.
                    case 1:
                        wh = GetNewWarehouseConsole();
                        return true;
                    // Получение данных из файла.
                    case 2:
                        bool ans = GetNewWarehouseFile(out wh);
                        return ans;
                    default:
                        wh = null;
                        return false;
                }
            }
            catch(Exception e)
            {
                //Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Не получилось создать склад из-за непредвиденной ошибки.");
                Console.ResetColor();
                wh = null;
                return false;
            }
        }

        /// <summary>
        /// Метод ввода данных для создания нового склада из консоли.
        /// </summary>
        /// <returns></returns>
        public static WarehouseClass GetNewWarehouseConsole()
        {
            Console.WriteLine("Введите количество контейнеров, которые могут быть на складе: ");
            int containersNum = InputClass.NumContainersInput();
            Console.WriteLine("Введите цену за место на складе: ");
            int priceForPlace = InputClass.PriceInput();
            return WarehouseClass.GetWarehous(containersNum, priceForPlace);
        }

        /// <summary>
        /// Создание склада из файла.
        /// </summary>
        /// <returns></returns>
        public static bool GetNewWarehouseFile(out WarehouseClass wh)
        {
            WarehouseExampleFileMessage();
            string filePath = InputClass.FilePathInput();
            string[] fileStr = File.ReadAllLines(filePath);
            string[] warehouseData = fileStr[0].Split(' ');
            if(warehouseData[0] == "warehouse" && warehouseData.Length == 3)
            {
                try
                {
                    wh = WarehouseClass.GetWarehous(Convert.ToInt32(warehouseData[1]), Convert.ToInt32(warehouseData[2]));
                    return true;
                }
                catch(Exception)
                {
                    WrongDataInFileMessage();
                    wh = null;
                    return false;
                }
            }
            else
            {
                WrongDataInFileMessage();
                wh = null;
                return false;
            }
            
        }

        /// <summary>
        /// Добавление нового контейнера из файла.
        /// </summary>
        /// <param name="wh"></param>
        public static void GetNewContainerFromFile(WarehouseClass wh)
        {
            ContainerExampleFileMessage();
            string filePath = InputClass.FilePathInput();
            try
            {
                string[] fileStr = File.ReadAllLines(filePath);
                string[] ContainerData = fileStr[0].Split(' ');
                if (ContainerData[0] == "container")
                {
                    int numOfstorages = Convert.ToInt32(ContainerData[1]);
                    string containerID = wh.ID + ContainerClass.NowIDNum;
                    if (fileStr.Length > 1)
                    {
                        Random rnd = new Random();
                        int containerMaxWeight = rnd.Next(50, 1000);
                        wh.AddContainer(new ContainerClass(containerID, numOfstorages, containerMaxWeight, GetStoragesListFromFileWithContainer(fileStr, containerID)));
                    }
                    else
                    {
                        wh.AddContainer(new ContainerClass(containerID, numOfstorages));
                    }
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                WrongDataInFileMessage();
            }
        }

        /// <summary>
        /// Получение списка ящиков из массива строк.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="idPart"></param>
        /// <returns></returns>
        public static List<VegetableStorageClass> GetStoragesListFromFileWithContainer(string[] data, string idPart)
        {
            var storageList = new List<VegetableStorageClass>();

            string[] str;
            for(int i = 1; i < data.Length; i++)
            {
                str = data[i].Split(' ');
                if(str[0] == "storage")
                {
                    try
                    {
                        storageList.Add(new VegetableStorageClass(idPart + VegetableStorageClass.NowIDNum, Convert.ToInt32(str[1]), Convert.ToInt32(str[2])));
                    }
                    catch
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }
            return storageList;
        }

    }

}