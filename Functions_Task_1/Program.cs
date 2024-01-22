// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли.
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная.

//Функция подсчета суммы цифр:
int CalcSum(int Number)
{
int Sum = 0;
while(Number/10 >= 1)
{
    Sum = Sum + Number % 10;
    Number = Number/10;
}
Sum = Sum + Number;
return Sum;
}

while(true)
{
    Console.Write("Проверка числа на четность суммы цифр. Введите целое число. Для выхода введите 'q'. ");
    string Input;
    Input = Console.ReadLine();
    if (Input == "q")
    {
        Console.Write("Вы завершили работу программы.");
        break;
    }
    int N;
    N = Convert.ToInt32(Input);
    int Result = CalcSum(N);
    Console.Write("Сумма цифр равна: ");
    Console.Write(Result);
    Console.WriteLine(" ");
    if (Result % 2 == 0)
    {
        Console.Write("Сумма цифр четная. Работа завершена.");
        break;
    }
}
