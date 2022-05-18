using System;
using System.Collections.Generic;
using System.Linq;

namespace Convertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número que desea convertir: ");
            int input = Convert.ToInt32(Console.ReadLine());

            var convertor = new NumberConvertor();
            string result = convertor.Convert(input);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }

    public class NumberConvertor
    {
        public Dictionary<int, string> Symbols { get; set; }
        public NumberConvertor()
        {
            Symbols = new Dictionary<int, string>();
            Symbols.Add(1, "I");
            Symbols.Add(4, "IV");
            Symbols.Add(5, "V");
            Symbols.Add(9, "IX");
            Symbols.Add(10, "X");
            Symbols.Add(40, "XL");
            Symbols.Add(50, "L");
            Symbols.Add(90, "XC");
            Symbols.Add(100, "C");
            Symbols.Add(400, "CD");
            Symbols.Add(500, "D");
            Symbols.Add(900, "CM");
            Symbols.Add(1000, "M");
        }

        public string Convert(int number)
        {

            if (number < 0)
                return "No se puede convertir un número no natural";

            int division = 0;
            int nextNumber = 0;
            string result = "";

            for(int i = Symbols.Count - 1; i >= 0; i--)
            {
                var item = Symbols.ElementAt(i);
                if(number >= item.Key)
                {
                    division = number / item.Key;
                    nextNumber = number % item.Key;

                    if (division == 1 && nextNumber == 0)
                        return item.Value;

                    for(int j = 0; j < division; j++)
                    {
                        result += item.Value;
                    }

                    result += Convert(nextNumber);
                    break;
                }
            }
            return result;
        }
    }
}
