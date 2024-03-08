using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övnings3_Samling_Inkapsling_Arv_och_Polymorfism
{
    public abstract class Animal
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("The Animal isent alive!");
                }
                else
                {
                    age = value;
                }
            }
        }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("The Anmimal most have some weight. Its not air.");
                }
                else
                {
                    weight = value;
                }
            }
        }

        private int numberoflegs;
        public int NumberOfLegs
        {
            get { return numberoflegs; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("The Animal most be a fish or snake or snail. Or something do it dont have any legs");
                }
                else
                {
                    numberoflegs = value;
                }
            }
        }
            

        public abstract string DoSound();



        // Konstruktor
        public Animal(string nameOfAnimal, int ageOfAnimal, double weightOfAnimal, int numberOfLegsForTheAnimal)
        {
            name = nameOfAnimal;
            age = ageOfAnimal;
            weight = weightOfAnimal;
            numberoflegs = numberOfLegsForTheAnimal;
        }


        public virtual string Stats()
        {
            return $"Name: {name}, Age: {Age}, Weight: {Weight}, Number of Legs: {numberoflegs}";
        }
    }

    // Hästens unika egenskap är att ha olika mönster
    public class Horse : Animal
    {
        public string Pattern { get; set; }
        public Horse(string nameOfAnimal, int ageOfAnimal, double weightOfAnimal, int numberOfLegsForTheAnimal, string pattern) : base(nameOfAnimal, ageOfAnimal, weightOfAnimal, numberOfLegsForTheAnimal)
        {
            Pattern = pattern;
        }

        public string ChangePatternOnHourse(string changePattern)
        {
            Pattern = changePattern;
            return Pattern;
        }

        public override string DoSound()
        {
            return "gnäääg gnäggg";
        }

        public override string Stats()
        {
            return base.Stats() + $", Pattern: {Pattern}";
        }
    }

    // Hundens unika egenskap är att kunna sätta en ras på den
    public class Dog : Animal
    {
        public string Breed { get; set; }
        public Dog(string nameOfAnimal, int ageOfAnimal, double weightOfAnimal, int numberOfLegsForTheAnimal, string breed) : base(nameOfAnimal, ageOfAnimal, weightOfAnimal, numberOfLegsForTheAnimal)
        {
            Breed = breed;
        }

        // Bytter vilken ras hunden är
        public string ChangeBreedOfDog(string changeBreed)
        {
            Breed = changeBreed;
            return Breed;
        }
        public string ImADog()
        {
            return "Im a Dog!";
        }

        public override string DoSound()
        {
            return "woof";
        }

        public override string Stats()
        {
            return base.Stats() + $", Breed: {Breed}";
        }
    }

    // Igelkottens unika egenskap är att bli taggig. Default är false
    public class Hedgehog : Animal
    {
        public bool GetPointy { get; set; }
        public Hedgehog(string nameOfAnimal, int ageOfAnimal, double weightOfAnimal, int numberOfLegsForTheAnimal, bool getPointy = false) : base(nameOfAnimal, ageOfAnimal, weightOfAnimal, numberOfLegsForTheAnimal)
        {
            GetPointy = getPointy;
        }

        // Kollar om boolen är satt
        public bool GetSpicky(bool changeToSpikyEffect)
        {
            if(changeToSpikyEffect == true)
            {
                GetPointy = true;
            }
            else
            {
                GetPointy = false;
            }
            
            return GetPointy;
        }

        public override string DoSound()
        {
            return "Squeak squeak";
        }

        public override string Stats()
        {
            return base.Stats() + $", Spiky: {GetPointy}";
        }
    }

    // Maskens unika egenskap är att kunna gräva sig ner.
    public class Worm : Animal
    {
        public int HowDeep {  get; set; }
        public Worm(string nameOfAnimal, int ageOfAnimal, double weightOfAnimal, int numberOfLegsForTheAnimal, int howDeep) : base(nameOfAnimal, ageOfAnimal, weightOfAnimal, numberOfLegsForTheAnimal)
        {
            HowDeep = howDeep;
        }
        public void ChangeHowDeepTheWormWillDiveDownInTheGround(int deep)
        {
            HowDeep = deep;
        }

        public override string DoSound()
        {
            return "Scape, gnissle, rassle";
        }

        public override string Stats()
        {
            return base.Stats() + $", How deep to dig: {HowDeep} Meters";
        }
    }

    // Fågelns unika egenskap är att bytta färg på fjädrarna.
    public class Bird : Animal
    {
        public string FeatherColor {  get; set; }
        public Bird(string nameOfAnimal, int ageOfAnimal, double weightOfAnimal, int numberOfLegsForTheAnimal, string featherColor) : base(nameOfAnimal, ageOfAnimal, weightOfAnimal, numberOfLegsForTheAnimal)
        {
            FeatherColor = featherColor;
        }

        public void ChangeFeatherColor(string newColor)
        {
            FeatherColor = newColor;
        }

        public override string DoSound()
        {
            return "Kvitter Kvitter";
        }

        public override string Stats()
        {
            return base.Stats() + $", Feather Color: {FeatherColor}";
        }
    }

    // Vargens unika egenskap är att bytta färg på pälsen.
    public class Wolf : Animal
    {
        public string FurColor { get; set; }
        public Wolf(string nameOfAnimal, int ageOfAnimal, double weightOfAnimal, int numberOfLegsForTheAnimal, string furColor) : base(nameOfAnimal, ageOfAnimal, weightOfAnimal, numberOfLegsForTheAnimal)
        {
            FurColor = furColor;
        }

        public void ChangeFurColor(string newColor)
        {
            FurColor = newColor;
        }

        public override string DoSound()
        {
            return "aaaaaahhhhhooooooooooooooooooooooooooooooooooooooooo";
        }

        public override string Stats()
        {
            return base.Stats() + $", Fur Color: {FurColor}";
        }
    }

    // Pelikanens unika egenskap är att sätta längden på den.
    public class Pelican : Bird
    {
        public double Lenght { get; set; }
        public Pelican(string nameOfAnimal, int ageOfAnimal, double weightOfAnimal, int numberOfLegsForTheAnimal, string featherColor, double lenght) : base(nameOfAnimal, ageOfAnimal, weightOfAnimal, numberOfLegsForTheAnimal, featherColor)
        {
            Lenght = lenght;
        }

        public void ChangeLenghtOfPelican(double newLenght)
        {
            Lenght = newLenght;
        }

        public override string DoSound()
        {
            return "Squuueeekk";
        }

        public override string Stats()
        {
            return base.Stats() + $", Height of the Pelican: {Lenght} Centimeter";
        }
    }

    // Flamingos unika egenskap är att bytta färg på sig
    public class Flamingo : Bird
    {
        public string ChangeColor { get; set; }
        public Flamingo(string nameOfAnimal, int ageOfAnimal, double weightOfAnimal, int numberOfLegsForTheAnimal, string featherColor, string changeColor) : base(nameOfAnimal, ageOfAnimal, weightOfAnimal, numberOfLegsForTheAnimal, featherColor)
        {
            ChangeColor = changeColor;
        }

        public void ChangeColorOfFlamingo(string newColor)
        {
            ChangeColor = newColor;
        }

        public override string DoSound()
        {
            return "Flof Flof";
        }

        public override string Stats()
        {
            return base.Stats() + $", Flamingos: Ability to change color: {ChangeColor}";
        }
    }

    // Swans ability is to fly high
    public class Swan : Bird
    {
        public double HowHigh {  get; set; }
        public Swan(string nameOfAnimal, int ageOfAnimal, double weightOfAnimal, int numberOfLegsForTheAnimal, string featherColor, double howHigh) : base(nameOfAnimal, ageOfAnimal, weightOfAnimal, numberOfLegsForTheAnimal, featherColor)
        {
            HowHigh = howHigh;
        }

        public void HowHighShouldTheSwanFly(double howHighShouldSwanFly)
        {
            HowHigh = howHighShouldSwanFly;
        }

        public override string DoSound()
        {
            return "Sqwosh";
        }

        public override string Stats()
        {
            return base.Stats() + $", Swans: Ability to fly how high: {HowHigh} meters";
        }
    }


    //WolfMan
    public class WolfMan : Wolf, IPerson
    {
        public WolfMan(string nameOfAnimal, int ageOfAnimal, double weightOfAnimal, int numberOfLegsForTheAnimal, string furColor) : base(nameOfAnimal, ageOfAnimal, weightOfAnimal, numberOfLegsForTheAnimal, furColor)
        {
        }

        public void Talk()
        {
            Console.WriteLine("Im A half Wolf half Man, And I like to Eat unlucky people that goes out in the Wilderness and comes accross me!");
        }
    }


    //13. F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
    //attribut, i vilken klass bör vi lägga det?
    // Svar: Vi lägger det i Bird då alla andra fåglarna ärver av Bird.

    //14. F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
    //Svar: Då lägger vi det i Animal då alla ärver av Animal.




}
