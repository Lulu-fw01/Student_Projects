using System;

namespace MatrixCalc
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string exit = "";
            do
            {
                Console.Clear();
                OperationsMessage();
                int commandnum;
                InputCommandNum(out commandnum);
                CommandBase(commandnum);
 
                Console.WriteLine("для выхода введите exit. Для продолжения введите любой символ");
                exit = Console.ReadLine();
            }
            while (exit != "exit");

        }
    }
}


/*/
 using System;

namespace MatrixCalc
{
    partial class Program
    {
        
    }
}
/*/