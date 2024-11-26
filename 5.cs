using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema5
{
    internal class Program
    {
        
        
            

public class StringComparisonExample 
        { 
        
            public static void Main(string[] args)
            {
                string str1 = "Hello";
                string str2 = "hello";
                string str3 = "Hello, world!";
                string str4 = "Hello";


                // Compare() - сравнение строк с учетом регистра и культуры
                Console.WriteLine($"Compare(\"{str1}\", \"{str2}\"): {string.Compare(str1, str2)}"); // -1 (str1 < str2)
                Console.WriteLine($"Compare(\"{str1}\", \"{str4}\"): {string.Compare(str1, str4)}"); // 0 (str1 == str4)

                // Equals() - сравнение строк с учетом регистра и культуры
                Console.WriteLine($"Equals(\"{str1}\", \"{str2}\"): {str1.Equals(str2)}"); // false
                Console.WriteLine($"Equals(\"{str1}\", \"{str4}\"): {str1.Equals(str4)}"); // true

                // CompareOrdinal() - сравнение строк без учета регистра и культуры (по порядку кодов символов)
                Console.WriteLine($"CompareOrdinal(\"{str1}\", \"{str2}\"): {string.CompareOrdinal(str1, str2)}"); // -32 (по разнице кодов символов 'H' и 'h')
                Console.WriteLine($"CompareOrdinal(\"{str1}\", \"{str4}\"): {string.CompareOrdinal(str1, str4)}"); // 0 (str1 == str4)


                // IndexOf() - поиск подстроки
                Console.WriteLine($"IndexOf(\"world\" in \"{str3}\"): {str3.IndexOf("world")}"); // 7 (позиция подстроки)
                Console.WriteLine($"IndexOf(\"World\" in \"{str3}\"): {str3.IndexOf("World")}"); // -1 (подстрока не найдена)

                // Contains() - проверка на наличие подстроки
                Console.WriteLine($"Contains(\"world\" in \"{str3}\"): {str3.Contains("world")}"); // true
                Console.WriteLine($"Contains(\"World\" in \"{str3}\"): {str3.Contains("World")}"); // false


                // Операторы == и !=
                Console.WriteLine($"str1 == str2: {str1 == str2}"); // false
                Console.WriteLine($"str1 == str4: {str1 == str4}"); // true
                Console.WriteLine($"str1 != str2: {str1 != str2}"); // true
                Console.WriteLine($"str1 != str4: {str1 != str4}"); // false
            }
        }


    }
}

