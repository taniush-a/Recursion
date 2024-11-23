// Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N. Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: M = 1, N = 5
// ● Выход: 1, 2, 3, 4, 5
// ● Вход: M = 4, N = 8
// ● Выход: 4, 5, 6, 7, 8


void PrintNaturalNumbers(int M, int N)
{
    if (M <= N)
    {
        Console.Write(M + " ");
        PrintNaturalNumbers(M + 1, N);
    }

}
Console.WriteLine("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());


PrintNaturalNumbers(M, N);
