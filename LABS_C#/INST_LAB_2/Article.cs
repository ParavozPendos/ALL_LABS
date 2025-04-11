using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace INST_LAB_2
{
    internal class Article
    {
        public Person Author { get; set; }
        public string Title { get; set; }
        public double Raiting { get; set; }

        public Article()
        {
            Author = new Person();
            Title = "NoTitle";
            Raiting = 0;
        }
        public Article(Person Author, string Title, double Raiting)
        {
            this.Author = Author;
            this.Title = Title;
            this.Raiting = Raiting;
        }
        public override string ToString()
        {
            string str1 = $"Имя: {Author.Name} | Фамилия: {Author.SecondName} | Отчество: {Author.LastName} | Дата рождения: {Author.DateOfBirth:yyyy-MM-dd}";
            string str2 = $"Название статьи: {Title} | Рейтинг статьи: {Raiting}";

            return $"║ {str1}{new string(' ', Console.WindowWidth - str1.Length-3)}║\n" +
            $"║ {str2}{new string(' ', Console.WindowWidth - str2.Length-3)}║";
        }
    }
}
