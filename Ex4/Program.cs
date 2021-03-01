using System;
using System.Text;
/*
Найти кол-во  дубликатов "я" в предложении и вывести их кол-во - 
"Вчера я был на речке, там я купался и загорал, из-за того, что я уснул, то я очень обгорел."
*/
namespace Ex4
{    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Введите фразу:");
            string inputString = Console.ReadLine();
            var wordsArray = inputString.Replace(",", "").Split(' ');
            int duplicates = 0;
            foreach (string word in wordsArray)
            {
                if (word == "я")
                {
                    duplicates++;
                }
            }
            Console.WriteLine(duplicates);
        }
    }
}
