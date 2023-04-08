/*

ДОМАШНЕЕ ЗАДАНИЕ 


Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
_____________________________ 

ЗАДАЧА 34: РЕШЕНИЕ

Console.Write("Задайте длину массива: ");
int a = int.Parse(Console.ReadLine());
int[] randomArray = new int[a];

void array(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(99, 999);
        Console.Write(randomArray[i] + " ");
    }
}

int amount(int[] randomArray)
{
    int amount = 0;
    for (int i = 0; i < randomArray.Length; i++)
    {
        if (randomArray[i] % 2 == 0)
            amount = amount + 1;
    }
    return amount;
}

array(a);
Console.Write($"\nЧётных чисел в массиве: { amount(randomArray)}"); 
____________________

ЗАДАЧА 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
РЕШЕНИЕ

Console.Write("Задайте длину массива: ");
int a = int.Parse(Console.ReadLine());
int[] randomArray = new int[a];

void array(int a)
{
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = new Random().Next(1, 9);
        Console.Write(randomArray[i] + " ");
    }
}
int amount(int[] randomArray)
{
    int sum = 0;
    int i = 0;
    while (i < randomArray.Length)
    {
        sum = sum + randomArray[i];
        i = i + 2;
    }
    return sum;
}
array(a);
Console.Write($"Cумма чисел на нечётных позициях: { amount(randomArray)}");

__________________________________________ 

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/

Console.Write("Задайте размер массива: ");
int a = int.Parse(Console.ReadLine());
double[] randomArray = new double[a];

void array(int a)
{
    Random rand = new Random();
    for (int i = 0; i < a; i++)
    {
        randomArray[i] = rand.NextDouble();
        Console.Write($"{ randomArray[i]:F2} ");
    }
}

double difference(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if (max < randomArray[i])
            max = randomArray[i];
        if (min > randomArray[i])
            min = randomArray[i];
        i = i + 1;
    }
    return max - min;
}
array(a);
Console.Write($"\nРазница между max и min элементов массива: { difference(randomArray):F2}");









