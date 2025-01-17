﻿using System.Collections;

namespace ProjectTempalte
{
    internal class Program
    {
        static void StackTask()
        {
            Console.WriteLine("Stack Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после реализации класса Stack
                                                        // и как-то протестируйте ваш код
            Console.WriteLine("-------");
        }
        static void DeepLookStackTask()
        {
            Console.WriteLine("DeepLookStack Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после реализации класса DeepLookStack
                                                        // и как-то протестируйте ваш код
            Console.WriteLine("-------");
        }
        static void QueueTask()
        {
            Console.WriteLine("Queue Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после реализации класса Queue
                                                        // и как-то протестируйте ваш код
            Console.WriteLine("-------");
        }
        // При работе с файлами, создавайте и наполняйте их сами. Но не забывайти использовать относительные пути
        static void StringTask()
        {
            Console.WriteLine("String Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: прочитать данные из файла (реализуйте и используйте функцию ReadFromFile из файла Functions.cs) и
            // Вывести:
            // * количество слов в тексте
            // * самое длинное слово
            // Можно считать, что слова разделены пробелами. Вместо явных циклов используйте LINQ.
            Console.WriteLine("-------");
        }
        static void RegexTask()
        {
            Console.WriteLine("Regex Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: написать Regex, который сумеет распознать email адрес.
            // Прочитать данные из файла и вывести количество email адресов.
            // Слов (а потенциально и адресов) в строке может быть несколько
            // Можно считать, что слова разделены пробелами
            Console.WriteLine("-------");
        }
        static void BinaryTask()
        {
            Console.WriteLine("Binary Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: реализовать функции чтения из бинароного файла и записи в него в Functions.cs.
            // Записать некоторое количество целых чисел в бинарный файл.
            // После прочитать этот же бинарный файл и вывести считанные значения на экран
            Console.WriteLine("-------");
        }
        static void DictionaryTask()
        {
            Console.WriteLine("Dictionary Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: создать Dictionary, где ключ - имя студента, а значение - лист его оценок по предметам за семестр.
            // Заполните словарь для 3-4 студентов.
            // Запросите у пользователя строку - имя студента, по которому он хочет узнать среднюю оценку.
            // Выведите результат. Вместо явных циклов используйте LINQ.
            Console.WriteLine("-------");
        }
        static void RecursionTask()
        {
            Console.WriteLine("Recursion Task");
            Console.WriteLine("Здесь пока ничего нет"); // сотрите эту строку после выполнения условий из TODO ниже
            // TODO: рекурсивно описать функцию MinDigit(int n) (находится в Functions.cs),
            // которая находит наименьшую цифру в десятичной записи неотрицательного целого числа N.
            // Например, MinDigit(27316) = 1.
            Console.WriteLine("-------");
        }
        static void Main(string[] args)
        {
            StackTask();
            DeepLookStackTask();
            QueueTask();
            StringTask();
            StringTask();
            RegexTask();
            BinaryTask();
            DictionaryTask();
            RecursionTask();
        }
    }
}
