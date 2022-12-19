// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int DataEntry(string str)
{
    Console.Write(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int ShowNumbers(int n, int m)
{
    if (n == m) return m;
    return ShowNumbers(n - 1, m) + n;

}

Console.Clear();
int n = DataEntry("Введите натуральное число n = ");
int m = DataEntry("Введите натуральное число m = ");
System.Console.WriteLine(ShowNumbers(n, m));
