using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа делит 100 на введённое вами число.");

            try
            {
                Console.Write("Введите число: ");
                int userInput = Convert.ToInt32(Console.ReadLine());

                double result = 100.0 / userInput;
                Console.WriteLine($"Результат: 100 / {userInput} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено некорректное число. Пожалуйста, попробуйте еще раз.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: деление на ноль не допускается.");
            }
            catch (Exception)
            {
                Console.WriteLine("Произошла непредвиденная ошибка. Пожалуйста, попробуйте снова.");
            }
            Console.ReadLine();
        }
    }
}
