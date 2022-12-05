﻿//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] CreateArr (int size, int min, int max)
{
    int [] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max +1);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

int [] arr = CreateArr (4, 99, 1000);
int count = 0;

for (int z = 0; z < arr.Length; z++)
if (arr[z] % 2 == 0)
count++;


Console.Write("[ ");
PrintArr(arr);
Console.WriteLine($" ] -> {count}");
