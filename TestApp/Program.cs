using System;
using MyLibrary;

class Program
{
    static void Main()
    {
        // Методы void
        LibraryMethods.ShowStart();

        // Метод сложения
        int sum = LibraryMethods.Add(10, 5);
        Console.WriteLine("Сумма: " + sum);

        // Метод деления
        double result = LibraryMethods.Divide(10, 2);
        Console.WriteLine("Частное: " + result);

        // Метод возвращения строки
        string info = LibraryMethods.GetInfo();
        Console.WriteLine(info);

        // Второй метод void
        LibraryMethods.ShowEnd();
    }
}