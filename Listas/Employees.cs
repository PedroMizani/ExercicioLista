using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Employees
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }

        public Employees(string nome, int id, double salary)
        {
            Name = nome;
            Id = id;
            Salary = salary;
        }

        public Employees( int id)
        {
            
            Id = id;
            
        }



        public void Aumento(double porcent)
        {
            Salary += Salary * (porcent / 100);
        }

        public override string ToString()
        {
            return "ID: " + Id + ", Name: " + Name + ", Salary: " + Salary;
        }

        }
}
