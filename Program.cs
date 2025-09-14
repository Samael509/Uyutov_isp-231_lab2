using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using Microsoft.Win32;

namespace Uyutov_isp_231_lab2
{

    class Program
    {

        static void Main(string[] args)
        {
            // задание 1
            Console.WriteLine("Введите число");
            int x = Convert.ToInt32(Console.ReadLine());

            if ((x % 2) == 0)
            {
                Console.WriteLine("чётное");
            }
            else
            {
                Console.WriteLine("не чётное");
            }

            // задание 2
            Console.WriteLine("Введите пароль: ");
            string password = Console.ReadLine();
            Console.WriteLine("Введите пароль повторно: ");
            string again = Console.ReadLine();

            if (password == again)
            {
                Console.WriteLine("Пароль успешно создан");
            }
            else
            {
                Console.WriteLine("error");
            }

            // Задание 3
            Console.WriteLine("введите 4-х значное число: ");
            int n = int.Parse(Console.ReadLine());

            int firstDigit = n / 1000;
            int secondDigit = (n / 100) % 10;
            int thirdDigit = (n / 10) % 10;
            int fourthDigit = n % 10;

            if (firstDigit + fourthDigit == secondDigit - thirdDigit)
            {
                Console.WriteLine("ДА");
            }
            else
            {
                Console.WriteLine("НЕТ");
            }

            // задание 4
            Console.WriteLine("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("доступ запрещён");
            }
            else
            {
                Console.WriteLine("доступ разрешён");
            }

            // задание 5
            Console.WriteLine("Введите 2 числа: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }

            // задание 6
            Console.WriteLine("введите первое число, второе, затем операцию (+, -, *, /)");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            char sign = char.Parse(Console.ReadLine());

            if (sign == '+')
            {
                Console.WriteLine(first + second);
            }
            else if (sign == '-')
            {
                Console.WriteLine(first - second);
            }
            else if (sign == '*')
            {
                Console.WriteLine(first * second);
            }
            else if (sign == '/')
            {
                if (second == 0)
                {
                    Console.WriteLine("error");
                }
                else
                {

                    Console.WriteLine(first / second);
                }
            }
            else
            {
                Console.WriteLine("error");
            }

            // Задание 7
            Console.WriteLine("Введите день недели: (1-7)");
            string den = Console.ReadLine().ToLower();

            switch (den)
            {
                case "1":
                    Console.WriteLine("Понедельник");
                    break;
                case "2":
                    Console.WriteLine("Вторник");
                    break;
                case "3":
                    Console.WriteLine("Среда");
                    break;
                case "4":
                    Console.WriteLine("Четверг");
                    break;
                case "5":
                    Console.WriteLine("Пятница");
                    break;
                case "6":
                    Console.WriteLine("Суббота");
                    break;
                case "7":
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }


            // Задание 8
            Console.WriteLine("Введите 2 числа и операцию: (+, -, *, /) ");
            int a1 = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            switch (c)
            {
                case '+':
                    Console.WriteLine(a1 + a2);
                    break;
                case '-':
                    Console.WriteLine(a1 - a2);
                    break;
                case '*':
                    Console.WriteLine(a1 * a2);
                    break;
                case '/':
                    Console.WriteLine(a1 * a2);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            // Задание 9
            Console.WriteLine("Выберите сложность: ");
            Console.WriteLine("1 - Лёгкий");
            Console.WriteLine("2 - Средний");
            Console.WriteLine("3 - Сложный");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Выбрана Лёгкая сложность: Хотите расслабиться?");
                    break;
                case 2:
                    Console.WriteLine("Выбрана Средняя сложность: Обычная сложность");
                    break;
                case 3:
                    Console.WriteLine("Выбрана Сложная сложность: Здесь твой конец");
                    break;
                default:
                    Console.WriteLine("Выберите от 1-3");
                    break;
            }

            // Задание 11
            Console.WriteLine("Введите класс персонажа: (воин, маг, разбойник, паладин, варвар, охотник, друид, жрец)");
            string choiceClass = Console.ReadLine().ToLower();

            switch (choiceClass)
            {
                case "воин":
                case "разбойник":
                case "паладин":
                case "варвар":
                    Console.WriteLine("Персонаж является: ближним бойцом");
                    break;

                case "маг":
                case "охотник":
                case "друид":
                case "жрец":
                    Console.WriteLine("Персонаж является: Дальнобойщиком");
                    break;

                default:
                    Console.WriteLine("Неверный класс");
                    break;
            }

            // Задание 12
            Console.WriteLine("введите 3 числа: ");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int s = 0;

            if (num1 > 0)
            {
                s += num1;
            }
            if (num2 > 0)
            {
                s += num2;
            }
            if (num3 > 0)
            {
                s += num3;
            }
            Console.WriteLine($"Сумма положительных чисел: {s}");

            // Задание 13
            Console.WriteLine("Вы стоите перед первой дверью. Перед вам 2 пути: ");
            Console.WriteLine("Путь A: Войти в комнату с огромным драконом.");
            Console.WriteLine("Путь B: Пойти по темному коридору");
            string choice1 = Console.ReadLine().ToLower();

            switch (choice1)
            {
                case "a":
                    Console.WriteLine("Вы стретили дракона. Вам нужно отгадать его загадку: \"Кто не дышит, но живет; хоть не нужно — много пьет; и в жизни, и в смерти тело как лед.\" ");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "рыба")
                    {
                        Console.WriteLine("Верно. Вам открылась таинственная дверь");
                    }
                    else
                    {
                        Console.WriteLine("Вас съели, конец)");
                        break;
                    }
                    break;
                case "b":
                    Console.WriteLine("Вы попали в тёмную комнату\nПеред вами 2 двери: в какую войдёте? (1 или 2)");
                    int choiceDoor;
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out choiceDoor) && (choiceDoor == 1 || choiceDoor == 2))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Введите 1 или 2");
                        }
                    }
                    if (choiceDoor == 1)
                    {
                        Console.WriteLine("Вы нашли сокровища, поздравляем");
                    }
                    else
                    {
                        Console.WriteLine("Вы наступили на ядовитый шип и погибли(");
                    }
                    break;
            }



        }   
    }
}
// Задание 10
//namespace Program
//{
    // Основная логика
    //internal class Program
    //{
        // Начальное хп 
        //static int health = 100;
        // Главный метод
        //static void Main(string[] args)
        //{
            // Вывод текущего хп
            //Console.WriteLine($"Здоровье персонажа: {health}");
            // полученный дамаг
            //TakeDamage(30);
        //}
        // Метод, уменьшает хп перса на переданное значение
        //static void TakeDamage(int damage)
        //{
            // отнимаем хп на величину урона
           //ealth -= damage;
            // Вывод инфы о полученном уроне и текущем хп
            //Console.WriteLine($"Персонаж получил {damage} урона. Текущее здоровье: {health}.");
        //}
    //}
//}