using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    internal class Personel
    {
        public Personel(int ıd, string name, string lastName, decimal salary)
        {
            Id = ıd;
            Name = name;
            LastName = lastName;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"{Name,-10} {LastName,-15} {Salary,-10}";
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
    }
}
