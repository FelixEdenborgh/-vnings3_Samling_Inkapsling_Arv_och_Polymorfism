using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övnings3_Samling_Inkapsling_Arv_och_Polymorfism
{
    internal class Person
    {
        private int age;
        public int Age
        {
            get { return age; }
            set 
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    throw new ArgumentException("Åldern måste vara större än 0.");
                }
            }
        }

        private string fName;
        public string FName
        {
            get { return fName; }
            set 
            {
                if(value.Length >= 2 && value.Length <= 10)
                {
                    fName = value;
                }
                else
                {
                    throw new ArgumentException("Namnet måste vara mellan 2 och 10 tecken långt.");
                }
            }
        }

        private string lName;
        public string LName
        {
            get { return lName; }
            set
            {
                if(value.Length >= 3 && value.Length <= 15)
                {
                    lName = value;
                }
                else
                {
                    throw new ArgumentException("Efter Namnet måste vara mellan 3 och 15 tecken långt.");
                }
            }
        }

        private double height;
        public double Height
        {
            get { return height;}
            set { height = value; }
        }

        private double weight;
        public double Weight
        {
            get { return weight;}
            set { weight = value; }
        }


    }
}
