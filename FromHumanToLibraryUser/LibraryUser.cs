using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromHumanToLibraryUser
{
    class LibraryUser : Human
    {
        protected int LibraryTicketNumber;
        protected DateTime DateGiving;
        protected int AmountMonthlyPayment;
        public LibraryUser()
        {
            LibraryTicketNumber = 10546;
            AmountMonthlyPayment = 350;
            DateGiving = new DateTime(2019, 10, 10);
        }
        public LibraryUser(int libraryTicketNumber, int amountMonthlyPayment)
        {
            LibraryTicketNumber = libraryTicketNumber;
            AmountMonthlyPayment = amountMonthlyPayment;
        }
        public LibraryUser(int libraryTicketNumber, int amountMonthlyPayment, DateTime dateGiving)
        {
            LibraryTicketNumber = libraryTicketNumber;
            AmountMonthlyPayment = amountMonthlyPayment;
            DateGiving = dateGiving;
        }
        public LibraryUser(LibraryUser obj)
            : base(obj)
        {
            LibraryTicketNumber = obj.LibraryTicketNumber;
            AmountMonthlyPayment = obj.AmountMonthlyPayment;
            DateGiving = obj.DateGiving;
        }
        public int GetLibraryTicketNumber()
        {
            return LibraryTicketNumber;
        }
        public void SetLibraryTicketNumber(int libraryTicketNumber)
        {
            if (libraryTicketNumber > 0)
            {
                LibraryTicketNumber = libraryTicketNumber;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public int GetAmountMonthlyPayment()
        {
            return AmountMonthlyPayment;
        }
        public void SetAmountMonthlyPayment(int amountMonthlyPayment)
        {
            if (amountMonthlyPayment > 0)
            {
                AmountMonthlyPayment = amountMonthlyPayment;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public DateTime GetDateGiving()
        {
            return DateGiving;
        }
        public void SetDateGiving(DateTime dateGiving)
        {
            DateTime datemin = new DateTime(1900, 01, 01);
            DateTime datemax = new DateTime(2100, 01, 01);
            if (dateGiving > datemin && dateGiving < datemax)
            {
                DateGiving = dateGiving;
            }
            else
            {
                Console.WriteLine("Помилка вводу значення!");
            }
        }
        public static void GetLibraryUserInfo(LibraryUser libraryUser)
        {
            GetHumanInfo(libraryUser);
            Console.WriteLine($"Номер читацького квитка:{libraryUser.GetLibraryTicketNumber()}");
            Console.WriteLine($"Дата видачi:{libraryUser.GetDateGiving()}");
            Console.WriteLine($"Розмiр щомiсячного читацького внеску:{libraryUser.GetAmountMonthlyPayment()}");
        }
    }
}
