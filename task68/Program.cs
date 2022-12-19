// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int DataEntry(string str)
{
    Console.Write(str);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int A(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return A(n - 1, 1);
    else
      return A(n - 1, A(n, m - 1));
}

Console.Clear();
int n = DataEntry("Введите натуральное число n = ");
int m = DataEntry("Введите натуральное число m = ");
System.Console.WriteLine(A(m, n));