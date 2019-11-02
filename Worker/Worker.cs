using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Worker
    {
        protected string Name;
        protected int Year;
        protected int Month;
        protected Company Workplace = new Company();

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
        public int GetYear()
        {
            return Year;
        }
        public void SetYear(short year)
        {
            if (year > 0)
            {
                Year = year;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public int GetMonth()
        {
            return Month;
        }
        public void SetMonth(int month)
        {
            if (month > 0 && month< 13)
            {
                Month = month;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        
        public Company WorkPlace
        {
            get
            {
                return Workplace;
            }
            set
            {
                Workplace = value;
            }
        }
        public Worker()
        {
            Name = "Ivanov I. V.";
            Year = 2015;
            Month = 10;
            Workplace = new Company();
        }
        public Worker(string name, short year, int month)
        {
            Name = name;
            Year = year;
            Month = month;
        }
        public Worker(string name, short year, int month, string companyName, string position, int sallary)
        {
            Name = name;
            Year = year;
            Month = month;
            Workplace = new Company(companyName, position, sallary);
        }
        public Worker(Worker previousWorker)
        {
            Name = previousWorker.Name;
            Year = previousWorker.Year;
            Month = previousWorker.Month;
            Workplace = previousWorker.Workplace;
        }
        public int GetWorkExperience(int Years, int Month)
        {
            int resultExp, months, years;
            months = DateTime.Now.Month + (12 - Month);
            years = DateTime.Now.Year - (Years + 1);
            resultExp = years * 12 + months;
            return resultExp;
        }
        public int GetTotalMoney(int Years, int Month)
        {
            int totalMoney = GetWorkExperience(Years, Month) *  WorkPlace.GetSallary();
            return totalMoney;
        }
        public void GetWorkerInfo(Worker worker  )
        {
            Console.WriteLine($"Iм'я: {worker.Name}");
            Console.WriteLine($"Рiк початку роботи: {worker.Year}");
            Console.WriteLine($"Мiсяць початк у роботи: {worker.Month}");
            Console.WriteLine($"Стаж роботи: {GetWorkExperience(worker.Year, worker.Month)} мiсяцi");
            Console.WriteLine($"Cума зароблених коштiв: {GetTotalMoney(worker.Year, worker.Month)} грн.");
            Console.WriteLine($"Назва команiї: {worker.WorkPlace.GetCompanyName()}");
            Console.WriteLine($"Посада: {worker.WorkPlace.GetPosition()}");
            Console.WriteLine($"Заробiтня плата: {worker.WorkPlace.GetSallary()} грн.");
            Console.WriteLine("------------------------------");
        }
    }
}
