using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Consol
{
    class Task1
    {
        static void Main(string[] args)
        {
            // Ввод слов
            Console.WriteLine("Для проверки слов на анаграмму ,введите первое слово, а затем нажмите Enter");
            string word1 = Console.ReadLine();
            Console.WriteLine("Введите второе слово, а затем нажмите Enter");
            string word2 = Console.ReadLine();

            //Удаление пробелов
            //Можно было сделать RegExp
            word1 = word1.Replace(" ", "");
            word2 = word2.Replace(" ", "");


            //Проверка на ввод пустой строки
            if ((word1 != "") && (word2 != ""))
            {
                // Для более корректного сравнения сделаем буквы прописные
                word1 = word1.ToLower();
                word2 = word2.ToLower();


                // Сортировка по алфавиту с помощью Linq
                List<char> anagram1 = word1.Select(x => x).OrderBy(x => x).ToList();
                List<char> anagram2 = word2.Select(x => x).OrderBy(x => x).ToList();

                //Объединение list для проверки
                String anagrm1ToCheck = String.Join("", anagram1);
                String anagrm2ToCheck = String.Join("", anagram2);

                if (anagrm1ToCheck == anagrm2ToCheck)
                {
                    Console.WriteLine("Слова являются анаграммами");
                }
                else
                {
                    Console.WriteLine("Слова не являются анаграммами");
                }
            }
            else
            {
                Console.WriteLine("Введена пустая строка");
            }

        }
    }
}
