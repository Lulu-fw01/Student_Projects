using System;
using System.Collections.Generic;
using System.IO;

namespace warehouse
{
    /// <summary>
    /// Класс, описывающий склад.
    /// </summary>
    internal sealed class WarehouseClass
    {
        // ID склада.
        private readonly string id;
        // Количество контейнеров на складе.
        private int numOfContainers;
        // Плата за хранение контейнера.
        private int priceForPlace;

        /// <summary>
        /// Лист с контейнерами.
        /// </summary>
        List<ContainerClass> listOfContainers;
        
        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="numOfContainers">
        /// Максимальное количество контейнеров на складе.
        /// </param>
        /// <param name="priceForPlace">
        /// Цена за место на складе.
        /// </param>
        protected WarehouseClass(int numOfContainers, int priceForPlace)
        {
            id = "00";
            this.numOfContainers = numOfContainers;
            this.priceForPlace = priceForPlace;
            listOfContainers = new List<ContainerClass>();
        }

        /// <summary>
        /// ID склада.
        /// </summary>
        public string ID 
        {
            get { return id; } 
        }

        // oneWareHouse нужен для singletone.
        private static WarehouseClass oneWareHouse;
        private static object syncRoot = new Object();
        /// <summary>
        /// Singletone. Не позволяет создать еще один склад. Тут он реализован просто так. Вполне можно было бы обойтись и без него.
        /// </summary>
        /// <param name="numOfContainers">
        /// Максимальное количеств контейнеров на складе.
        /// </param>
        /// <param name="priceForPlace">
        /// Цена за место.
        /// </param>
        /// <returns></returns>
        public static WarehouseClass GetWarehous(int numOfContainers, int priceForPlace)
        {
            if (oneWareHouse == null)
            {
                lock (syncRoot)
                {
                    if (oneWareHouse == null)
                        oneWareHouse = new WarehouseClass(numOfContainers, priceForPlace);
                }
            }
            return oneWareHouse;
        }
    

        /// <summary>
        /// Метод добавления нового контейнера.
        /// </summary>
        /// <param name="newContainer">
        /// Контейнер, который надо добавить.
        /// </param>
        public void AddContainer(ContainerClass newContainer)
        {  
            if(newContainer.GetContainerPrice() >= priceForPlace)
            {
                if (numOfContainers > listOfContainers.Count)
                {
                    try
                    {
                        listOfContainers.Add(newContainer);
                        ContainerWasAddedMessage(newContainer.ID);
                    }
                    catch(Exception)
                    {
                        ContainerWasntAddedDuetoExceptionMessage(newContainer.ID);
                    }
                }
                else
                {
                    try
                    {
                        ContainerWasDeletedDueToPlace(listOfContainers[0].ID);
                        listOfContainers.RemoveAt(0);
                        listOfContainers.Add(newContainer);
                        ContainerWasAddedMessage(newContainer.ID);
                    }
                    catch 
                    {
                        ContainerWasntAddedDuetoExceptionMessage(newContainer.ID);
                    }
                }
            }
            else
            {
                ContainerWasntAddedDueToHisPriceMessage(newContainer.ID);
            }
        }

        /// <summary>
        /// Удаление контейнера.
        /// </summary>
        /// <param name="containerID">
        /// ID контейнера, который надо удалить.
        /// </param>
        public void RemoveContainerAt(string containerID)
        {
            try
            {
                bool isDeleted = false;
                for(int i = 0; i < listOfContainers.Count; i++)
                {
                    if(listOfContainers[i].ID == containerID)
                    {
                        listOfContainers.RemoveAt(i);
                        isDeleted = true;
                        break;
                    }
                }
                if(isDeleted == true)
                {
                    ContainerWasDeletedMessage(containerID);
                }
                else
                {
                    ContainerWasntDeletedDueToItsIDMessage(containerID);
                }
            }
            catch
            {
                ContainerWasntDeletedDuetoExceptionMessage(containerID);
            }
        }

        /// <summary>
        /// Контейнер был удален, потому что требуется свободное место.
        /// </summary>
        /// <param name="containerID"></param>
        private void ContainerWasDeletedDueToPlace(string containerID)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Контейнер с ID: {containerID} был удален со склада с ID: {id} так как склад заполнен, и требуется свободное место.\n");
            Console.ResetColor();
        }

        /// <summary>
        /// Сообщение о том, что контейнер не был удален, потому что такого ID не существует.
        /// </summary>
        /// <param name="containerID"></param>
        private void ContainerWasntDeletedDueToItsIDMessage(string containerID)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Контейнер с ID: {containerID} не был удален со склада с ID: {id} так как контейнера с данным ID не существует.\n");
            Console.ResetColor();
        }

        /// <summary>
        /// Сообщение о том, что контейнер был успешно удален.
        /// </summary>
        /// <param name="containerID"></param>
        private void ContainerWasDeletedMessage(string containerID)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Контейнер с ID: {containerID} был удален со склада с ID: {id} . \n");
            Console.ResetColor();
        }

        /// <summary>
        /// Сообщение о том, что контейнер не был удален из-за непредвиденной ошибки.
        /// </summary>
        /// <param name="containerID"></param>
        private void ContainerWasntDeletedDuetoExceptionMessage(string containerID)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Контейнер с ID: {containerID} не был удален со склада с ID: {id} из-за непредвиденной ошибки \n");
            Console.ResetColor();
        }

        /// <summary>
        /// Сообщение о том, что контейнер не был добавлен из-за непредвиденной ошибки.
        /// </summary>
        /// <param name="containerID"></param>
        private void ContainerWasntAddedDuetoExceptionMessage(string containerID)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Контейнер с ID: {containerID} не был добавлен на склад с ID: {id} из-за непредвиденной ошибки \n");
            Console.ResetColor();
        }

        /// <summary>
        /// Сообщение о том, что контейнер не был добавлен из-за его стоимости.
        /// </summary>
        /// <param name="containerID"></param>
        private void ContainerWasntAddedDueToHisPriceMessage(string containerID)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Суммарная стоимость содержимого контейнера не превосходит стоимости места на складе c ID: {id} .\n Контейнер c ID: {containerID} не будет добавлен \n");
            Console.ResetColor();
        }

        /// <summary>
        /// Сообщение о том, что контейнер был добавлен на склад.
        /// </summary>
        /// <param name="containerID"></param>
        private void ContainerWasAddedMessage(string containerID)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Контейнер с ID {containerID} был добавлен на склад с ID {id} \n");
            Console.ResetColor();
        }

        /// <summary>
        /// Вывод информации о складе.
        /// </summary>
        private void WarehouseInfoMessage()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Склад ID: {id}; Вместимость склада: {numOfContainers}; Цена за место: {priceForPlace} \n");
            Console.ResetColor();
        }

        /// <summary>
        /// Сообщение о том, что контейнер не был добавлен на склад, так как на складе больше нет места.
        /// </summary>
        /// <param name="containerID"></param>
        private void ContainerWasntAddedDuetoPlaceMessage(string containerID)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Место на складе с ID: {id} закончилось, контейнер с ID: {containerID} не может быть добавлен на этот склад \n");
            Console.ResetColor();
        }

        /// <summary>
        /// Вывод информации о складе и о всех контейнерах.
        /// </summary>
        public void PrintInfo()
        {
            try
            {
                WarehouseInfoMessage();
                for (int i = 0; i < listOfContainers.Count; i++)
                {
                    listOfContainers[i].PrintInfo(12);
                }
            }
            catch
            {
                Console.WriteLine("Не получилось вывести информацию о складе.");
            }
        }

        /// <summary>
        /// Удаление всех контейнеров со склада.
        /// </summary>
        public void ClearWarehouse()
        {
            try
            {
                listOfContainers.Clear();
                WarehouseWasClearedMessage();
            }
            catch
            {
                WarehouseWasntClearedMessage();
            }
           
        }

        /// <summary>
        /// Сообщение о том, что склад был очищен.
        /// </summary>
        private void WarehouseWasClearedMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Склад с ID {id} был очищен, все контейнеры ушли в небытие. \n");
            Console.ResetColor();
        }

        /// <summary>
        /// Сообщение о том, что склад не был очищен
        /// </summary>
        private void WarehouseWasntClearedMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Склад с ID {id} не был очищен из-за неизвестной ошибки. \n");
            Console.ResetColor();
        }

        /// <summary>
        /// Сохранение информации о складе в файл.
        /// </summary>
        /// <param name="path"></param>
        public void SaveWarehouseInfo(string path)
        {
            try
            {
                File.WriteAllText(path, $"Склад ID: {id}; Вместимость склада: {numOfContainers}; Цена за место: {priceForPlace} \n");
                for (int i = 0; i < listOfContainers.Count; i++)
                {
                    listOfContainers[i].SaveContainerInfo(path, 12);
                }
                InfoWasSaved();
            }
            catch
            {
                InfoWasntSaved();
            }
        }

        /// <summary>
        /// Сообщение о том, что информация о складе была сохранена.
        /// </summary>
        private void InfoWasSaved()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Информация о складе с ID {id} была сохранена в файл.");
            Console.ResetColor();
        }

        /// <summary>
        ///  Сообщение о том, что информация о складе не сохранена
        /// </summary>
        private void InfoWasntSaved()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Не получилось сохранить информацию о складе с ID {id} в файл.");
            Console.ResetColor();
        }

    }
}
