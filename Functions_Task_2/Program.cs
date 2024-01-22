// Задача 2: Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// Функция по созданию массива:
int[] CreateArray(int ArrayLength)
{
    int[] Arr = new int[ArrayLength];
    for (int i = 0; i < Arr.Length; i++)
    {
        Arr[i] = new Random().Next(100, 1001);
    }
    return Arr;
}

// Функция по выводу массива:
void PrintArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
    Console.WriteLine();
}

// Функция по подсчету кол-ва четных + вывод их кол-ва:
void CountEven(int[] ResultArray)
{
    int Count = 0;
    foreach (int E in ResultArray)
    {
        if (E % 2 == 0)
        {
            Count++;
        }
    }
    Console.Write($"Количество четных чисел в массиве = {Count}");
}

// Ввод переменной (длина массива) и запуск функций:
int[] Result = CreateArray(10);
PrintArray(Result);
CountEven(Result);