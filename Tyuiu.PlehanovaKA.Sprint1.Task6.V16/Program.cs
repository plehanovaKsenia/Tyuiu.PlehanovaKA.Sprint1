using Tyuiu.PlehanovaKA.Sprint1.Task6.V16.Lib;
namespace Tyuiu.PlehanovaKA.Sprint1.Task6.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Плеханова К. А. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание#6                                                               *");
            Console.WriteLine("* Вариант#16                                                              *");
            Console.WriteLine("* Выполнила: Плеханова Ксения Анатольевна | СМАРТб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу:                                                     *");
            Console.WriteLine("* Пользователь вводит текст.                                              *");
            Console.WriteLine("* Проверить, что в строке есть восклицание (!) и вопрос (?).              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string s;
            Console.WriteLine("Введите строку:");
            s = Convert.ToString(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (ds.CheckSpecSymbols(s) == true)
            {
                Console.WriteLine("В строке есть восклицание (!) и вопрос (?). ");
            }
            else
            {
                Console.WriteLine("В строке нет восклицания (!) и вопроса (?). ");
            }
        }
    }
}
