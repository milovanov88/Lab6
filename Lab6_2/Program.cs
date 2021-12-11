using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите с клавиатуры предложение");
            string stratString = Console.ReadLine();
            stratString = stratString.ToLower();
            stratString = stratString.Replace(" ", "");
            string output = "";
            for (int i = stratString.Length - 1; i >= 0; i--)
            {
                output += stratString[i];
            }
            if (output == stratString)
                Console.WriteLine("фраза является палиндромом");
            else
            {
                Console.WriteLine("фраза не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
