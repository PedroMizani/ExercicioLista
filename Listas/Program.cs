using System;
using System.Globalization;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> list = new List<Employees>();


            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Emplyoee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Employees(name, id, salary));
            }

            //-----------------------------------------------------------------------------------

            Console.WriteLine("-----------------------");

            Console.Write("Enter the employee id that will have salary increase : ");
            int id2 = int.Parse(Console.ReadLine());
            Employees pos = list.Find(x => x.Id == id2);

            //-----------------------------------------------------------------------------------
            if (pos != null)
            {
                Console.WriteLine("-----------------------");
                Console.Write("Enter the percentage: ");
                double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                pos.Aumento(porc);
                
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }


            //------------------------------------------------------------------------------------
            Console.WriteLine("-----------------------");
            Console.WriteLine("Updated list of employees: ");

            foreach (Employees obj in list)
            {
                Console.WriteLine(obj);

            }

            //teste de git

        }
    }
}