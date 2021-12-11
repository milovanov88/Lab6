using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 3");
            string sentence = "Требуется удалить {9} весь {текст в фигурных {{некрасивых}} скоках {{{нана}}}";
            Console.WriteLine(sentence);
            string text;
            while (sentence.IndexOf('{') > 0)
            {
                text = sentence.Substring(sentence.IndexOf('}') + 1);
                while (text.IndexOf('{') > text.IndexOf('}'))
                {
                    text = text.Substring(text.IndexOf('}') + 1);
                }
                if (text.LastIndexOf('{') < 0)
                {
                    text = sentence.Substring(sentence.LastIndexOf('}') + 1);
                }
                sentence = sentence.Substring(0, sentence.IndexOf('{') - 1) + text;
            }
            Console.WriteLine(sentence);
            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}