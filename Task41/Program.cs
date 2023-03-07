// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Clear();

// int[] array = {0, 7, 8, -2, -2,};   Массив уже заполнен!!!
//int[] array = FillArray(8, -5, 5);   Заполнение рандомам!!!
int length = Prompt("Введите длинну масива: ");
int[] array = Input(length);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"В массиве количество положительных чисел равно {GetCountNumber(array)}");

int Prompt(string text)
{
    Console.Write(text);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

/*int[] FillArray(int length, int min, int max)    Заполнение рандомам!!!
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(min, max);
    }
    return arr;
}*/

int[] Input(int length)                   // Ввод пользователем
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        arr[i] = Prompt($"Введите {i+1}-й элемент массива: ");
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
}

int GetCountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    return count;
}
