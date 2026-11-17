using System;

namespace MyLibrary
{
    public class LibraryMethods
    {
        // Первый метод void
        public static void ShowStart()
        {
            Console.WriteLine("Библиотека успешно подключена!");
        }

        // Второй метод void
        public static void ShowEnd()
        {
            Console.WriteLine("Работа программы завершена.");
        }

        // Метод возвращает целое число
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Метод возвращает вещественное число
        public static double Divide(double a, double b)
        {
            return a / b;
        }

        // Метод возвращает строку
        public static string GetInfo()
        {
            return "MyLibrary - моя DLL-библиотека";
        }
    }
}