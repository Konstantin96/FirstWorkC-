using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                task12();          
        }
        static void task1()
        {
            /*1. Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка.
              Программа должна сосчитать количество введенных пользователем пробелов*/
            string str = "";
            int i = 0;
            do
            {
                str += Console.ReadLine();
                i++;
                Console.Clear();
            } while (!str.Contains ('.'));

            int countSpace = str.Count(w => w == ' ');

            int b = 0;
            for (int k = 0; k < str.Length; k++)
            {
                if (str[k] == ' ')
                    b++;
            }
            Console.WriteLine("Кол-во символов : " + i);
            Console.WriteLine("Кол-во space : " + countSpace);
            Console.WriteLine("Кол-во space : " + b);
        }

        static void task2()
        {
            /*2. Ввести с клавиатуры номер трамвайного билета (6-значное число) и 
             * проверить является ли данный билет счастливым (если на билете напечатано шестизначное число,
             *  и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым). */
            string ticket = Console.ReadLine();
            if (ticket.Length == 6)
            {
                //сумма первых трех чисел
                int sum1 = ticket[0]+ ticket[1] + ticket[2] ;
                int sum2 = ticket[3] + ticket[4] + ticket[5];
                if (sum1 == sum2)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Билет счастливый");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Билет не счастливый");
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Длина билета не правильная!");
            }
        }

        static void task3()
        {
            /*4.	Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; 
              каждое число должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное 
               его значению. Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод: 
                    3 3 3 
                    4 4 4 4 
                    5 5 5 5 5 
                    6 6 6 6 6 6 
                    7 7 7 7 7 7 7 */
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }

        static void task4()
        {
            /*5	Дано целое число N (> 0), найти число, полученное при прочтении числа N справа налево. 
             * Например, если было введено число 345, то программа должна вывести число 543*/
            Console.Write("Введите n: ");
            string N = Console.ReadLine();
            if (Int32.Parse(N) > 0)
            {
                for (int i = N.Length; i >0 ; i--)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR N>=0");
            }
        }

        static void task5()
        {
            /*6.	Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними*/
            Console.Write("Введeнные 3 числа: ");
            Random rnd=new Random();
            string str;
            str=rnd.Next(1,30)+" "+ rnd.Next(2,20)+" "+ rnd.Next(3,40);
            Console.WriteLine(str);
        }

        static void task6()
        {
            /*8.	Дано расстояние в сантиметрах. Найти число полных метров в нем*/
            Console.Write("Введите кол-во сантиметров: ");
            double rast = int.Parse(Console.ReadLine());
            Console.WriteLine("Метров: "+rast / 100);
        }

        static void task7()
        {
            /*11.	Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
                a.	А или В; 
                b.	А и В; 
                c.	В или С*/
            bool a, b, c;
            a = bool.Parse(Console.ReadLine());
            b = bool.Parse(Console.ReadLine());
            c = bool.Parse(Console.ReadLine());
            if (a || b)
            {
                Console.WriteLine("A");
            }
            else if (a && b)
            {
                Console.WriteLine("B");
            }
            else if (b || c)
            {
                Console.WriteLine("C");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }   

        static void task8()
        {
            /*Напечатать "столбиком": 
            a.	все целые числа от 20 до 35;
            b.	квадраты всех целых чисел от 10 до b (значение b вводится с клавиатуры; b > 10);
            c.	третьи степени всех целых чисел от a до 50 (значение a вводится с клавиатуры; a < 50);
            d.	все целые числа от a до b (значения a и b вводятся с клавиатуры; b > a).*/
            Console.Write("a. ");
            for (int i = 20; i <= 35; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.Write("b. Введите b=");
            int b = Int32.Parse(Console.ReadLine());
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine("{0:##,#}",Math.Sqrt(i));
            }
            Console.Write("c. Введите a=");
            int c = Int32.Parse(Console.ReadLine());
            for (int i = c; i <= 50; i++)
            {
                Console.WriteLine( Math.Pow(i,3));
            }
        }

        static void task9()
        {
            /*16.	вычисления значения функции y= 7x2-3x+6 при любом значении x;*/
            Random x = new Random();
            Console.WriteLine("X=" + x.Next(1,5));
            Console.WriteLine("y=" + (7 * x.Next(1, 5) * 2 -3* x.Next(1, 5) + 6));
        }

        static void task10()
        {
            /*31.	Известны два расстояния: одно в километрах, другое — в футах ( 1 фут 0,305 м ). Какое из расстояний меньше?*/
            double a, b;
            Console.Write("Enter kil: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fut: ");
            b = Int32.Parse(Console.ReadLine());
            a = a/1000 * 0.305;
            if (a > b)
            {
                Console.WriteLine("a>b");
            }
            else
            {
                Console.WriteLine("a<b");
            }
        }

        static void task11()
        {
            /*Составить программу, которая в зависимости от порядкового номера дня недели (1, 2, ..., 7) выводит на экран его название (понедельник, вторник, ..., воскресенье).*/
            int a = Int32.Parse(Console.ReadLine());
            DayOfWeek dow = (DayOfWeek)a;
            Console.WriteLine(dow);
        }

        static void task12()
        {
            /*37.	Составить программу, которая в зависимости от порядкового номера месяца (1, 2, ..., 12) выводит на экран количество дней в этом месяце. Рассмотреть два случая: 
a.	год не является високосным (см. задачу 4.65); 
b.	год может быть високосным (информация об этом вводится с клавиатуры).*/
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine(DateTime.DaysInMonth(2018,a));
        }
    }
}
