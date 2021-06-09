using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Client : Person
    {
        public Message Info;
        public Message Error;

        public int Sum { get; set; } = 0;    // сумма на счету

        int Money = 1500;

        bool account = false;

        public void OpenAccount()
        {
            if(account == false)
            {
                Info?.Invoke("Введите имя");
                Name = Convert.ToString(Console.ReadLine());
                Info?.Invoke("Введите Фамилию");
                LastName = Convert.ToString(Console.ReadLine());
                account = true;
                Info?.Invoke("Счёт на имя: '" + Name + " " + LastName + "' Открыт");
            }
            else
            {
                Error?.Invoke("У вас и так открыт счёт");
            }
        }

        public void SetMoney()
        {
            if(account == true)
            {
                if (Money == 0 || Money < 0)
                {
                    Error?.Invoke("У вас нет денег что бы положить на счёт");
                }
                else
                {
                    Info?.Invoke("У вас на счету " + Sum + " Денег");
                    Info?.Invoke("У вас " + Money + " Наличных");
                    Info?.Invoke("Сколько желаете положить?");
                    int answerSetMoney = Convert.ToInt32(Console.ReadLine());
                    if(answerSetMoney > Money)
                    {
                        Error?.Invoke("Вы не можете положить больше чем у вас есть");
                    }
                    else
                    {
                        Sum = Sum + answerSetMoney;
                        Money = Money - answerSetMoney;
                        Info?.Invoke("Вы положили: " + answerSetMoney);
                        Info?.Invoke("У вас на счету теперь: " + Sum);
                        Info?.Invoke("У вас денег теперь: " + Money);
                    }
                }
                
            }
            else
            {
                Error?.Invoke("Вы не можете положить деньги поскольку у вас закрыт счёт");
            }
        }

        public void TakeMoney()
        {
            if(account == true)
            {
                if(Sum == 0 || Sum < 0)
                {
                    Error?.Invoke("Вы не можете снять деньги по скольку их нет на счету");
                }
                else
                {
                    Info?.Invoke("Сколько желаете снять?");
                    int answerTakeMoney = Convert.ToInt32(Console.ReadLine());
                    if(answerTakeMoney > Sum)
                    {
                        Error?.Invoke("Вы не можете снять больше чем есть на счету");
                    }
                    else
                    {
                        Sum = Sum - answerTakeMoney;
                        Money = Money + answerTakeMoney;
                        Info?.Invoke("Вы Сняли: " + answerTakeMoney);
                        Info?.Invoke("У вас на счету теперь: " + Sum);
                        Info?.Invoke("У вас денег теперь: " + Money);
                    }
                }
            }
            else
            {
                Error?.Invoke("Вы не можете снять деньги поскольку у вас закрыт счёт");
            }
        }

        public void CloseAccount()
        {
            if(account == true)
            {
                account = false;
                Info?.Invoke("Вы закрыли счёт");
            }
            else
            {
                Error?.Invoke("Счёт и так закрыт");
            }
        }
    }
}
