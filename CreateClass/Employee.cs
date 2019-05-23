﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateClass
{
    class Employee : Person
    {
        public decimal Salary { get; private set; }
        public string Profession { get; private set; }
        public Employee(decimal salary, string profession, string name, DateTime birthDate, string gender) : base(name, birthDate, gender)
        {
            Salary = salary;
            Profession = profession;
        }
        public override string ToString()
        {
            return "Employee: " + Name + " " + BirthDate + " " + Gender + " " + Salary + " " + Profession;
        }
    }
}
