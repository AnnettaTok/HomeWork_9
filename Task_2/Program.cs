/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

System.Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int m, int n)
{
    if (n == m) return m;
    else if (n < m) return n + SumNumbers(m, n + 1);
    else return n + SumNumbers(m, n - 1);
}

System.Console.WriteLine($"Сумма чисел между {M} и {N} равна {SumNumbers(M, N)}.");