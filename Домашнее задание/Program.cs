using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашнее_задание
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЛЕКЦИЯ 1 ДОМАШНЕЕ ЗАДАНИЕ
            //console.writeline("введите свое имя.");
            //string name;
            //name = console.readline();
            //console.writeline($"привет,  {name} ! сегодня { datetime.now }");







            //ЛЕКЦИЯ 2 ДОМАШНЕЕ ЗАДАНИЕ
            //Запросить у пользователя минимальную и максимальную температуру за сутки и вывести среднесуточную температуру.
            /*Console.WriteLine("Введите  максимальную температуру.");
            double tempMax = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите минимальную температуру.");
            double tempMin = double.Parse(Console.ReadLine());
            double Average = (tempMax + tempMin) / 2;
            Console.WriteLine($"Средняя температура: {Average} градусов. ");



            //Запросить у пользователя порядковый номер текущего месяца и вывести его название.
            Console.WriteLine("Введите  номер месяца от 1 до 12.");
            int mounth = int.Parse(Console.ReadLine());
            switch (mounth)
            {
                case 1:
                    Console.WriteLine("Январь.");
                    break;
                case 2:
                    Console.WriteLine("Февраль.");
                    break;
                case 3:
                    Console.WriteLine("Март.");
                    break;
                case 4:
                    Console.WriteLine("Апрель.");
                    break;
                case 5:
                    Console.WriteLine("Май.");
                    break;
                case 6:
                    Console.WriteLine("Июнь");
                    break;
                case 7:
                    Console.WriteLine("Июль.");
                    break;
                case 8:
                    Console.WriteLine("Август.");
                    break;
                case 9:
                    Console.WriteLine("Сентябрь.");
                    break;
                case 10:
                    Console.WriteLine("Октябрь.");
                    break;
                case 11:
                    Console.WriteLine("Ноябрь.");
                    break;
                case 12:
                    Console.WriteLine("Декабрь.");
                    break;
                default:
                    Console.WriteLine("Введите число от 1 до 12.");
                    break;
            }


            //Определить, является ли введённое пользователем число чётным.
            Console.WriteLine("Введите число.");
            double value;
            value = double.Parse(Console.ReadLine());
            double result = value % 2;
            switch (result)
            {
                case 0:
                    Console.WriteLine("Число  четное.");
                    break;
                default:
                    Console.WriteLine("Число не четное.");
                    break;
            }

             // Вариант 2
            {
             Console.Writeline("Введите целое число: ");
            string inputValue = Console.ReadLine();
            bool isValid = int.TryParse(inputValue, out int number);
             if (!isValid)
             {
             Console.WriteLine("Введено некорректное число.");
             Console.ReadKey();
            return;
             }
            if ((number % 2) == 0)
             {
             Console.WriteLine($"{number} - вы ввели  чётное число.");
             }
             else
            {
             Console.WriteLine($"{number} - это число не является чётным числом.");
            }
             Console.ReadKey();
            }


            //Для полного закрепления понимания простых типов найдите любой чек, либо фотографию этого чека в интернете и схематично нарисуйте его в консоли, 
            //только за место динамических, по вашему мнению, данных(это может быть дата, название магазина, сумма покупок) подставляйте переменные,
            //которые были заранее заготовлены до вывода на консоль.
            double Count = 500.34;
            int quantity = 1;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(" ________________________________________");
            Console.WriteLine("|              OOO'Ромашка'              |");
            Console.WriteLine("|             ИНН:  45632455             |");
            Console.WriteLine("|  Россия, г.Москва, ул. Профсоюзная 42  |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|          КАССОВЫЙ ЧЕК/ПРИХОД           |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("| Доставка цветов                 " + quantity + " шт   |");
            Console.WriteLine("| Услуга   " + Count + "                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                      " + DateTime.Now + "|");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|               @}-->--                  |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|                                        |");
            Console.WriteLine("|_________СПАСИБО ЗА ПОКУПКУ!____________|");





            //Если пользователь указал месяц из зимнего периода, а средняя температура > 0, вывести сообщение «Дождливая зима».

           Console.Write("Введите порядковый номер месяца: ");
           int number;
          do
           {
                number = Convert.ToInt32(Console.ReadLine());
              if (number < 1 || number > 12)
               {
                   Console.Write("Ошибка. Введите число от 1 до 12: ");
               }
           } while (number < 1 || number > 12);

            Console.WriteLine("Введите среднюю температуру.");
            int temp = int.Parse(Console.ReadLine());


            switch (number)
            {
                case 12:
                case 1:
                case 2:
                    if (temp > 0)
                    {
                        Console.WriteLine("Дождливая зима.");
                        return;
                    }
                    else
                        Console.WriteLine("Это зимний месяц.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень.");
                    break;
                default:
                    Console.WriteLine("Введите число месяца  от 1 до 12.");
                    break;
            }
        }



        
           
                  //ЛЕКЦИЯ 3 ДОМАШНЕЕ ЗАДАНИЕ

             //Написать программу, выводящую элементы двухмерного массива по диагонали.
            //Вариант 1
            int[,] array = new int[5, 5];
            array[0, 0] = 1;
            array[1, 1] = 1;
            array[2, 2] = 1;
            array[3, 3] = 1;
            array[4, 4] = 1;
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
              //Вариант 2
            int[,] array = new int[5, 5];
             array[2, 2] = 1;
            for (int i = 0; i < array.GetLength(0); i++)
             {
                for (int j = 0; j < array.GetLength(1); j++)
              {
                   if (i == j)
                   {
                       array[i, j] = 1;
                   }
                   Console.Write($"{array[i,j]}");
                }
               Console.WriteLine();
            }

            //Написать программу — телефонный справочник — создать двумерный массив 5 * 2, хранящий список телефонных контактов: первый элемент хранит имя контакта,
                // второй — номер телефона/ e - mail.
            string[,] myphonebook = new string[,]
            {
                {"Griboedov", "+79158622325, Griboedov@mail.ru"},
                {"Pushkin", "+79158622765, Pushkin@mail.ru"},
                {"Tolstoi", "+79708622775, Tolstoi@mail.ru"},
                {"Goncharov", "+79998622377, Goncharov@mail.ru"},
                {"Ostrovskii", "+79778622111, Ostrovskii@mail.ru"}
            };
            for (int i = 0; i < myphonebook.GetLength(0); i++)
            {
                for (int j = 0; j < myphonebook.GetLength(1); j++)
                {

                    Console.Write($"{myphonebook[i, j]} ");
                }
                System.Console.WriteLine();
            }




            //Написать программу, выводящую введененную пользователем строку в обратном порядке. Hello
            char[] hello = { 'h', 'e', 'l', 'l', 'o' };
            for (int x = hello.Length -1; x >=0; x--) 
            {

                   Console.Write($"{hello[x]}");

            }

            

            //Морской бой

            char[,] array = new char[10, 10];

            array[0, 0] = '0';
            array[0, 1] = '1';
            array[0, 2] = '2';
            array[0, 3] = '3';
            array[0, 4] = '4';
            array[0, 5] = '5';
            array[0, 6] = '6';
            array[0, 7] = '7';
            array[0, 8] = '8';
            array[0, 9] = '9';

            array[1, 0] = '1';
            array[2, 0] = '2';
            array[3, 0] = '3';
            array[4, 0] = '4';
            array[5, 0] = '5';
            array[6, 0] = '6';
            array[7, 0] = '7';
            array[8, 0] = '8';
            array[9, 0] = '9';

            array[4, 4] = 'Х'; //корабль 1
            array[5, 4] = 'Х';
            array[6, 4] = 'Х';
            array[7, 4] = 'Х';
            array[7, 8] = 'Х'; //корабль 2
            array[8, 8] = 'Х';


            //не знаю, как пустые клетки отметить нулем ((

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();*/
        }
    }
}




















































