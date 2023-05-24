//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


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

int [] arr = CreateArr (4, -100, 100);
int sum = 0;
for (int i = 0; i < arr.Length; i+=2)
sum = sum + arr[i];

Console.Write("[ ");
PrintArr(arr);
Console.WriteLine($" ] -> {sum}");
