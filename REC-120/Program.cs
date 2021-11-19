using System;

namespace REC_120
{
    class Program
    {
        static string NotReplace(char[] str)
        {
            for (int i = 0; i < str.Length; i++)
                if (str[i] == '.')
                    str[i] = '!';
            String NewStr = new String(str);
            return NewStr;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            char[] str = Console.ReadLine().ToCharArray();
            Console.Write($"Новая строка: {NotReplace(str)}");
            Console.ReadKey();
        }
    }
}
