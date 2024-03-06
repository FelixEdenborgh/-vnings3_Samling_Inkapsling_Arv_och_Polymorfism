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

                Person newP = handler.CreatePerson(25, "kalle", "Svennsson", 150, 75);
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


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            
            
        }
    }
}
