using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Consol
{
    class Task3
    {

        static void Main3()
        {
            //var payment = "lukoil24340sber2424oro24345microsoft343553";
            Console.WriteLine("Введите строку платежа, а затем нажмите Enter");
            string payment = Console.ReadLine();

            // Проверка на длину имени компании
            if (Regex.IsMatch(payment, "([a-zA-Zа-яА-Я]{10,})"))
            {
                Console.WriteLine("Одно из имен в строке больше 10 символов");
            }
            else
            {
                // Разделение строки с помощю регулярного выражения 
                MatchCollection matchList = Regex.Matches(payment, "([a-zA-Zа-яА-Я]{1,10})(\\d+)");
                Int64 result = 0;
                for (int i = 0; i < matchList.Count(); i++)
                {
                    // Int 64 для платежей больше 2 147 483 647(Ну а вдруг)
                    Int64 matchVar = Convert.ToInt64(matchList[i].Groups[2].Value);
                    result += matchVar;
                }
                Console.WriteLine("Сумма платежа: {0}", result);
            }
        }
         
    }
}
