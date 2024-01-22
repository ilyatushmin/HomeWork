// Задача 3: Напишите программу, которая перевернёт одномерный массив
// (первый элемент станет последним, второй – предпоследним и т.д.).

// Функция по созданию массива:
int[] CreateArray(int ArrayLength)
{
    int[] Array = new int[ArrayLength];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().Next(1, 10);
    }
    return Array;
}

int[] ReverseArray(int[] Array)
{
    int[] Res = new int[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        Res[i] = Array[Array.Length - 1 - i];
    }
    return Res;
}

// Функция по выводу массива-результата:
void PrintArray(int[] NewArr)
{
    for (int i = 0; i < NewArr.Length; i++)
    {
        Console.Write($"{NewArr[i]} ");
    }
    Console.WriteLine();
}


// Ввод переменной (длина массива) и запуск функций:
int[] First = CreateArray(10);
Console.Write("Начальный массив (случайный): ");
PrintArray(First);
Console.WriteLine();
Console.Write("Итоговый массив (перевернутый): ");
int[] Result = ReverseArray(First);
PrintArray(Result);