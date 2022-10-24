// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
Console.WriteLine($"\n Введите размер массива m * n и диапазон случайных значений: ");
int m = InputNumbers(" Введите m: ");
int n = InputNumbers(" Введите n: ");
int range = InputNumbers(" Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int minSumLine = 0;
int SumLine = SumLineElements(array, 0);
for(int i = 0; i < array.GetLength(0); i ++)
{
    int tempSumLine = SumLineElements(array, i);
    if(SumLine > tempSumLine)
    {
        SumLine = tempSumLine;
        minSumLine = 1;
    }
}
Console.WriteLine($"\n{minSumLine + 1} - строка с наименьшей суммой ({SumLine}) элементов ");

int SumLineElements(int[,] array, int i)
{
    int SumLine = array[i, 0];
    for(int j = 0; j < array.GetLength(1); j ++)
    {
        SumLine += array[i, j];
    }
    return SumLine;
}

int InputNumbers(string input)
{
    Console.WriteLine(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i ++)
    {
        for(int j = 0; j < array.GetLength(1); j ++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i ++)
    {
        for(int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}