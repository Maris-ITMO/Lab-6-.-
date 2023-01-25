using System;

namespace фигурные_скобки
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Это {некоторый текст}, который {имеет несколько} наборов фигурных скобок".;
            string output = new string();
            int curlyBraceCount = 0;

            foreach (char c in input)
            {
                if (c == '{')
                {
                    curlyBraceCount++;
                    continue;
                }
                else if (c == '}')
                {
                    curlyBraceCount--;
                    continue;
                }

                if (curlyBraceCount == 0)
                {
                    output.Append(c);
                }
            }
        }
    }
}
