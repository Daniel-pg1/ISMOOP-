using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromHumanToLibraryUser
{
    class Human
    {
        protected string Name;
        protected string SecondName;
        protected DateTime DateBirth;
        public Human()
        {
            Name = "Ivan";
            SecondName = "Ivanov";
            DateBirth = new DateTime(2001, 10, 10);
        }
        public Human(string name, string secondName)
        {
            Name = name;
            SecondName = secondName;
        }
        public Human(string name, string secondName, DateTime datebirth)
        {
            Name = name;
            SecondName = secondName;
            DateBirth = datebirth;
        }
        public Human(Human obj)
        {
            Name = obj.Name;
            SecondName = obj.SecondName;
            DateBirth = obj.DateBirth;
        }
        public string GetName()
        {
            return Name;
        }
        public void SetName(string name)
        {
            if (name.Length > 0)
            {
                Name = name;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public string GetSecondName()
        {
            return SecondName;
        }
        public void SetSecondName(string secondName)
        {
            if (secondName.Length > 0)
            {
                SecondName = secondName;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public DateTime GetDateBirth()
        {
            return DateBirth;
        }
        public void SetDateBirth( DateTime datebirth)
        {
            DateTime datemin = new DateTime(1900, 01, 01);
            DateTime datemax = new DateTime(2100, 01, 01);
            if (datebirth > datemin && datebirth < datemax)
            {
                DateBirth = datebirth;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public static void GetHumanInfo(Human human)
        {
            Console.WriteLine($"Iм'я: {human.GetName()}");
            Console.WriteLine($"Призвiще: {human.GetSecondName()}");
            Console.WriteLine($"Дата народження: {human.GetDateBirth()}");
        }
    }
}
