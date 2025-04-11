using System;
using System.Collections.Generic;
using System.Linq;
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

    internal class Magazine
    {
        public string Title { get; set; }
        public int Count { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Frequency Period { get; set; }        
        private Article[] _Articles;
        public Article[] Articles
        {
            get { return _Articles; }
            set { _Articles = value; }
        }
        public Magazine()
        {
            Title = "NoMAgazineTitle";
            Period = new Frequency();
            ReleaseDate = DateTime.MinValue;
            Count = 0;
            Articles = Array.Empty<Article>();            
        }
        public Magazine(string Title, Frequency Period, DateTime ReleaseDate, int Count)
        {
            this.Title = Title;
            this.Period = Period;
            this.ReleaseDate = ReleaseDate;
            this.Count = Count;
            Articles = Array.Empty<Article>();
        }

        public double Average
        {
            get
            {
                if (_Articles == null || _Articles.Length == 0)
                    return 0;

                double temp = 0;
                foreach (var article in _Articles)
                {
                    temp += article.Raiting;
                }
                return temp / _Articles.Length;
            }
        }
        public bool this[Frequency frequency] { get => Period == frequency; }

        public void AddArticles (params Article[] newArticles)
        {
            Array.Resize(ref _Articles, _Articles.Length + newArticles.Length);
            Array.Copy(newArticles, 0, _Articles, _Articles.Length - newArticles.Length, newArticles.Length);
            Array.Sort(Articles, (x, y) => String.Compare(x.Author.Name, y.Author.Name));
        }

        public override string ToString()
        {
            string ArticleList = "";
            if (_Articles != null)
            {
                foreach (var item in _Articles)
                {
                    ArticleList += $"{item.ToString()}\n║{new string(' ', Console.WindowWidth - Console.CursorLeft - 2)}║\n";
                }
            }
            
            return $"Название журнала: {Title} | Тираж: {Count} | Время выпуска: {ReleaseDate:yyyy-MM-dd} | Периодичность: {Period} | \n" +
                $"\n{new string(' ', Console.WindowWidth / 2 - 8)}↓↓↓ СТАТЬИ ↓↓↓ \n\n" +
                $"╔{new string('═', Console.WindowWidth - 2)}╗" +
                //$"║{new string(' ', Console.WindowWidth - 2)}║" +
                $"{ArticleList}" + 
                $"╚{new string('═', Console.WindowWidth - 2)}╝";
                
        }
        public string ToShortString()
        {
            return $"Название журнала: {Title} | Тираж: {Count} | Время выпуска: {ReleaseDate:yyyy-MM-dd} | Периодичность: {Period} | \nСредний рейтинг статей: {Average}";
        }
    }
}
