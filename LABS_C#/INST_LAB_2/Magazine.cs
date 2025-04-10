using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INST_LAB_2
{
    internal class Magazine
    {
        private static int MagazineCount;
        public string Title { get; private set; }
        public Frequency Period { get; private set; }
        public DateTime ReleaseDate { get; private set; }
        
        private Article[] Articles;

        public Magazine()
        {
            Title = "NoMAgazineTitle";
            Period = new Frequency();
            ReleaseDate = DateTime.MinValue;
            MagazineCount += 1;
        }
        public Magazine(string Title, Frequency Period, DateTime ReleaseDate, int MagazineCount)
        {
            this.Title = Title;
            this.Period = Period;
            this.ReleaseDate = ReleaseDate;
            MagazineCount += 1;
        }

    }
}
