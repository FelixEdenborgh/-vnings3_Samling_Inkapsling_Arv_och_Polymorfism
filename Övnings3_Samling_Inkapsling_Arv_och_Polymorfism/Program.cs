namespace Övnings3_Samling_Inkapsling_Arv_och_Polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    //Person person = new Person();
            //    //person.Age = 15;
            //    //person.FName = "Kalle";
            //    //person.LName = "Anka";
            //    //Console.WriteLine(person.Age);

            //    PersonHandler handler = new PersonHandler();
            //    //handler.SetAge(person, 25);
            //    //Console.WriteLine(person.Age);





            //    //-------------------------------------------Person 1-------------------------------------------------------------------------
            //    Person newP = handler.CreatePerson(15, "kalle", "Svennsson", 150, 75);
            //    Console.WriteLine($"År: {newP.Age}, Förnamn: {newP.FName}, Efternamn: {newP.LName}, Längd: {newP.Height}, Vikt{newP.Weight}");
            //    double bmi = handler.CheckBMI(newP);
            //    if(bmi < 18.5)
            //    {
            //        Console.WriteLine($"{newP.FName} har en bmi på {bmi} och det är undervikt");
            //    }
            //    else if(bmi >= 18.5 && bmi <= 24.9)
            //    {
            //        Console.WriteLine($"{newP.FName} har en bmi på {bmi} och är har NormalVikt");
            //    }
            //    else if(bmi >= 25.0 && bmi <= 29.9)
            //    {
            //        Console.WriteLine($"{newP.FName} har en bmi på {bmi} och Övervikt\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{newP.FName} har en bmi på {bmi} och det är Hög Fetma");
            //    }

            //    // för att kalla på en statisk metod så behöver du kalla på Class namnet och inte till en instans av den. dvs PersonHandler och inte handler
            //    bool isAllowed = PersonHandler.CheckIfUserIsAlowedToGoToANightClub(newP);
            //    if(isAllowed == true) { Console.WriteLine($"{newP.FName} is allowed to go into nightclubs in Stockholm city\n"); }
            //    else { Console.WriteLine($"{newP.FName} arent allowed to go into nightclubs doe {newP.FName} are not old enough!\n");  }



            //    //-------------------------------------------Person 2-------------------------------------------------------------------------
            //    Person newP1 = handler.CreatePerson(18, "Gustav", "Svennsson", 170, 63);
            //    Console.WriteLine($"År: {newP1.Age}, Förnamn: {newP1.FName}, Efternamn: {newP1.LName}, Längd: {newP1.Height}, Vikt: {newP1.Weight}");
            //    double bmi1 = handler.CheckBMI(newP1);
            //    if (bmi1 < 18.5)
            //    {
            //        Console.WriteLine($"{newP1.FName} har en bmi på {bmi1} och det är undervikt");
            //    }
            //    else if (bmi1 >= 18.5 && bmi1 <= 24.9)
            //    {
            //        Console.WriteLine($"{newP1.FName} har en bmi på {bmi1} och är har NormalVikt");
            //    }
            //    else if (bmi1 >= 25.0 && bmi1 <= 29.9)
            //    {
            //        Console.WriteLine($"{newP1.FName} har en bmi på {bmi1} och Övervikt");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{newP1.FName} har en bmi på {bmi1} och det är Hög Fetma");
            //    }

            //    // för att kalla på en statisk metod så behöver du kalla på Class namnet och inte till en instans av den. dvs PersonHandler och inte handler
            //    bool isAllowed1 = PersonHandler.CheckIfUserIsAlowedToGoToANightClub(newP1);
            //    if (isAllowed1 == true) { Console.WriteLine($"{newP1.FName} is allowed to go into nightclubs in Stockholm city\n"); }
            //    else { Console.WriteLine($"{newP1.FName} arent allowed to go into nightclubs doe {newP1.FName} are not old enough!\n"); }


            //    //-------------------------------------------Person 3-------------------------------------------------------------------------
            //    Person newP2 = handler.CreatePerson(65, "Gösta", "Eriksson", 140, 70);
            //    Console.WriteLine($"År:  {newP2.Age} , Förnamn:  {newP2.FName} , Efternamn:  {newP2.LName} , Längd: {newP2.Height}, Vikt: {newP2.Weight}");

            //    double bmi2 = handler.CheckBMI(newP2);
            //    if (bmi2 < 18.5)
            //    {
            //        Console.WriteLine($"{newP2.FName} har en bmi på {bmi2} och det är undervikt");
            //    }
            //    else if (bmi2 >= 18.5 && bmi2 <= 24.9)
            //    {
            //        Console.WriteLine($"{newP2.FName} har en bmi på {bmi2} och är har NormalVikt");
            //    }
            //    else if (bmi2 >= 25.0 && bmi2 <= 29.9)
            //    {
            //        Console.WriteLine($"{newP2.FName} har en bmi på {bmi2} och Övervikt");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{newP2.FName} har en bmi på {bmi2} och det är Hög Fetma");
            //    }

            //    // för att kalla på en statisk metod så behöver du kalla på Class namnet och inte till en instans av den. dvs PersonHandler och inte handler
            //    bool isAllowed2 = PersonHandler.CheckIfUserIsAlowedToGoToANightClub(newP2);
            //    if (isAllowed2 == true) { Console.WriteLine($"{newP2.FName} is allowed to go into nightclubs in Stockholm city\n"); }
            //    else { Console.WriteLine($"{newP2.FName} arent allowed to go into nightclubs doe {newP2.FName} are not old enough!\n"); }


            //    //-------------------------------------------Person 4-------------------------------------------------------------------------
            //    Person newP3 = handler.CreatePerson(25, "Erika", "Arlandsson", 160, 200);
            //    Console.WriteLine($"År: {newP3.Age}, Förnamn: {newP3.FName}, Efternamn: {newP3.LName}, Längd: {newP3.Height}, Vikt: {newP3.Weight}");

            //    double bmi3 = handler.CheckBMI(newP3);
            //    if (bmi3 < 18.5)
            //    {
            //        Console.WriteLine($"{newP3.FName} har en bmi på {bmi3} och det är undervikt");
            //    }
            //    else if (bmi3 >= 18.5 && bmi3 <= 24.9)
            //    {
            //        Console.WriteLine($"{newP3.FName} har en bmi på {bmi3} och är har NormalVikt");
            //    }
            //    else if (bmi3 >= 25.0 && bmi3 <= 29.9)
            //    {
            //        Console.WriteLine($"{newP3.FName} har en bmi på {bmi3} och Övervikt");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{newP3.FName} har en bmi på {bmi3} och det är Hög Fetma");
            //    }

            //    // för att kalla på en statisk metod så behöver du kalla på Class namnet och inte till en instans av den. dvs PersonHandler och inte handler
            //    bool isAllowed3 = PersonHandler.CheckIfUserIsAlowedToGoToANightClub(newP3);
            //    if (isAllowed3 == true) { Console.WriteLine($"{newP3.FName} is allowed to go into nightclubs in Stockholm city\n"); }
            //    else { Console.WriteLine($"{newP3.FName} arent allowed to go into nightclubs doe {newP3.FName} are not old enough!\n"); }
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //-----------------------------------------------------------
            try
            {
                List<UserError> errors = new List<UserError>();
                errors.Add(new NumericInputError());
                errors.Add(new TextInputError());

                foreach (var error in errors)
                {
                    Console.WriteLine(error.UEMessage());
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //----------------------------------------------------------
            Console.WriteLine();
            try
            {
                List<UserError> userErrors = new List<UserError>();
                userErrors.Add(new NumericInputError());
                userErrors.Add(new TextInputError());
                userErrors.Add(new SymbolInputError());
                userErrors.Add(new OldGrandPaInputError());
                userErrors.Add(new ThinkingInputError());

                foreach(var uerror in userErrors)
                {
                    Console.WriteLine($"{uerror.UEMessage()}\n");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
