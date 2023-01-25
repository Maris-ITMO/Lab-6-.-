using System;

namespace wow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите тект:");
            string length = Console.ReadLine();

            string cleanedSentence = Regex.Replace(length, @"\s", "");
            cleanedSentence = cleanedSentence.ToLower();

            // Переверните очищенную строку
            char[] reversedSentence = cleanedSentence.ToCharArray();
            Array.Reverse("Превернутое предложение");

            // Сравните очищенную строку с перевернутой строкой
            if (cleanedSentence == new string(reversedSentence))
            {
                Console.WriteLine("Предложение является палиндромом");
            }
            else
            {
                Console.WriteLine("Предложение не является палиндромом");
            }
        }
    }
}
