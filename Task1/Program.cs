﻿// Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: {1, 2, 3, 4, 5}
// ● Выход: 5, 4, 3, 2, 1
// ● Вход: {10, 20, 30, 40}
// ● Выход: 40, 30, 20, 10

int[] array = { 1, 2, 3, 4, 5 };  // Можно поменять значение для проверки

PrintArrayReversed(array, array.Length - 1);

void PrintArrayReversed(int[] array, int index)

{

    if (index >= 0)

    {

        Console.Write(array[index] + " ");

        PrintArrayReversed(array, index - 1);

    }

}
