using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите с клавиатуры предложение");
            string stratString = Console.ReadLine();
            string[] stringArray = stratString.Split(' ');
            int maxword = 0;
            int count = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i].Length > maxword)
                {
                    maxword = stringArray[i].Length;
                    count = i;
                }
            }
            Console.WriteLine("Самое длинное слово в предлоложении - {0}", stringArray[count]);
            Console.ReadKey();
        }
    }
}
