using Tyuiu.PlehanovaKA.Sprint1.Task1.V25.Lib;
namespace Tyuiu.PlehanovaKA.Sprint1.Task1.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнила: Плеханова К. А. | СМАРТб-26-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: организация ввода/вывода в консольных приложениях                 *");
            Console.WriteLine("* Задание#1                                                               *");
            Console.WriteLine("* Вариант#25                                                              *");
            Console.WriteLine("* Выполнила: Плеханова Ксения Анатольевна | СМАРТб-26-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходнные данные,*");
            Console.WriteLine("* Вычисляет результат по формуле (x*y)/(1+x) и печатает его на экран      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double x, y;
            Console.WriteLine("Введите значение X:");
            x=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение Y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.Calculate(x, y));
            Console.ReadLine();
        }
    }
}
