using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userSymbol;
            int numberSymbolName;
            int additionalSymbol = 2;
            int numberSymbolString;
            string someString;

            Console.WriteLine("Здравствуйте, сейчас мы вместе создадим красивую картинку.");
            Console.Write("Введите ваше имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите любой символ: ");
            userSymbol = Console.ReadLine();
            numberSymbolName = userName.Length;
            numberSymbolString = numberSymbolName + additionalSymbol;

            while (numberSymbolString > 0)
            {
                Console.Write(userSymbol);
                numberSymbolString --;
            }

            Console.WriteLine();
            Console.WriteLine(userSymbol + userName + userSymbol);
            numberSymbolString = numberSymbolName + additionalSymbol;

            while (numberSymbolString > 0)
            {
                Console.Write(userSymbol);
                (numberSymbolString) --;
            }

            Console.WriteLine();
        }
    }
}
