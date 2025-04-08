using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INST_LAB_1
{
    internal class Person
    {
        public Person()
        {
            Name = "None";
            SecondName = "None";
            LastName = "None";
            DateOfBirth = DateTime.MinValue;
        }
        public Person(string Name, string SecondName, string LastName, DateTime DateOfBirth)
        {
            this.Name = Name;
            this.SecondName = SecondName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
        }
        public string Name { get; private set; }
        public string SecondName { get; private set; }
        public string LastName {  get; private set; }
        public DateTime DateOfBirth { get; private set; }

        public override string ToString()
        {
            return $"Имя: {Name} | Фамилия: {SecondName} | Отчество: {LastName} Дата рождения: {DateOfBirth:yyyy-MM-dd}";
        }
        
    }
}
