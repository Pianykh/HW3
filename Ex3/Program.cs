using System;
using System.Text;

/*3.Нужно удалить из строки лишние пробелы, изменить имя Гриша на Кирилл, и номер
заказа ‘#123123’ удалить вместе с ненужными пробелами.
Сама строка - ‘ Добрый день, Гриша, ваш заказ #123123 находится в
обработке.’*/

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            string inputString = " Добрый день, Гриша, ваш заказ #123123 находится в обработке.";
            string outputString = inputString.Replace("Гриша", "Кирилл").Replace(" #123123 ", "");
            Console.WriteLine(outputString);
        }
    }
}
