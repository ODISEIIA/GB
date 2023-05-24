//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через пробел: ");
int[] arr = StringToNum(Console.ReadLine());
PrintArr(arr);
int sum = 0;

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        sum++;
    }
}

Console.WriteLine($"-> {sum}");

int[] StringToNum(string input)
{
    int count = 1;                                  //считаем количество элементов будщего массива
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ' ')
        {
            count++;
        }
    }
     int[] arr = new int [count];                   //присваеваем количество элементов массиву
    int index = 0;

    for (int i = 0; i < input.Length; i++)          //заполняем массив
    {
        string temp = "";

        while (input [i] != ' ')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        arr[index] = Convert.ToInt32(temp);
        index++;
    }
    return arr;
}

void PrintArr(int [] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
          }
}