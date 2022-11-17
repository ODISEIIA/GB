    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c) 
            {
                Console.WriteLine("Число {0} максимальное", a);
            }
            else if (b > a && b > c) 
            {
                Console.WriteLine("Число {0} максимальное", b);
            }
            else
            {
                Console.WriteLine("Число {0} максимальное", c);
            }
        }
    }
