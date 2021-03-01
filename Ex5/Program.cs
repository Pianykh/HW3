using System;
using System.Linq;

/*
 * Ввести 4 строки в консоль. Вывести на консоль те строки, 
 * длина которых меньше средней и также содержит в себе слово полиндром, 
 * при этом вывести также их длину, если таковых нет, 
 * то вывести сообщение об этом. пример текста - "Сегодня Анна ходила в магазин за покупками.".
*/
namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputStrings = new string[4];
            for (int i = 0; i < inputStrings.Length; i++)
            {
                Console.WriteLine($"Введите {i+1}-ю строку:");
                inputStrings[i] = Console.ReadLine();
            }
            bool containPalindrom = false;
            bool check = false;
            int averageLength = (inputStrings[0].Length + inputStrings[1].Length + inputStrings[2].Length + inputStrings[3].Length) / 4;
            Console.WriteLine($"Средняя длинна строки - {averageLength}");
            Console.WriteLine($"Вывод:");
            for (int i = 0; i < inputStrings.Length; i++)
            {                
                string[] words = inputStrings[i].Replace(",", "").Replace(".", "").Split(" ");
                for (int k = 0; k < words.Length; k++)
                {                    
                    string reverseString = new string (words[k].ToCharArray().Reverse().ToArray());
                    if (words[k].Length > 1 && (reverseString.ToLower() == words[k].ToLower()))
                    {
                        containPalindrom = true;
                    }
                }
                if (containPalindrom && inputStrings[i].Length < averageLength)
                {
                    Console.WriteLine($"{inputStrings[i]} - длинна строки - {inputStrings[i].Length}");
                    check = true;
                }
                containPalindrom = false;
            }
            if (!check)
            {
                Console.WriteLine("Нет строк с заданными параметрами");
            }
            
        }
    }
}
