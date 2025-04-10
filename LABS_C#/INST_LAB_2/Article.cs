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
            return $"Имя: {Author.Name} | Фамилия: {Author.SecondName} | Отчество: {Author.LastName} | Дата рождения: {Author.DateOfBirth:yyyy-MM-dd}\n" +
            $"Название статьи: {Title} | Рейтинг статьи: {Raiting}";
        }
    }
}
