using System;
using System.Collections.Generic;

namespace Workers_TestTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> workers = new List<Worker>
            {
                new FixedPayWorker { Id = 1, Name = "Vasya" },
                new FixedPayWorker { Id = 2, Name = "Petro" },
                new FixedPayWorker { Id = 3, Name = "Ivan" },
                new FixedPayWorker { Id = 4, Name = "Anna" },
                new PayByHourWorker { Id = 5, Name = "Olya" },
                new PayByHourWorker { Id = 6, Name = "Andriy" },
                new PayByHourWorker { Id = 7, Name = "Oleg" },
                new PayByHourWorker { Id = 8, Name = "Max" }
            };

            Random random = new Random();
            foreach (Worker worker in workers)
            {
                worker.СalculateSalary(random.Next(10, 10000));
                //worker.СalculateSalary(1000);
            }

            Show(workers, 0, workers.Count - 1);
            Console.WriteLine();

            // a) Упорядочить всю последовательность работников по убыванию 
            // среднемесячного заработка. При совпадении зарплаты – упорядочивать
            // данные по алфавиту по имени. Вывести идентификатор работника,
            // имя и среднемесячный заработок для всех элементов списка.

            Sort.Quick_Sort(workers, 0, workers.Count - 1);
            Show(workers, 0, workers.Count - 1);

            // b) Вывести первые 5 имен работников из полученного в пункте а) списка.

            if (workers.Count >= 5)
            {
                Console.WriteLine();
                ShowName(workers, 0, 4);
            }

            // c) Вывести последние 3 идентификатора работников из полученного в пункте а) списка.

            if (workers.Count >= 3)
            {
                Console.WriteLine();
                ShowId(workers, workers.Count - 3, workers.Count - 1);
            }

            Console.ReadKey();
        }
        

        public static void Show(IList<Worker> workers, int first, int last)
        {
            for (int i = first; i <= last; i++)
            {                
                Console.WriteLine($"{workers[i].Id} {workers[i].Name} {workers[i].Salary}");
            }
        }

        public static void ShowId(IList<Worker> workers, int first, int last)
        {
            for (int i = first; i <= last; i++)
            {
                Console.WriteLine($"{workers[i].Id}");
            }
        }

        public static void ShowName(IList<Worker> workers, int first, int last)
        {
            for (int i = first; i <= last; i++)
            {
                Console.WriteLine($"{workers[i].Name}");
            }
        }
    }
}
