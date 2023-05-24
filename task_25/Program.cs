//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите необходимую степень числа:");
            int b = Convert.ToInt32(Console.ReadLine());
          
            int x = 1; 
            for (int i = 0; i<b; i++ ) {
                x*=a;
            }
            Console.WriteLine("{0} ^ {1} = {2}", a, b, x);
    }
    }
