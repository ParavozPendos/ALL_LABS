using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INST_LAB_1
{
    class Exam
    {
        public Exam()
        {
            this.Mark = 0;
            this.Subject = "None";
            this.Time = DateTime.MinValue;
        }

        public Exam(int Mark, string Subject, DateTime Time)
        {
            this.Mark = Mark;
            this.Subject = Subject;
            this.Time = Time;
        }

        public int Mark { get; set; }
        public string Subject { get; set; }
        public DateTime Time { get; set; }

        public override string ToString()
        {
            return $"Предмет: {Subject} | Время: {Time:yyyy-MM-dd} | Оценка: {Mark}";
        }
    }
}
