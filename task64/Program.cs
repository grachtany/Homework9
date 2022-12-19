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

char[] StringTransformationAaray(string str)
{
    char[] arr = new char[str.Length];
    for (int i = 0; i < str.Length; i++)
    {
        arr[i] = str[i];
    }
    return arr;
}

char[] UpheavalArray(char[] arr1)
{
    int index = 0;
    if (index < arr1.GetLength(0) / 2)
    {
        char buffer = arr1[arr1.GetLength(0) - 1];
        arr1[arr1.GetLength(0) - 1 - index] = arr1[index];
        arr1[index] = buffer;
        index++;
    }
    return arr1;
}


Console.Clear();
int n = DataEntry("Введите натуральное число n = ");
string numbers = ShowNumbers(n);

char[] arr = StringTransformationAaray(numbers);

Console.WriteLine(UpheavalArray(arr));