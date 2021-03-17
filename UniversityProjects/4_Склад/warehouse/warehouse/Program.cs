using System;

namespace warehouse
{
    partial class Program
    {
        // склад:                       D:\testWarehouseFiles\newWarehouse.txt
        // контейнер:                   D:\testWarehouseFiles\newContainer.txt
        // команды:                     D:\testWarehouseFiles\newCommands.txt
        

        static void Main(string[] args)
        {
            WarehouseClass usersWarehouse;
            Console.WriteLine("Давайте создадим склад. \nКак вы хотите ввести данные? ");
            do
            {
                HowToMakeNewWarehouseCommands();
            }
            while (GetNewWarehouseBase(InputClass.CommandNumInput(), out usersWarehouse) == false);
            
            string exit = "rusme";
            do
            {
                try
                {
                    PrintContainerCommands();
                    FirstOperationsBase(InputClass.CommandNumInput(), usersWarehouse);
                }
                finally
                {
                    Console.WriteLine("Чтобы выйти, введите exit ");
                    exit = Console.ReadLine();
                    Console.Clear();
                }
            }
            while (exit != "exit");
            Console.WriteLine("До свидания");
        }
    }
}
