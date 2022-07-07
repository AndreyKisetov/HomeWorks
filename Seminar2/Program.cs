namespace HelloWorld
{
    // Напишите программу, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньше.
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите целое число a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите целое число b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"{a} - большее число ");
                Console.WriteLine($"{b} - меньшее число ");
            }
            if (b > a )
            {
                Console.WriteLine($"{b} - большее число ");
                Console.WriteLine($"{a} - меньшее число ");
            }
        }
    }
}
