using System;

namespace без_ПРОБЕЛА_и_РЕГИСТРА
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите тект:");
            string input = Console.ReadLine();
            string output = new string(input.ToLower().Where(c => !Char.IsWhiteSpace(c)).ToArray());
            Console.WriteLine("Текст без пробелов и с учетом регистра:" + output);
            Console.ReadKey();
        }
    }
}
