using System;
using System.Collections.Generic;
using System.Text;

namespace CreateClass
{
    class Person
    {
        private String name;
        private int dateBirth;

        public Person(String name, int dateBirth)
        {
            this.name = name;
            this.dateBirth = dateBirth;
        }

        public String getName()
        {
            return this.name;
        }

        public int getDateBirth()
        {
            return this.dateBirth;
        }

        enum Gender { Female, Male }

        public override string ToString()
        {
            return String.Format("This instance of my object has the following: Name = {0}, BirthDate = {1}", name, dateBirth);
        }
    }
}
