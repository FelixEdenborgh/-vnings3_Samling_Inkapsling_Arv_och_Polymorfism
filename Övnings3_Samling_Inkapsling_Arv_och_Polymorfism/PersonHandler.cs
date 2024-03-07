using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övnings3_Samling_Inkapsling_Arv_och_Polymorfism
{
    internal class PersonHandler
    {
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(int age, string fName, string lName, double height, double weight) 
        {
            Person newPerson = new Person();
            newPerson.Age = age;
            newPerson.FName = fName;
            newPerson.LName = lName;
            newPerson.Height = height;
            newPerson.Weight = weight;

            return newPerson;
        }

        public double CheckBMI(Person person)
        {
     
            double bmi = person.Weight / ((person.Height/100) * (person.Height/100));

            return bmi;
        }


        public static bool CheckIfUserIsAlowedToGoToANightClub(Person person)
        {
            int age = person.Age;
            if (age > 21)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
