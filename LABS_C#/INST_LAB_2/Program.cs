using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace INST_LAB_2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //PERSONS
            Person chell_1 = new Person("Гандон", "Дебиляев", "Уродович", new DateTime(2004, 8, 7));
            Person chell_2 = new Person("Тварь", "Сучеева", "Уродовна", new DateTime(1999, 2, 5));
            Person chell_3 = new Person("Антон", "Антонов", "Антонович", new DateTime(1888, 4, 2));

            //MAGAZINES
            Magazine magazine = new Magazine("Произведения искуства", Frequency.Monthly, new DateTime(2025, 5, 3), 743);
            magazine.AddArticles(
                new Article(chell_1, "Каловые сталактиты", 100),
                new Article(chell_2, "Лужи мочи в подъезде", 34),
                new Article(chell_3, "Обблеванные мусорки", 77)
            );
            
            ColorfulPrint("Проверка периодичности выпуска:\n", ConsoleColor.DarkRed);
            Console.WriteLine("Еженедельная: " + magazine[Frequency.Weekly]);
            Console.WriteLine("Ежемесячная: " + magazine[Frequency.Monthly]);
            Console.WriteLine("Ежегодная: " + magazine[Frequency.Yearly]);
            Console.WriteLine();
            
            ColorfulPrint("Полная инфа о журнале:\n", ConsoleColor.DarkRed);
            Console.WriteLine(magazine.ToString());
            Console.WriteLine();

            magazine.AddArticles(
                new Article(chell_1, "Каловые сталогмиты", 11),
                new Article(chell_3, "Причины восстания бомжей", 0)
            );
            
            ColorfulPrint("Полная инфа о журнале + новые статьи:\n", ConsoleColor.DarkRed);

            Console.WriteLine(magazine.ToString());
            Console.WriteLine();

            ColorfulPrint("Краткая инфа о журнале:\n", ConsoleColor.DarkRed);
            Console.WriteLine(magazine.ToShortString());
            Console.WriteLine();

            ColorfulPrint("Проверка производительности:\n", ConsoleColor.DarkRed);

            const int SIZE = 10000;
            Article Test = new Article(chell_3, "TEST", 100);

            Article[] ARR_0 = new Article[SIZE*SIZE];
            float start_0 = Environment.TickCount;
            for (int i = 0; i < SIZE*SIZE; i++)
            {
                ARR_0[i] = Test;
            }
            Console.WriteLine("Одномерный: "+(Environment.TickCount - start_0) + " tick");

            Article[,] ARR_1 = new Article[SIZE,SIZE];
            float start_1 = Environment.TickCount;
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    ARR_1[i, j] = Test;
                }
            }
            Console.WriteLine("Двумерный: " + (Environment.TickCount - start_1) + " tick");

            Article[][] ARR_2 = new Article[SIZE][];
            for (int i = 0; i < SIZE; i++)
            {
                ARR_2[i] = new Article[SIZE]; 
            }
            float start_2 = Environment.TickCount;
            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                {
                    ARR_2[i][j] = Test;
                }
            }
            Console.WriteLine("Зубчатый: " + (Environment.TickCount - start_2) + " tick");
            Console.WriteLine();

            Console.ReadKey(true);
        }




        // ДЛЯ УДОБСТВА
        public static void ColorfulPrint(string str, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(str);
            Console.ResetColor();
        }
    }
}
