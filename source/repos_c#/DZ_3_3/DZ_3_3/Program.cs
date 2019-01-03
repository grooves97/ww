using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3.	Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину 32.
             * Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра и наоборот*/

            int spaceSymbol = 0;
            ConsoleKeyInfo symbol;
            do
            {
                Console.WriteLine("Введите символ для конвертации регистра ");
                Console.WriteLine("Для окончания ввода нажм ESC ");
                symbol = Console.ReadKey();
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Введенный символ " + symbol.KeyChar);

                if (char.IsLetter(Convert.ToChar(symbol.KeyChar)))
                {
                    if (char.IsUpper(Convert.ToChar(symbol.KeyChar)))
                    {
                        Console.WriteLine("Конвертируемый символ " + char.ToLower(Convert.ToChar(symbol.KeyChar)));
                    }
                    else
                    {
                        Console.WriteLine("Конвертируемый символ " + char.ToUpper(Convert.ToChar(symbol.KeyChar)));
                    }
                }

                if(Convert.ToInt32(symbol.KeyChar) == 27)
                {
                    break;
                }

            } while (true);
        }
    }
}
