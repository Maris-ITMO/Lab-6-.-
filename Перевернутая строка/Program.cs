using System;

namespace Перевернутая_строка
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение:");
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string str2 = strArray[0];
            foreach (string s in strArray)
            {
                str2 = c + str2;
            }
            Console.WriteLine(str2);
            Console.ReadKey();
        }
    }
}
