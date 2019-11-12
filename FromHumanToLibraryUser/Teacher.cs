using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromHumanToLibraryUser
{
    class Teacher : Human
    {
        protected string Position;
        protected string Department;
        protected string University;
        public Teacher()
        {
            Position = "Rektor";
            Department = "IPZ";
            University = "Zhytomyrska Politechnica";

        }
        public Teacher(string position, string department)
        {
            Position = position;
            Department = department;
        }
        public Teacher(string position, string department, string university)
        {
            Position = position;
            Department = department;
            University = university;
        }
        public Teacher(Teacher obj)
            :base(obj)
        {
            Position = obj.Position;
            Department = obj.Department;
            University = obj.University;
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
        public string GetDepartment()
        {
            return Department;
        }
        public void SetDepartment(string department)
        {
            if (department.Length > 0)
            {
                Department = department;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public string GetUniversity()
        {
            return University;
        }
        public void SetUniversity(string university)
        {
            if (university.Length > 0)
            {
                University = university;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public static void GetTeacherInfo(Teacher teacher)
        {
            GetHumanInfo(teacher);
            Console.WriteLine($"Посада:{teacher.GetPosition()}");
            Console.WriteLine($"Кафедра:{teacher.GetDepartment()}");
            Console.WriteLine($"Назва ВНЗ:{teacher.GetUniversity()}");
        }
    }
}
