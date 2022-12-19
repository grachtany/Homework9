// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int DataEntry(string str)
{
    Console.Write(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

string ShowNumbers(int n)
{
    if (n == 1) return $"{1}";
    return ShowNumbers(n - 1) + " " + n;
}

// Написать функции переворота рекурсии

Console.Clear();
int n = DataEntry("Введите натуральное число n = ");
System.Console.WriteLine();