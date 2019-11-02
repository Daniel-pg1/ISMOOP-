using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromHumanToLibraryUser
{
    class Student : Enrollee
    {
        protected int Course;
        protected string Group;
        protected string Faculty;
        protected string University;
        public Student()
        {
            Course = 1;
            Group = "IPZ-19-1(2)";
            Faculty = "IKT";
            University = "Zhytomyrska Politechnica";
        }
        public Student(int course, string group, string faculty)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
        }
        public Student(int course, string group, string faculty, string university)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            University = university;
        }
        public Student(Student obj)
        {
            Course = obj.Course;
            Group = obj.Group;
            Faculty = obj.Faculty;
            University = obj.University;
        }
        public int GetCourse()
        {
            return Course;
        }
        public void SetCourse(int course)
        {
            if (course > 0 && course < 6)
            {
                Course = course;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public string GetGroup()
        {
            return Group;
        }
        public void SetGroups(string group)
        {
            if (group.Length > 0)
            {
                Group = group;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public string GetFaculty()
        {
            return Faculty;
        }
        public void SetFaculty(string faculty)
        {
            if (faculty.Length > 0)
            {
                Faculty = faculty;
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
        public static void GetStudentInfo(Student student)
        {
            GetHumanInfo(student);
            GetEnroleeInfo(student);
            Console.WriteLine($"Курс:{student.GetCourse()}");
            Console.WriteLine($"Група:{student.GetGroup()}");
            Console.WriteLine($"Факультет:{student.GetFaculty()}");
            Console.WriteLine($"Назва ВНЗ:{student.GetUniversity()}");
        }
    }
}
