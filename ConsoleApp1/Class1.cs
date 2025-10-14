using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Gender  { Male, Female, Other }


    internal class Human
    {
        public static long Population {  get; set; }

        //core Identity 
        public string SurName { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public Guid DNA { get; set; }    //unik indetifier
        public bool IsAlive { get; set; }


    /// <summary>
    /// biological & phisical
    /// </summary>
        public double BMI { get; set; } // health
        public double Health { get; set; } = 100;
        public double Height { get; set; }
        public double Weight { get; set; }
        public double EnergyLevel { get; set; }

        public double Strenght { get; set; }
        public double Endurance { get; set; }

        public double ImmuneSystem { get; set; }

        public double SleepQuality { get; set; }
        public double Hunger { get; set; } = 0.0; //full
        public double Thirst { get; set; } = 0.0; //Full

        
        //Emotional & congnetive 
        public double Intelligence { get; set; }

        public double Empaty {  get; set; }
        public double Creativity { get; set; }
        public int Iq { get; set; }
        public int Eq { get; set; }

        public double MemoryRetention { get; set; }
    public double Focus { get; set; }
    public double Curiosity { get; set; }
    public double StressLevel { get; set; }
    public double Wisdom { get; set; }
    public double Happines { get; set; }


    // Social
    public List<Human> SocialConection { get; set; } = new List<Human>();
    public List<string> Skills { get; set; }
    public double Reputation { get; set; }
    public double Charisma { get; set; }
    public double integrety { get; set; }

    //Economic survival 
    public decimal Wealth { get; set; }
    public string Occupation { get; set; }
    public string EducationLevel { get; set; }
    public string HomeLocation { get; set; }

    //Existencial 
    public string Purpuse { get; set; }
    public bool IsReligious { get; set; }
    public double FaithLevel { get; set; }
    public double LegacyLevel { get; set; }




        //public string Proffession { get; set; }
        public string Race { get; set; }
        public string Language { get; set; }
        //public string Religion { get; set; }
        public string Nationality { get; set; }
        public string EyeColor { get; set; }
        public string HairColor { get; set; }
        public string TaxBracket { get; set; }
        //public string Education { get; set; }
        //public bool Hobo { get; set; }
        public string Sexuality { get; set; }
        public string Birthday { get; set; }
        public string ZodiacSign { get; set; }
        public bool Virginity { get; set; }
        public bool Athlete { get; set; }
        public bool Litteracy { get; set; }
        public bool HasHair { get; set; }
        public bool Autism { get; set; }
        public bool MentalDisorder { get; set; } //Lista kandidat
        public string Addiciton { get; set; } // Lista kandidat
        public string Hobby { get; set; } // Lista kandidat
        public bool Immigrant { get; set; }
        public bool Beneficiary { get; set; }
        public string BloodType { get; set; }
        public string Allergies { get; set; }
        public bool IsBreeder { get; set; }





        public Human(string name, Gender gender, string birthLocation, bool isAlaive )
        {
            Name = name;
            Gender = gender;
            Age = 0;
            Intelligence = 20;
            Empaty = 20;
            Strenght = 5;
            Creativity = 5;
            DNA = Guid.NewGuid();


            IsAlive = isAlaive;
            

        }

        public Human MakeChild(Human partner)
        {
            Random rnd = new Random();
            string[] maleNames = { "Noah","Cain", "Able", "Disable", "Frank", "Abrahamn" };
            string[] femaleNames = { "Lilith", "Sheniqua", "Sara", "Eva", "Alina", "Beyonce" };


            Gender Child;
            int gendergenerator = rnd.Next(0, 2);
            string childName;

            if(gendergenerator == 1)
            {
                Child = Gender.Male;
                 childName = maleNames[rnd.Next(maleNames.Length)];
            }
            else
            {
                Child = Gender.Female;
                childName = femaleNames[rnd.Next(maleNames.Length)];
            }

            Human human = new Human(childName, Child, partner.HomeLocation, true);
            return human;

        }

        public void GetOlder()
        {
            Age++;
        }

        public override string ToString()
        {
            return $"{Name} Guid: {DNA} Gender: {Gender}. Age: {Age}";
        }

    }
}