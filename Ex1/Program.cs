using System;
using System.Text;
/*
* 1.Вводим дату словами(пример: двадцать первое марта 1999-го года), на экран
* выводится дата цифрами в указанном формате(дд.мм.гггг).
*/
namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.InputEncoding = Encoding.Unicode;            
            int day = 0;
            int month = 0;
            int year = 0;
            string[] StringMonth =
            {
                "", "января", "февраля", "марта", "апреля", "мая", "июня",
                "июля", "августа", "сентября", "октября", "ноября", "декабря"
            };
            string[] underTwenty =
            {
                "ноль", "первое", "второе", "третье", "четвертое", "пятое",
                "шестое", "седьмое", "восьмое", "девятое", "десятое", "одиннадцатое", "двенадцатое", "тринадцатое",
                "четырнадцатое", "пятнадцатое", "шестнадцатое", "семнадцатое", "восемнадцатое", "девятнадцатое"
            };
            string[] upperTwentyDecimal =
            {
                "", "", "двадцать", "тридцать", 
            };
            Console.WriteLine("Введите дату словами. Например: \"двадцать первое марта 1999-го года\"");
            string stringData = Console.ReadLine();
            int hyphenIndex = stringData.IndexOf('-');
            if (hyphenIndex != -1)
            {
                stringData = stringData.Remove(hyphenIndex);
            }            
            var stringNumbersArray = stringData.Split(' ');
            for (var i = 0; i < stringNumbersArray.Length; i++) 
            {
                if (int.TryParse(stringNumbersArray[i], out year));
                else
                {
                    for (var k = 0; k < upperTwentyDecimal.Length; k++)
                    {
                        if (stringNumbersArray[i].Equals(upperTwentyDecimal[k]))
                        {
                            day += k * 10;
                        }
                    }
                    for (var k = 0; k < underTwenty.Length; k++)
                    {
                        if (stringNumbersArray[i].Equals(underTwenty[k]))
                        {
                            day += k;
                        }
                    }
                    for (var k = 0; k < StringMonth.Length; k++)
                    {
                        if (stringNumbersArray[i].Equals(StringMonth[k]))
                        {
                            month += k;
                        }
                    }
                }                              
            }
            string resultDataString = $"{day}.{(month < 10 ? "0" : "")}{month}.{(year < 10 ? "000" : (year < 100 ? "00" : year < 1000 ? "0" : ""))}{year}";
            Console.WriteLine(resultDataString);
        }
    }
}