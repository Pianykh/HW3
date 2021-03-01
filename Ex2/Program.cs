using System;
using System.Text;

/*
* 2.Необходимо создать простой калькулятор, который может при вводе строке в виде
* ‘отними 123 от 31’ выводит результат вычисления. Математические операции, которые
* должен уметь делать: +, -, /, *.При попытке поделить на ноль должен выводить, что
* на ноль делить нельзя. Нужно учесть, что команды подели/умнож и т.д. могут
* вводиться в любом регистре.
*/

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            int result = 0;            
            Console.WriteLine("Простой калькулятор. Считает введенное выражение. Например - \"отними 123 от 31\"");
            Console.WriteLine("Допустимые команды - \"отними\", \"добавь\", \"умножь\", \"подели\"");
            string data = Console.ReadLine();            
            var dataArray = data.Split(' ');
            dataArray[0] = dataArray[0].ToLower();
            if (dataArray[0] == "отними")
            {
                result = int.Parse(dataArray[3]) - int.Parse(dataArray[1]);
            }
            else if (dataArray[0] == "добавь")
            {
                result = int.Parse(dataArray[1]) + int.Parse(dataArray[3]);
            }
            else if (dataArray[0] == "умножь")
            {
                result = int.Parse(dataArray[1]) * int.Parse(dataArray[3]);
            }
            else if (dataArray[0] == "подели")
            {
                if(int.Parse(dataArray[3]) != 0)
                { 
                result = int.Parse(dataArray[1]) / int.Parse(dataArray[3]);
                }
                else Console.WriteLine("На ноль делить нельзя!");
            }
            else Console.WriteLine("Недопустимый оператор");
            Console.WriteLine("Результат операции: " + result);
        }
    }
}
