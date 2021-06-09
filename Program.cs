using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Приветствуем вас в банке RoflBank, что вы хотите сделать?");
            
                Client client = new Client();
                client.Info = ShowConsoleInfo;
                client.Error = ShowConsoleError;
            for (; ; )
            {
                Console.WriteLine("1. Открыть счёт");
                Console.WriteLine("2. Внести деньги");
                Console.WriteLine("3. Снять деньги");
                Console.WriteLine("4. Закрыть счёт");
                int answerStart = Convert.ToInt32(Console.ReadLine());
                if (answerStart == 1) client.OpenAccount();
                if (answerStart == 2) client.SetMoney();
                if (answerStart == 3) client.TakeMoney();
                if (answerStart == 4) client.CloseAccount(); 
            }
        }

        static void ShowConsoleInfo(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
        static void ShowConsoleError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
