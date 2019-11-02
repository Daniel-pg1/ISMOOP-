using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadWorkersArray();
            Worker worker1 = new Worker();
            PrintWorker(worker1);
            Worker worker2 = new Worker(worker1);
            worker2.SetName("Jash A. B.");
            worker2.SetYear(2019);
            worker2.SetMonth(11);
            worker2.WorkPlace.SetName("Inc Sebatjan");
            worker2.WorkPlace.SetPosition("program developer");
            worker2.WorkPlace.SetSallary(56000);
            PrintWorker(worker2);
            PrintWorkers();
            GetWorkersInfo(ReadWorkersArray(), out int min, out int max);
            Console.WriteLine($"Найбiльша заробiтня плата: {max}");
            Console.WriteLine($"Найменша заробiтня плата: {min}");
            Console.WriteLine("\nЗарплати за спаданням:");
            int i = 0;
            foreach (var worker in ReadWorkersArray())
            {
                Console.Write($"Iм'я: {worker.GetName()}\n");
                int[] salarr = SortWorkerBySalary(ReadWorkersArray());
                Console.WriteLine($"Зарплата:{salarr[i]} грн.");
                i++;
            }
            Console.WriteLine($"\nСтаж за зростянням:");
            int j = 0;
            foreach (var worker in ReadWorkersArray())
            {
                Console.Write($"Iм'я: {worker.GetName()}\n");
                int[] workerexparr = SortWorkerByWorkExperience(ReadWorkersArray());
                Console.WriteLine($"Стаж: {workerexparr[j]}");
                j++;
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        public static Worker[] ReadWorkersArray()
        {
            Worker[] allWorkers = new Worker[]
            {
                new Worker ("Hanks T. S.", 2019, 5, "Microsoft", "Manager", 50301),
                new Worker ("White O. A.", 2013, 11,"Sony", "Layer", 21132),
                new Worker ("Morozov M. V.", 2010, 3, "Zhytomyrska Politechnica", "ProRector", 13000),
                new Worker ("Gissa A. A.", 2002, 12, "NovaMedical", "Director", 12423)
            };
            return allWorkers;
        }
        public static void PrintWorker(Worker worker)
        {
            worker.GetWorkerInfo(worker);
        }
        public static void PrintWorkers()
        {
            foreach (Worker worker in ReadWorkersArray())
            {
                PrintWorker(worker);
            }

        }
        public static void GetWorkersInfo(Worker[] workerArr, out int min, out int max)
        {
            min = 100000;
            max = -100000;
            foreach (Worker worker in workerArr)
            {
                if (worker.WorkPlace.GetSallary() < min)
                {
                    min = worker.WorkPlace.GetSallary();
                }
                if (worker.WorkPlace.GetSallary() > max)
                {
                    max = worker.WorkPlace.GetSallary();
                }
            }

        }
        public static int[] SortWorkerBySalary(Worker[] workers)
        {
            int[] salaryarr = new int[workers.Length];
            for (int i = 0; i < workers.Length; i++)
            {
                Worker worker = workers[i];
                salaryarr[i] = worker.WorkPlace.GetSallary();
            }
            for (int i = 1, tmp; i < salaryarr.Length; i++)
            {
                tmp = salaryarr[i];
                for (int j = i - 1; j >= 0 && salaryarr[j] < tmp; j--)
                {
                    salaryarr[j + 1] = salaryarr[j];
                    salaryarr[j] = tmp;
                }
            }
            return salaryarr;
        }
        public static int[] SortWorkerByWorkExperience(Worker[] workers)
        {
            int[] workerexparr = new int[workers.Length];
            for (int i = 0; i < workers.Length; i++)
            {
                Worker worker = workers[i];
                int Years = worker.GetYear();
                int Month = worker.GetMonth();
                workerexparr[i] = worker.GetWorkExperience(Years, Month);
            }
            for (int i = 1, tmp; i < workerexparr.Length; i++)
            {
                tmp = workerexparr[i];
                for (int j = i - 1; j >= 0 && workerexparr[j] > tmp; j--)
                {
                    workerexparr[j + 1] = workerexparr[j];
                    workerexparr[j] = tmp;
                }
            }
            return workerexparr;
        }
    }

}
