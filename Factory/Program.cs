using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = DataFactory.GetPersons();
            foreach (var person in persons)
            {
                var fullName = string.Format("First Name: {0} \nMiddle Name: {1} \nLast Name: {2} \n",person.FirstName,person.MiddleName, person.LastName);
                Console.Write(fullName);
            }
            Console.ReadKey();

        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }

    public class DataFactory {


        public static IList<Person> GetPersons()
        {
            var person = new Person() { };
            var persons = new List<Person>
            {
                new Person  { FirstName = "Antonio", MiddleName = "Vargas", LastName = "Luna" },
                new Person  { FirstName = "Juan", MiddleName = "Jacinto", LastName = "Luna" },
            };
            return persons;
        }
    }
    
 }
