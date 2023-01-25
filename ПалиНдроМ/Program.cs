using System;

namespace ПалиНдроМ
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Введите предложение:");
                string str = Console.ReadLine();
                str = str.Replace(" ", "").ToLower();
                char[] reversedstr = str.ToCharArray();
                Array.Reverse(reversedstr);
                string reversed = new string(reversedstr);
                if (str == reversed)
                {
                    Console.WriteLine("Предложение является палиндромом");
                    Console.ReadKey();
                }
                else
                {
                Console.WriteLine("Предложение не является палиндромом");
                Console.ReadKey();
            }
        }
    }
}