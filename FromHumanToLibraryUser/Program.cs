using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromHumanToLibraryUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Людина:");
            Human human = new Human();
            Human.GetHumanInfo(human);
            Human human2 = new Human(human);
            human2.SetName("Daniell");
            human2.SetSecondName("Dosen");
            Human.GetHumanInfo(human2);
            Console.WriteLine("--------------------");
            Console.WriteLine("Абiтурiєнт:");
            Enrollee enrolee = new Enrollee();
            Enrollee.GetEnroleeInfo(enrolee);
            Enrollee enrollee1 = new Enrollee(enrolee);
            enrollee1.SetName("Dennis");
            enrollee1.SetSecondName("Polonevich");
            enrollee1.SetSchoolGrades(11);
            enrollee1.SetSchoolName("ZEL 24");
            enrollee1.SetZNOgrades(185);
            Enrollee.GetEnroleeInfo(enrollee1);
            Console.WriteLine("--------------------");
            Console.WriteLine("Студент:");
            Student student = new Student();
            Student.GetStudentInfo(student);
            Student student1 = new Student(student);
            student1.SetFaculty("FPUP");
            student1.SetName("Pasha");
            student1.SetName("Visga");
            student1.SetCourse(3);
            student1.SetGroups("P23");
            Student.GetStudentInfo(student1);
            Console.WriteLine("--------------------");
            Console.WriteLine("Викладач:");
            Teacher teacher = new Teacher();
            Teacher teacher1 = new Teacher(teacher);
            Teacher.GetTeacherInfo(teacher);
            teacher1.SetName("Alex");
            teacher1.SetName("Ponanarev");
            teacher1.SetDepartment("Avtomatyzacia ta robototechnica");
            teacher1.SetPosition("Zaviduvach Kafedry");
            teacher1.SetUniversity("KPI");
            Teacher.GetTeacherInfo(teacher1);
            Console.WriteLine("--------------------");
            Console.WriteLine("Користувач бiблiотеки:");
            LibraryUser user = new LibraryUser();
            LibraryUser user1 = new LibraryUser(user);
            LibraryUser.GetLibraryUserInfo(user);
            user1.SetName("Maria");
            user1.SetName("Zorkaya");
            user1.SetAmountMonthlyPayment(512);
            user1.SetLibraryTicketNumber(10023);
            LibraryUser.GetLibraryUserInfo(user1);
            Console.WriteLine("--------------------");
        }
    }
}
