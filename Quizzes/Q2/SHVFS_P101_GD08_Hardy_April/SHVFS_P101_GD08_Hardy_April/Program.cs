using System;
namespace SHVFS_P101_GD08_Hardy_April
{
    public class Program
    {

        public static void Main(string[] args)
        {
            float a;
            float b;
            while (true)
            {
                Console.WriteLine("Please input Dividend ");    
                float.TryParse(Console.ReadLine(), out a);
                Console.WriteLine("Please input Divisor ");
                float.TryParse(Console.ReadLine(), out b);
                if (b == 0)
                {
                    Console.WriteLine("Get Wrong!");
                }
                else
                {
                    Console.WriteLine($"The result is {a / b}");
                }
                //Console.Clear();
            }

        }
    }
}
