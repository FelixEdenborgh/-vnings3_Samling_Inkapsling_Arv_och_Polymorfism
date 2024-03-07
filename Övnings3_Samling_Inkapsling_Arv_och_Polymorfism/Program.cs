namespace Övnings3_Samling_Inkapsling_Arv_och_Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person person = new Person();
                person.Age = 15;
                person.FName = "Kalle";
                person.LName = "Anka";
                Console.WriteLine(person.Age);

                PersonHandler handler = new PersonHandler();
                handler.SetAge(person, 25);
                Console.WriteLine(person.Age);

                Person newP = handler.CreatePerson(15, "kalle", "Svennsson", 150, 75);
                Console.WriteLine($"{newP.Age}, {newP.FName}, {newP.LName}, {newP.Height}, {newP.Weight}");

                double bmi = handler.CheckBMI(newP);
                if(bmi < 18.5)
                {
                    Console.WriteLine($"{newP.FName} har en bmi på {bmi} och det är undervikt");
                }
                else if(bmi >= 18.5 && bmi <= 24.9)
                {
                    Console.WriteLine($"{newP.FName} har en bmi på {bmi} och är har NormalVikt");
                }
                else if(bmi >= 25.0 && bmi <= 29.9)
                {
                    Console.WriteLine($"{newP.FName} har en bmi på {bmi} och Övervikt");
                }
                else
                {
                    Console.WriteLine($"{newP.FName} har en bmi på {bmi} och det är Hög Fetma");
                }

                // för att kalla på en statisk metod så behöver du kalla på Class namnet och inte till en instans av den. dvs PersonHandler och inte handler
                bool isAllowed = PersonHandler.CheckIfUserIsAlowedToGoToANightClub(newP);
                if(isAllowed == true) { Console.WriteLine($"{newP.FName} is allowed to go into nightclubs in Stockholm city"); }
                else { Console.WriteLine($"{newP.FName} arent allowed to go into nightclubs doe {newP.FName} are not old enough!");  }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            
        }
    }
}
