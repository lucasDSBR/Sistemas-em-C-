using System;
using Contrato.Entities;
using Contrato.Entities.Enums;
using System.Globalization;
namespace Contrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter departament's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level(Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valueperhour, hours);
                worker.addContract(contract);
            }

            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            //pegar apenas duas posições a partir da posição 0
            int month = int.Parse(monthAndYear.Substring(0, 2));
            //pegar posições a partir da posição 3
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: "+ worker.Name);
            Console.WriteLine("Department: "+ worker.Departament.Name);
            Console.WriteLine($"Income for {monthAndYear} : {worker.income(year, month).ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
