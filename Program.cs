
/* 
Задача 32: Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, 
и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]



int[] array = GenerateArray(10);
PrintArray(array);
GetNumber(array);

PrintArray(array);

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
    return array;
}

void GetNumber(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }

}
void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(",", arr));
}

Задача 33: Задайте массив. Напишите программу, которая определяет, 
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет 3; массив [6, 7, 19, 345, 3] -> да


int[] array = GenerateArray(123);
PrintArray(array);
GetFindNumber(array);

PrintArray(array);

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
    return array;
}

void GetFindNumber(int[] arr)
{
    int a = 4;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == a)
        Console.Write($"В этом массиве есть {a}");
        else 
        Console.Write("Такого числа в массиве нет");
    }

}
void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(",", arr));
}

ДОМАШНЕЕ ЗАДАНИЕ 
*/ 

Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
_____________________________ 

ЗАДАЧА 34: РЕШЕНИЕ

