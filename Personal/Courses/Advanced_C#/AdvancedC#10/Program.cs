using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedC_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.school = Schools.HighSchool;
            

            if (person.school.Equals(Schools.PrimarySchool))
            {
                Console.WriteLine("XYZ");
            }
            else if (person.school.Equals(Schools.HighSchool)) 
            {
                Console.WriteLine("ABC");
            }
            else if (person.school.Equals(Schools.University)) 
            {
                Console.WriteLine("123");    
            }


                Console.ReadLine();
        }


    }

    enum Schools 
    { 
        PrimarySchool,HighSchool,University    
    }

    class Person
    {
        public Person() 
        {
            school = Schools.PrimarySchool;
        }

        public Schools school;
    }
}
