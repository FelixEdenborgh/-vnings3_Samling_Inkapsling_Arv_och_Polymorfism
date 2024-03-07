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

            //-----------------------------------------------------------------------------------

            // Min djur lista
            List<Animal> anmialList = new List<Animal>();
            //Animal Horse = new Horse("Benkt", 33, 45.0, 4, "Rainbow");
            // Horse
            Horse myHorse = new Horse("Benkt", 33, 45.0, 4, "Rainbow");
            myHorse.ChangePatternOnHourse("Sparkly");
            Console.WriteLine($"My Horse {myHorse.Name} have the pattern {myHorse.Pattern}");
            anmialList.Add(myHorse);
            //Dog
            Dog myDog = new Dog("Sven", 12, 32.0, 4, "Border terier");
            myDog.ChangeBreedOfDog("Springe spanier");
            Console.WriteLine($"The dog {myDog.Name} are of the breed {myDog.Breed}");
            anmialList.Add(myDog);
            //Hedgehog
            Hedgehog myhedgehog = new Hedgehog("Kasper", 5, 3.0, 4, true);
            bool spikyHedgehog = myhedgehog.GetSpicky(true);
            if (spikyHedgehog == true)
            {
                Console.WriteLine($"My Hedgehog {myhedgehog.Name} are now spiky!");
            }
            else
            {
                Console.WriteLine($"The Hedgehog {myhedgehog.Name} are now not spiky!");
            }
            anmialList.Add(myhedgehog);
            //Worm
            Worm myWorm = new Worm("Jonas", 1, 0.5, 0, 50);
            Console.WriteLine($"My worm {myWorm.Name} are: {myWorm.HowDeep} meters into the ground!");
            anmialList.Add(myWorm);
            //Bird
            Bird myBird = new Bird("Oscar", 7, 0.3, 2, "Green");
            Console.WriteLine($"My bird {myBird.Name} have the lovely {myBird.FeatherColor} feather color");
            anmialList.Add(myBird);
            //Wolf
            Wolf myWolf = new Wolf("Stuart", 9, 60, 4, "Brown");
            Console.WriteLine($"My wolf named {myWolf.Name} have the most amazing {myWolf.FurColor} fur color");
            anmialList.Add(myWolf);
            //Pelican
            Pelican myPelican = new Pelican("Gustav", 13, 0.9, 2, "White", 190.0);
            Console.WriteLine($"My Pelican {myPelican.Name} are so lovely its {myPelican.FeatherColor} and are really high to at {myPelican.Lenght}cm!");
            anmialList.Add(myPelican);
            //Flamingo
            Flamingo myFlamingo = new Flamingo("Eric", 24, 0.7, 2, "Pink", "Blue");
            Console.WriteLine($"My Flamingo with the name {myFlamingo.Name} have the super power to change color! It was Pink before but now its {myFlamingo.ChangeColor}");
            anmialList.Add(myFlamingo);
            //Swan
            Swan mySwan = new Swan("Alex", 18, 1.2, 2, "White", 20);
            Console.WriteLine($"My Swan {mySwan.Name} can fly really high! right now its flying {mySwan.HowHigh} meters up in the air!");
            anmialList.Add(mySwan);
            //WolfMan
            WolfMan myWolfMan = new WolfMan("Jimmy", 33, 110, 2, "Black");
            Console.WriteLine($"My friend are pretty scary, he hunts in the wild forest and says that he gets alot of victims\nhe say that he is a {myWolfMan.GetType().Name}\n");
            anmialList.Add(myWolfMan);

            foreach ( var animal in anmialList)
            {

                if(animal is IPerson)
                {
                    if(animal.GetType().Name == myWolfMan.GetType().Name)
                    {
                        myWolfMan.Talk();
                    }

                }
                else
                {
                    Console.WriteLine($"{animal.GetType().Name} {animal.Name}: {animal.DoSound()}");
                }


                //if(animal.GetType().Name != myWolfMan.GetType().Name)
                //{
                //    Console.WriteLine($"{animal.GetType().Name} {animal.Name}: {animal.DoSound()}");
                //}
                //else
                //{
                //    myWolfMan.Talk();
                //}
                
            }

            //------------------------List of dogs----------------------------------------------------------------------
            List<Dog> myDogList = new List<Dog>();
            //myDogList.Add(myHorse);
            // 9. F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
            // Det fungerar inte då dog och horse inte är samma sak. Båda ärvet från Animal men har olika klasser i sig. Så de är inte lika eller äns samma.
            // Och listan myDogList kan bara innehålla Dog eller någon klass som ärver av Dog. 
            // List<Dog> Betyder att den bara accepterar object av typen Dog.

            // 10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
            // För att kunna lagra alla klasserna så måste de ärva av samma klass och de gör det av Animal.
            // Så därför måste Listan vara av typen Animal om den ska kunna lagra alla klasserna som ärver av Animal. List<Animal>

            foreach ( var animal in anmialList)
            {
                Console.WriteLine($"Animal: {animal.GetType().Name}, Stats: {animal.Stats()}\n");
            }
            // 13. F: Förklara vad det är som händer.
            // Koden loppar igenom alla objekten och vid varje animal så skriver den ut i detta fallet animal typen och animal stats då vi har både dem metoderna kallade på
            // animal typen igenom metoden GetType "{animal.GetType().Name}" och Stats igenom metoden "{animal.Stats()}". Där Stats är en metod i Animal som overridas i varje subklass
            // också varje subklass lägger till denns special properties i en return som sedan skrivs ut i våran Console.WriteLine när vi kallar på metoden.

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
            Console.WriteLine();

            // 14. Skriv ut Stats() metoden enbart för alla hundar genom en foreach på
            //Animals.
            // Vill jag få med Wolf och WolfMan så behöver jag göra dem till Dog Object
            foreach ( var animal in anmialList)
            {
                if (animal is Dog || animal.GetType().IsSubclassOf(typeof(Dog)))
                {
                    Console.WriteLine($"Animal type: {animal.GetType().Name}, Stats: {animal.Stats()}\n");
                }
            }
            // Vill jag få med Wolf och WolfMan så behöver jag göra dem till Dog Object eller dra in dem med att kolla om det är dem respektive så här:
            // Där jag både kollar om det är Dog och om det är Wolf eller WolfMan
            Console.WriteLine("Check if its either Dog, Wolf, or WolfMan");
            foreach (var animal in anmialList)
            {
                if (animal is Dog || animal.GetType().IsSubclassOf(typeof(Dog)))
                {
                    Console.WriteLine($"Animal type: {animal.GetType().Name}, Stats: {animal.Stats()}\n");
                }
                else if (animal is Wolf || animal is WolfMan)
                {
                    Console.WriteLine($"Animal type: {animal.GetType().Name}, Stats: {animal.Stats()}\n");
                }
            }

            // Vi är på 3.4) Mer polymorfism: 15. Skapa en ny metod med valfritt namn i klassen Dog som endast returnerar en valfri
            // sträng.
        }
    }
}
