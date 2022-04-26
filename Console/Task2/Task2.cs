using System;
using System.Linq;

public class Class1
{
    static void Main(string[] args)
    {
        // Ввод слов
        Console.WriteLine("Для проверки количества одинаковых букв в словах введите первое слово, а затем нажмите Enter");
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

            int count = word1.GroupBy(x => x).
           Join(
           word2.GroupBy(x => x),
           g => g.Key,
           g => g.Key,
           (lg, rg) => lg.Zip(rg, (l, r) => l).Count()
               )
                .Sum();

            Console.WriteLine("Кол-во одинаковых букв: {0}", count);

        }
        else
        {
            Console.WriteLine("Введена пустая строка");
        }
     
    }
}
