/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
}

start:
System.Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (M < 0 || N < 0)
{
    System.Console.WriteLine("Введите неотрицательные числа ");
    goto start;
}
System.Console.WriteLine($"Результат функции Аккермана: {Akkerman(M, N)}.");