 //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

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
