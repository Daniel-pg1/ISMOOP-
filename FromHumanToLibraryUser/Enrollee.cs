using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromHumanToLibraryUser
{
    class Enrollee : Human
    {
        protected int ZNOgrades;
        protected int SchoolGrades;
        protected string SchoolName;
        public Enrollee()
        {
            ZNOgrades = 190;
            SchoolGrades = 11;
            SchoolName = "School № 100";
        }
        public Enrollee(int zNOgrades, int schoolGrades)
        {
            ZNOgrades = zNOgrades;
            SchoolGrades = schoolGrades;
        }
        public Enrollee(int zNOgrades, int schoolGrades, string schoolName)
        {
            ZNOgrades = zNOgrades;
            SchoolGrades = schoolGrades;
            SchoolName = schoolName;
        }
        public Enrollee(Enrollee obj)
            :base(obj)
        {
            ZNOgrades = obj.ZNOgrades;
            SchoolGrades = obj.SchoolGrades;
            SchoolName = obj.SchoolName;
        }
        public string GetSchoolName()
        {
            return SchoolName;
        }
        public void SetSchoolName(string schoolName)
        {
            if (schoolName.Length > 0)
            {
                SchoolName = schoolName;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public int GetSchoolGrades()
        {
            return SchoolGrades;
        }
        public void SetSchoolGrades(int schoolGrades)
        {
            if (schoolGrades >= 0 && schoolGrades <= 12)
            {
                SchoolGrades = schoolGrades;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public int GetZNOgrades()
        {
            return ZNOgrades;
        }
        public void SetZNOgrades(int zNOgrades)
        {
            if (zNOgrades >= 0 && zNOgrades <= 200)
            {
                ZNOgrades = zNOgrades;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public static void GetEnroleeInfo(Enrollee enrollee)
        {
            GetHumanInfo(enrollee);
            Console.WriteLine($"Бал атестату ЗНО:{enrollee.GetZNOgrades()}");
            Console.WriteLine($"Кiлькiсть балiв за документ про освiту:{enrollee.GetSchoolGrades()}");
            Console.WriteLine($"Назва школи:{enrollee.GetSchoolName()}");
        }
    }
}
