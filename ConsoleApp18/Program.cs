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
            char userSymbol;
            string middleString;

            Console.WriteLine("Здравствуйте, сейчас мы вместе создадим красивую картинку.");
            Console.WriteLine("Введите ваше имя: ");
            userName = Console.ReadLine();
            Console.WriteLine("Введите любой символ: ");
            userSymbol = Console.ReadKey(true).KeyChar;
            middleString = userSymbol + userName + userSymbol;

            for (int i = 0; i < middleString.Length; i++)

            Console.Write(userSymbol);
            Console.WriteLine();

            Console.WriteLine(middleString);

            for (int i = 0; i < middleString.Length; i++)

            Console.Write(userSymbol);
            Console.WriteLine();
        }
    }
}
