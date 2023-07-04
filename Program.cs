using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1: определение чётного или нечётного числа

            Console.WriteLine("Проверка числа на четность");
            Console.Write("Введите число: ");

            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber % 2 == 0)
            {
                Console.WriteLine("Число четное!");
            }
            else
            {
                Console.WriteLine("Число нечетное!");
            }

            Console.ReadKey();

            //Задание 2: Программа подсчёта суммы карт в игре «21»

            Console.Write("\nВведите количество карт у вас в руке:");

            int numberOfCards = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <= numberOfCards; i++)
            {
                Console.Write($"Введите значение карты {i}: ");
                
                string value = Console.ReadLine();
                switch (value)
                {
                    case "2": sum += 2; break;
                    case "3": sum += 3; break;
                    case "4": sum += 4; break;
                    case "5": sum += 5; break;
                    case "6": sum += 6; break;
                    case "7": sum += 7; break;
                    case "8": sum += 8; break;
                    case "9": sum += 9; break;
                    case "10": sum += 10; break;
                    case "J": sum += 10; break;
                    case "Q": sum += 10; break;
                    case "K": sum += 10; break;
                    case "T": sum += 10; break;
                        default: 
                        Console.WriteLine("такой карты не существует. Попробуйте еще раз:");
                        i -= 1;
                        break;
                }
            }
            if (sum < 21)
            {
                Console.WriteLine($"\nСумма ваших карт: {sum}");
                Console.ReadKey();
            }
            else if (sum == 21)
            {
                Console.WriteLine($"\nСумма ваших карт: {sum}. Вы победили!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"\nСумма ваших карт: {sum}. Вы проиграли!");
                Console.ReadKey();
            }

            //Задание 3: Проверка простого числа

            Console.Write("\nВведите целое число:");

            int userNumb = int.Parse(Console.ReadLine());
            bool num = true;

            for (int i = 2; i < userNumb; i++)
            {
                if (userNumb % i == 0)
                {
                    num = false;
                    break;
                }
            }
            
            if (num)
            {
                Console.WriteLine($"{userNumb} - простое число");
            }
            else
            {
                Console.WriteLine($"{userNumb} - не является простым числом");
            }

            //Задание 4: Наименьший элемент в последовательности

            int n, min, curr; 
            Console.Write("\nВведите количество чисел в последовательности: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Введите первое число: ");
            min = curr = int.Parse(Console.ReadLine()); 

            for (int i = 1; i < n; i++) 
            {
                Console.Write("Введите следующее число: ");
                curr = int.Parse(Console.ReadLine());
                if (curr < min) 
                {
                    min = curr;
                }
            }

            Console.WriteLine($"Наименьший элемент: {min}");

            //Задание 5. Игра «Угадай число»
            Console.WriteLine("\nДобро пожаловать в игру «Угадай число»!");
            Console.Write("Введите максимальный диапозон чисел: ");

            Random random = new Random();
            int maxValue = int.Parse(Console.ReadLine());
            int secretNumber = random.Next(0, maxValue);
            int attempts = 0;

            Console.WriteLine($"Я загадал число от 0 до {maxValue}. Отгадай его за минимальное количество попыток.");

            while (true)
            {
                Console.Write("Введите ваш ответ (для выхода введите пустую строку): ");
                string input = Console.ReadLine();

                if (input == "") 
                {
                    Console.WriteLine($"Игра окончена. Загаданное число: {secretNumber}");
                    break;
                }

                int guess = int.Parse(input);
                attempts++;

                if (guess == secretNumber)
                {
                    Console.WriteLine($"Вы угадали число за {attempts} попыток!");
                    break;
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("Ваше число меньше загаданного.");
                }
                else
                {
                    Console.WriteLine("Ваше число больше загаданного.");
                }
            }
             Console.ReadKey();
        }

    }
}
