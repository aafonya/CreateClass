using System;
using System.Collections.Generic;
using System.Text;

namespace CreateClass
{
    class Employee : Person
    {
        private String salary;
        private String profession;

        public Employee(string name, int dateBirth, String salary, String profession) : base(name, dateBirth)
        {
            this.salary = salary;
            this.profession = profession;
        }


    }
}
