using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace INST_LAB_2
{
    enum Frequency
    {
        Weekly,
        Monthly,
        Yearly 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //PERSONS
            Person chell_1 = new Person("Гандон", "Дебиляев", "Уродович", new DateTime(2004, 8, 7));
            Person chell_2 = new Person("Тварь", "Сучеева", "Уродовна", new DateTime(1999, 2, 5));
            Person chell_3 = new Person("Антон", "Антонов", "Антонович", new DateTime(1888, 4, 2));

            //MAGAZINES
            Magazine magazine = new Magazine("Произведения искуства", Frequency.Monthly, new DateTime(2000, 5, 3), 743);
            magazine.AddArticles(
                new Article(chell_1, "Каловые сталактиты", 100),
                new Article(chell_2, "Лужи мочи в подъезде", 34),
                new Article(chell_3, "Обблеванные мусорки", 77)
            );

            Console.WriteLine("Полная инфа о журнале:");
            Console.WriteLine(magazine.ToString());
            Console.WriteLine();

            magazine.AddArticles(
                new Article(chell_1, "Каловые сталогмиты", 11),
                new Article(chell_3, "Причины восстания бомжей", 0)
            );

            Console.WriteLine("Полная инфа о журнале + новые статьи:");
            Console.WriteLine(magazine.ToString());
            Console.WriteLine();

            Console.WriteLine("короткая инфа о журнале:");
            Console.WriteLine(magazine.ToShortString());
            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
