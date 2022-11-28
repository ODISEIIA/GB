//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

internal partial class Program
{
    private static void Main(string[] args)
    {
        {
            int[] array = new int[8];
            Random myRandom = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(0, 7);
                Console.Write("{0} ", array[i]);
            }
        }
    }
}