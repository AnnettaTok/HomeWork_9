/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int GetNumber()
{

    int result = 0;
    while (true)
    {
        Console.WriteLine("Введите целое положительное число:");
        if (int.TryParse(Console.ReadLine(), out result) && result >= 1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод");
        }
    }
    return result;
}

void WriteNumbers(int n)
{
    if (n == 1)
    {
        Console.Write("1");
    }
    else
    {
    Console.Write($"{n}  ");
    WriteNumbers(n - 1);
    }
}

int n = GetNumber();
WriteNumbers(n);