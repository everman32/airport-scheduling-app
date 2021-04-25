using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            int port;
            Console.Write("Введите порт для прослушивания сервером: ");
            for (; ; )
            {
                try
                {
                    port = Convert.ToInt32(Console.ReadLine());
                    if (port > 0 && port < 65535)
                    {
                    break;
                    }
                    else
                    {
                        Console.WriteLine("Порт должен быть в диапазоне от 0 до 65535");
                    }
                }
                catch
                {
                    Console.WriteLine("Порт должен быть целым положительным числом");
                }
            }
            Server.Run(port);
        }
    }
}
