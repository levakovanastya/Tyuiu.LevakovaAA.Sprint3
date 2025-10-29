using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.LevakovaAA.Sprint3.Task7.V11.Lib;
namespace Tyuiu.LevakovaAA.Sprint3.Task7.V11
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Левакова А.А. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Обработка целочисленной информации                                      *");
            Console.WriteLine("* Задание 7                                                               *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнила: Левакова А.А. | СМАРТб-25-1                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Написать программу, которая выводит таблицу значений функции f(x)       *");
            Console.WriteLine("* на заданном диапазоне [-5, 5] с шагом 1. Произвести проверку деления    *");
            Console.WriteLine("* на 0. При делении на ноль вернуть значение 0. Значения занести в массив *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+----------+-----------+");
            Console.WriteLine("|    X     |    f(x)   |");
            Console.WriteLine("+----------+-----------+");
            for (int i  = 0; i < len; i++)
            {
                Console.WriteLine("|{0,5:d}     |   {1, 5:f2}   |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+-----------+");
            Console.ReadKey();
        }
    }
}
