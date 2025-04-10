using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            Article article = new Article(new Person("Иван", "Иванов", "Иванович", new DateTime(2004, 8, 7)), "Роботы-пылесосы-убийцы", 100);
            Console.WriteLine(article.ToString());
            Console.ReadKey(true);
        }
    }
}
