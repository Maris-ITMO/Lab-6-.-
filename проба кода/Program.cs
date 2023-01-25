using System;

namespace проба_кода
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите тект:");
            string input = Console.ReadLine().ToLower().Replace(" ", "");
            char[] inputArray = input.ToCharArray();
            Array.Reverse(inputArray);
            string reversedInput = new string(inputArray);

            if (input == reversedInput)
            {
                Console.WriteLine("Предложение является палиндромом");
            }
            else
            {
                Console.WriteLine("Предложение не является палиндромом");
            }
            Console.ReadKey();
