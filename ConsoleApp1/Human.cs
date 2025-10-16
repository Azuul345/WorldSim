namespace ConsoleApp1
{
    public enum Gender { Male, Female, Other }


    internal class Human
    {
        public static long Population = 0;

        //core Identity 
        //public string SurName { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public Guid DNA { get; set; }    //unique identifier
        public bool IsAlive { get; set; }


        /// <summary>
        /// biological & physical
        /// </summary>
        //public double BMI { get; set; } // health
        public double Health { get; set; } = 100;
        public double Height { get; set; }
        public double Weight { get; set; }
        public double EnergyLevel { get; set; } = 100; //10

        public double Strenght { get; set; }
        public double Endurance { get; set; }

        public double ImmuneSystem { get; set; }

        public double SleepQuality { get; set; } = 100;
        public double Hunger { get; set; } = 0.0; //full

        public double Thirst { get; set; } = 0.0; //Full
        public string BloodType { get; set; }

        public string Mother { get; set; }
        public string Father { get; set; }


        //Emotional & cognitive 
        public double Intelligence { get; set; }

        public double Empaty { get; set; }
        public double Creativity { get; set; }
        //public int Iq { get; set; }
        //public int Eq { get; set; }

        public double MemoryRetention { get; set; }
        public double Focus { get; set; }
        public double Curiosity { get; set; }
        public double StressLevel { get; set; } = 0.0;
        public double Wisdom { get; set; }
        public double Happiness { get; set; } = 100; // 10


        // Social
        public List<Human> SocialConection { get; set; } = new List<Human>();
        public List<string> Skills { get; set; } = new List<string>();
        public double Reputation { get; set; }
        public double Charisma { get; set; }
        public double Integrity { get; set; }

        //Economic survival 
        public decimal Wealth { get; set; }
        public string Occupation { get; set; }
        public string EducationLevel { get; set; }
        public string HomeLocation { get; set; }

        //Existential 
        public string Purpuse { get; set; }
        public bool IsReligious { get; set; }
        public double FaithLevel { get; set; }
        public double LegacyLevel { get; set; }


        public Human(string name, Gender gender, string birthLocation, bool isAlaive, string father, string mother)
        {
            Name = name;
            Gender = gender;
            Age = 0;
            Intelligence = 20;
            Empaty = 20;
            Strenght = 5;
            Creativity = 5;
            DNA = Guid.NewGuid();
            HomeLocation = birthLocation;

            IsAlive = isAlaive;
            Population++;
            Father = father;
            Mother = mother;
        }

        public void PrintSummary()
        {
            Console.WriteLine($"Age: {Age}. Gender: {Gender}. Health: {Health}. Energy:{EnergyLevel} Happiness: {Happiness}");
        }


        public static void FindByName(List<Human> sociatiy, string name)
        {
            var person = sociatiy[0];
            foreach (var h in sociatiy)
            {
                if (name == h.Name)
                {
                    person = h;
                    break;
                }

            }
            Console.WriteLine(person.ToString());
        }

        public void LearnSkill(string skill)
        {
            Skills.Add(skill);
            Creativity += 5;
        }

        public void Rest()
        {
            StressLevel -= 5;
            Happiness += 5;
            EnergyLevel += 5;
        }

        public void Work()
        {
            Wealth += 20;
            EnergyLevel -= 10;
            StressLevel += 10;
        }

        public void Sleep()
        {
            if (IsAlive)
            {
                EnergyLevel = 100;
                SleepQuality = 100;
            }
        }

        public void Eat()
        {
            Random rnd = new Random();
            int hungerDecrease = rnd.Next(2, 5);
            if (Hunger > 0)
            {
                Hunger -= hungerDecrease;
                EnergyLevel += 3;
                Happiness += 4;
            }

        }

        public void SimulatYear()
        {
            GetOlder(1);
            Random rnd = new Random();
            int happy = rnd.Next(10, 30);
            int health = rnd.Next(10, 30);
            int deathChance = rnd.Next(10, 40);

            Happiness -= happy;
            Health -= health;

            if (deathChance > 5 && deathChance < 30)
            {
                IsAlive = false;
            }

        }

        public void GoToSchool()
        {
            Random rnd = new Random();
            int intPoints = rnd.Next(5, 15);
            Intelligence += intPoints;
            Skills.Add("Education");
        }




        public void Speak(Human human)
        {
            Console.WriteLine($"{Name} says HeLlO to {human.Name}");
        }




        public static Human RandomHuman()
        {
            Random rnd = new Random();
            string[] maleNames = { "Johan", "Abi", "Hamza", "Lukas", "Oskar", "Christian", "Java Jack" };
            string[] femaleNames = { "Emma", "Linda", "Yifan", "Zara", "Spitz", "Madona" };
            string[] location = { "Majorna", "Angared", "Solna", "Uppsala", "Rosengard" };

            Gender randomPeople;
            int gendergenerator = rnd.Next(0, 2);
            string randomName;
            if (gendergenerator == 1)
            {
                randomPeople = Gender.Male;
                randomName = maleNames[rnd.Next(maleNames.Length)];
            }
            else
            {
                randomPeople = Gender.Female;
                randomName = femaleNames[rnd.Next(femaleNames.Length)];
            }
            string birthLocation = location[rnd.Next(location.Length)];
            Human human = new(randomName, randomPeople, birthLocation, true, "Steve", "Not Steve");
            return human;

        }

        public void FamilyTree(List<Human> tree)
        {
            List<Human> sibling = new();
            foreach (Human human in tree)
            {
                if (human.Father == Father)
                {
                    sibling.Add(human);
                }
            }
            Console.WriteLine($"Father: {Father} Mother: {Mother}");
            Console.WriteLine("Sibling: ");
            foreach (Human sib in sibling)
            {
                Console.WriteLine(sib.Name);
            }
        }

        public static Human MakeChild(Human male, Human female)
        {
            Random rnd = new Random();
            string[] maleNames = { "Noah", "Cain", "Able", "Disable", "Frank", "Abraham", "Tom", "Jack", "Oskar", "Sebbe" };
            string[] femaleNames = { "Lilith", "Sheniqua", "Sara", "Amanda", "Alina", "Beyonce", "Emma", "Linda", "Sofia", "Zara", "Yiff" };


            Gender Child;
            int gendergenerator = rnd.Next(0, 2);
            string childName;

            if (gendergenerator == 1)
            {
                Child = Gender.Male;
                childName = maleNames[rnd.Next(maleNames.Length)];
            }
            else
            {
                Child = Gender.Female;
                childName = femaleNames[rnd.Next(maleNames.Length)];
            }

            Human human = new Human(childName, Child, male.HomeLocation, true, male.Name, female.Name);
            return human;
        }


        public static void RandomDeathInPopulation(List<Human> humans)
        {
            Random rnd = new Random();
            foreach (var h in humans)
            {
                int chanceToDie = rnd.Next(5);
                if (chanceToDie == 1)
                {
                    h.IsAlive = false;
                    Population--;
                }
            }
        }

        public void Die()
        {
            IsAlive = false;
            Population--;
        }




        public static void CountChildren(List<Human> humans)
        {
            var children = humans.Where(x => x.HomeLocation == "Garden of Eden" && x.Age < 20).ToList();


            Console.WriteLine($"Amount of children: {children.Count}");
        }


        public void InheritWealth(List<Human> population)
        {
            List<Human> children = new();

            if (IsAlive == false)
            {
                children = population.Where(x => x.Father == Name && x.IsAlive).ToList();
            }

            if (children.Count != 0)
            {
                decimal wealthDivided = Wealth / children.Count();
                foreach (var c in children)
                {
                    c.Wealth = wealthDivided;
                }
            }

            //foreach (var h in children)
            //{
            //    Console.WriteLine($"{h.Name} Wealth: {h.Wealth}");
            //}
        }




        public void GetOlder(int age)
        {
            Age += age;
        }

        public override string ToString()
        {
            return $"{Name}  Gender: {Gender}. Age: {Age}. Is Alive: {IsAlive}. Birth Location: {HomeLocation}" +
                $" Father: {Father}. Mother: {Mother}";
        }
        //Guid: {DNA}



        ////public string Proffession { get; set; }
        //public string Race { get; set; }
        //public string Language { get; set; }
        ////public string Religion { get; set; }
        //public string Nationality { get; set; }
        //public string EyeColor { get; set; }
        //public string HairColor { get; set; }
        //public string TaxBracket { get; set; }
        ////public string Education { get; set; }
        ////public bool Hobo { get; set; }
        //public string Sexuality { get; set; }
        //public string Birthday { get; set; }
        //public string ZodiacSign { get; set; }
        //public bool Virginity { get; set; }
        //public bool Athlete { get; set; }
        //public bool Litteracy { get; set; }
        //public bool HasHair { get; set; }
        //public bool Autism { get; set; }
        //public bool MentalDisorder { get; set; } //Lista kandidat
        //public string Addiciton { get; set; } // Lista kandidat
        //public string Hobby { get; set; } // Lista kandidat
        //public bool Immigrant { get; set; }
        //public bool Beneficiary { get; set; }
        //public string Allergies { get; set; }
        //public bool IsBreeder { get; set; }

    }
}