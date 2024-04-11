using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PracticalWork_5._5
{
    internal class Program
    {
        /// <summary>
        /// Разделяем предложение по пробелу на слова и возвращаем массив слов
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] SplitText(string text)
        {
            string[] word = text.Split(' ');
            return word;
        }

        /// <summary>
        /// Вывод слов из массива построчно на экран
        /// </summary>
        /// <param name="word"></param>
        static void ConclusionWord(string[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                Console.WriteLine(word[i]);
            }
        }

        /// <summary>
        /// Переставляем слова
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        static string ReverseWord(string[] word)
        {
            string reverseText = "";
            for (int i = word.Length-1; i >= 0; i--)
            {
                reverseText += word[i] + " ";
            }
            return reverseText;
        }

        /// <summary>
        /// Разбиение текста на слова и запись слов в обратном порядке
        /// </summary>
        /// <param name="text2"></param>
        /// <returns></returns>
        static void ReverseWordFull(string text2) 
        {
            string[] splitText = text2.Split(' ');

            Console.WriteLine(ReverseWord(splitText));
        }

        static void Main(string[] args)
        {
            #region Задание 1. Метод разделения строки на слова

            Console.WriteLine("Задание 1. Метод разделения строки на слова");
            Console.WriteLine();

            Console.Write("Введите строку: ");
            var text1 = Console.ReadLine();

            string[] splitText1 = SplitText(text1);

            ConclusionWord(splitText1);

            #endregion

            Console.WriteLine();

            #region Задание 2. Перестановка слов в предложении

            Console.WriteLine("Задание 2. Перестановка слов в предложении");
            Console.WriteLine();

            Console.Write("Введите строку: ");
            var text2 = Console.ReadLine();

            ReverseWordFull(text2);

            #endregion

            Console.ReadKey();
        }
    }
}
