using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Company
    {
        protected string CompanyName;
        protected string Position;
        protected int Sallary;
        public string GetCompanyName()
        {
            return CompanyName;
        }
        public void SetName(string companyName)
        {
            if (companyName.Length > 0)
            {
                CompanyName = companyName;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public string GetPosition()
        {
            return Position;
        }
        public void SetPosition(string position)
        {
            if (position.Length > 0)
            {
                Position = position;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public int GetSallary()
        {
            return Sallary;
        }
        public void SetSallary(int sallary)
        {
            if (sallary > 0)
            {
                Sallary = sallary;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public Company()
        {
            CompanyName = "ISM";
            Position = "Director";
            Sallary = 50000;
        }
        public Company(string companyName, string position)
        {
            CompanyName = companyName;
            Position = position;
        }
        public Company(string companyName, string position, int sallary)
        {
            CompanyName = companyName;
            Position = position;
            Sallary = sallary;
        }
        public Company(Company previousCompany)
        {
            CompanyName = previousCompany.CompanyName;
            Position = previousCompany.Position;
            Sallary = previousCompany.Sallary;
        }

    }
}
