using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace warehouse
{
    /// <summary>
    /// Класс, описывающий контейнер.
    /// </summary>
    internal sealed class ContainerClass
    {
        /// <summary>
        /// id объекта класса контейнер.
        /// </summary>
        private readonly string id;
        /// <summary>
        /// Максимальный вес содержимого контейнера (сумма масс всех ящиков в контейнере).
        /// </summary>
        private int maxWeight;
        Random rnd;
        // Максимальное количество ящиков в контейнере.
        private int numOfStorages;
        // Список ящиков в контейнере.
        private List<VegetableStorageClass> listOfStorages;
        // Степень повреждения контейнера.
        private double degreeOfDamage;

        /// <summary>
        /// Возвращает id объекта класса контейнер.
        /// </summary>
        public string ID
        {
            get { return id; }
        }
        
        private static int nowIDNum;
        
        static ContainerClass()
        {
            nowIDNum = -1;
        }

        /// <summary>
        /// Возвращает строку, которая нужна для получения нового id для нового объекта.
        /// </summary>
        public static string NowIDNum 
        {
            get
            {
                nowIDNum++;
                return '.' + Convert.ToString(nowIDNum);
            }
           
        }

        /// <summary>
        /// Создание контейнера, объявление количества ящиков в контейнере, добавление списка ящиков(закидываем ящики в контейнер сразу).
        /// </summary>
        /// <param name="id">
        /// ID нового объекта(контейнера).
        /// </param>
        /// <param name="numOfStorages">
        /// Максимальное количество ящиков в контейнере.
        /// </param>
        /// <param name="maxWeight">
        /// Максимальный вес, который может хранить контейнер.
        /// </param>
        /// <param name="storagesList">
        /// Список ящиков.
        /// </param>
        public ContainerClass(string id, int numOfStorages, int maxWeight, List<VegetableStorageClass> storagesList)
        {
            this.id = id;
            rnd = new Random();
            this.maxWeight = maxWeight;
            this.numOfStorages = Math.Abs(numOfStorages);
            this.listOfStorages = new List<VegetableStorageClass>();
            int firstWeight = 0;
            for(int i = 0; i < storagesList.Count; i++)
            {
                if(firstWeight + storagesList[i].Weight <= maxWeight)
                {
                    if(this.numOfStorages > listOfStorages.Count)
                    {
                        try
                        {
                            listOfStorages.Add(storagesList[i]);
                            firstWeight += storagesList[i].Weight;
                            StorageWasAddedMessage(storagesList[i].ID);
                        }
                        catch(Exception)
                        {
                            StorageWasntAddedduetoException(storagesList[i].ID);
                        }
                    }
                    else
                    {
                        StorageWasntAddedDuetoPlace(storagesList[i].ID);
                    } 
                }
                else
                {
                    StorageWasntAddedDuetoOverweight(storagesList[i].ID);
                }
            }
            degreeOfDamage = Convert.ToDouble(rnd.Next(0, 5)) / 10;
        }

        /// <summary>
        /// Метод добавления нового ящика в контейнер.
        /// </summary>
        /// <param name="storage">
        /// Ящик, который вы хотите добавить в контейнер.
        /// </param>
        public void AddNewStorage(VegetableStorageClass storage)          
        {
            try
            {
                if (numOfStorages > listOfStorages.Count)
                {
                    if (GetStoragesWeight() + storage.Weight <= maxWeight)
                    {
                        try
                        {
                            listOfStorages.Add(storage);
                            StorageWasAddedMessage(storage.ID);
                        }
                        catch
                        {
                            StorageWasntAddedduetoException(storage.ID);
                        }
                    }
                    else
                    {
                        StorageWasntAddedDuetoOverweight(storage.ID);
                    }
                }
                else
                {
                    StorageWasntAddedDuetoPlace(storage.ID);
                }
            }
            catch
            {
                StorageWasntAddedduetoException(storage.ID);
            }
        }

        /// <summary>
        /// Метод получения веса содержимого контейнера.
        /// </summary>
        /// <returns></returns>
        private int GetStoragesWeight()
        {
            int sum = 0;
            foreach(var t in listOfStorages)
            {
                sum += t.Weight;
            }
            return sum;
        }

        /// <summary>
        /// Создание пустого контейнера с фиксированным количеством ячеек для ящиков.
        /// </summary>
        /// <param name="id">
        /// ID нового объекта(контейнера).
        /// </param>
        /// <param name="numOfStorages">
        /// Максимальное количество ящиков в контейнере.
        /// </param>
        public ContainerClass(string id, int numOfStorages)
        {
            this.id = id;
            rnd = new Random();
            maxWeight = rnd.Next(50, 1000);
            this.numOfStorages = Math.Abs(numOfStorages);
            this.listOfStorages = new List<VegetableStorageClass>();
            degreeOfDamage = Convert.ToDouble(rnd.Next(0, 5)) / 10;
        }

        /// <summary>
        /// Cообщение о том, что ящик не был добавлен в контейнер из-за непредвиденной ошибки. 
        /// </summary>
        /// <param name="storageID"></param>
        private void StorageWasntAddedduetoException(string storageID)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ящик с ID: {storageID} не был добавлен в контейнер с ID: {this.id} из-за непредвиденной ошибки.");
            Console.ResetColor();
        }

        /// <summary>
        /// Сообщение о том, что ящик не был добавлен в контейнер, потому что ящик вызывает перевес.
        /// </summary>
        /// <param name="storageID"></param>
        private void StorageWasntAddedDuetoOverweight(string storageID)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ящик с ID: {storageID} не будет добавлен в контейнер с ID: {this.id}, так как он вызывает перевес");
            Console.ResetColor();
        }

        /// <summary>
        /// Сообщение о том, что ящик не был добавлен в контейнер из-за отсутствия свободного места.
        /// </summary>
        /// <param name="storageID"></param>
        private void StorageWasntAddedDuetoPlace(string storageID)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Ящик с ID: {storageID} не будет добавлен в контейнер с ID: {this.id}, так как в нем закончилось место");
            Console.ResetColor();
        }

        /// <summary>
        /// Сообщение о том, что ящик был добавлен в контенер.
        /// </summary>
        /// <param name="storageID"></param>
        private void StorageWasAddedMessage(string storageID)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Ящик с ID: {storageID} был добавлен в контейнер с ID: {this.id}");
            Console.ResetColor();
        }

        /// <summary>
        /// Вывод информации о контейнере и о его содержимом.
        /// </summary>
        /// <param name="indent" >
        /// Отступ от левого края.
        /// </param>
        public void PrintInfo(int indent)
        {
            string idStr = $"- контейнер ID: {id};";
            string maxWeightStr = $"  максимальный вес содержимого котейнера: {maxWeight};";
            string numOfStoragesStr = $"  количество ящиков, которое вмещает контейнер: {numOfStorages};";
            string degreeOfDamageStr = $"  степень повреждения контейнера: {degreeOfDamage}";
            string fullprice = $"  Полная стоимость содержимого: {GetContainerPrice()}";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(idStr.PadLeft(indent + idStr.Length, ' '));
            Console.ResetColor();
            Console.Write( maxWeightStr.PadLeft(indent + maxWeightStr.Length, ' ') + '\n' + numOfStoragesStr.PadLeft(indent + numOfStoragesStr.Length, ' ') + '\n' + degreeOfDamageStr.PadLeft(indent + degreeOfDamageStr.Length, ' ') + '\n' + fullprice.PadLeft(indent + fullprice.Length) + '\n');
            for(int i = 0; i < listOfStorages.Count; i++)
            {
                listOfStorages[i].PrintInfo(indent + 12);
            }
        }

        /// <summary>
        /// Подсчет цены контейнера.
        /// </summary>
        /// <returns></returns>
        public double GetContainerPrice()
        {
            double priceOfStorsges = 0;
            for(int i = 0; i < listOfStorages.Count; i++)
            {
                priceOfStorsges += listOfStorages[i].GetStoragePrice();
            }
            priceOfStorsges = priceOfStorsges - priceOfStorsges * degreeOfDamage;
            return priceOfStorsges;
        }

        public void SaveContainerInfo(string path, int indent)
        {
            try
            {
                string idStr = $"- контейнер ID: {id}; \n";
                string maxWeightStr = $"  максимальный вес содержимого котейнера: {maxWeight};";
                string numOfStoragesStr = $"  количество ящиков, которое вмещает контейнер: {numOfStorages};";
                string degreeOfDamageStr = $"  степень повреждения контейнера: {degreeOfDamage}";
                string fullprice = $"  Полная стоимость содержимого: {GetContainerPrice()}";
                File.AppendAllText(path, idStr.PadLeft(indent + idStr.Length, ' '));
                File.AppendAllText(path, maxWeightStr.PadLeft(indent + maxWeightStr.Length, ' ') + '\n' + numOfStoragesStr.PadLeft(indent + numOfStoragesStr.Length, ' ') + '\n' + degreeOfDamageStr.PadLeft(indent + degreeOfDamageStr.Length, ' ') + '\n' + fullprice.PadLeft(indent + fullprice.Length) + '\n');
                for (int i = 0; i < listOfStorages.Count; i++)
                {
                    listOfStorages[i].SaveStorageInfo(path, indent + 12);
                }
                InfoWasSaved();
            }
            catch
            {
                InfoWasntSaved();
            }
        }

        /// <summary>
        /// Сообщение о том, что информация о контейнере была сохранена.
        /// </summary>
        private void InfoWasSaved()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Информация о контейнере с ID {id} была сохранена в файл.");
            Console.ResetColor();
        }

        /// <summary>
        ///  Сообщение о том, что информация о контейнере не сохранена.
        /// </summary>
        private void InfoWasntSaved()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Не получилось сохранить информацию о контейнере с ID {id} в файл.");
            Console.ResetColor();
        }

    }
}
