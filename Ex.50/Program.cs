/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

int[,] array = GetArray(rows, columns,0, 10);
PrintArray(array);
Console.WriteLine("Введите номер строки: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int num2 = int.Parse(Console.ReadLine());

if (num1 < array.GetLength(0)  &&  num2 < array.GetLength(1)) {
    num1 = num1 -1;
    num2 = num2 -1;
    int x = array[num1,num2];
    Console.WriteLine(x);
    }
else {
    Console.WriteLine("Такого элемента нет");
}


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

