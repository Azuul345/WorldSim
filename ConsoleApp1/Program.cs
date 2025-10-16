namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human adam = new("Adam", Gender.Male, "Garden of Eden", true, "God", "Gaia");
            Human eve = new("Eve", Gender.Female, "Garden of Eden", true, "God", "Gaia");

            adam.Age = 35;
            eve.Age = 33;

            Console.WriteLine("Beginning of humanity");

            List<Human> Soceity = new List<Human>();
            Soceity.Add(eve);
            Soceity.Add(adam);

            Soceity.Add(Human.MakeChild(adam, eve));
            Soceity.Add(Human.MakeChild(adam, eve));
            Soceity.Add(Human.MakeChild(adam, eve));
            Soceity.Add(Human.MakeChild(adam, eve));
            Soceity.Add(Human.MakeChild(adam, eve));
            Soceity.Add(Human.MakeChild(adam, eve));
            Soceity.Add(Human.MakeChild(adam, eve));
            Soceity.Add(Human.MakeChild(adam, eve));
            Soceity.Add(Human.MakeChild(adam, eve));
            Soceity.Add(Human.MakeChild(adam, eve));
            Soceity.Add(Human.MakeChild(adam, eve));

            Soceity[2].GetOlder(20);
            Soceity[3].GetOlder(22);
            Soceity[4].GetOlder(19);
            Soceity[5].GetOlder(21);
            Soceity[6].GetOlder(20);
            Soceity[7].GetOlder(20);
            Soceity[8].GetOlder(20);
            Soceity[9].GetOlder(20);
            Soceity[10].GetOlder(20);
            Soceity[11].GetOlder(20);
            Soceity[12].GetOlder(20);

            //foreach (var h in Soceity)
            //{
            //    Console.WriteLine(h);

            //}
            //Console.WriteLine("\n\n\n\n\n");

            //Human bob = Human.MakeChild(Soceity[3], Soceity[4]);
            //Console.WriteLine($"{bob.Father}, {bob.Mother}");

            //Console.WriteLine(Society[2].ToString());   test

            // -------------1
            //Console.WriteLine("All humans in the list");

            //foreach (Human we in Soceity)
            //{
            //    Console.WriteLine(we.ToString());

            //}


            //---------- 2
            //Console.WriteLine($"Amount of humans in the world: {Human.Population}");


            //----------- 3 
            //Console.WriteLine("Female humans ==================");
            //var females = Soceity.Where(f => f.Gender == Gender.Female).ToList();
            //foreach (var f in females)
            //{
            //    Console.WriteLine(f);

            //}


            //---------- 4
            //var peopleover10AndMale = Soceity.Where(x => x.Age > 8 && x.Gender == Gender.Male).ToList();

            //foreach (var person in peopleover10AndMale)
            //{
            //    Console.WriteLine(person);
            //}


            //----------- 5
            //Human.CountChildren(Soceity);

            //--------- 6
            //var oldest = Soceity.OrderByDescending(x => x.Age).ToList();
            //Console.WriteLine(oldest[0].ToString());

            //-------- 7 
            //Console.WriteLine("After age loop");

            //foreach (var h in Soceity)
            //{
            //    h.GetOlder();
            //}
            //foreach (var h in Soceity)
            //{
            //    Console.WriteLine(h.ToString());
            //}



            // ----------- 8 
            //var avrageAge = Soceity.Average(e => e.Age);
            //Console.WriteLine(avrageAge);

            //------------ 9 
            //Human.RandomDeathInPopulation(Soceity);
            //Console.WriteLine("\n\n\n");
            //foreach (var h in Soceity)
            //{
            //    Console.WriteLine(h.ToString());
            //}
            //Console.WriteLine(Human.Population);


            //----------- 10
            //var p3 = Soceity[2];
            //Console.WriteLine($"{p3.Name} Hunger:{p3.Hunger} Energy: {p3.EnergyLevel}. Happiness: {p3.Happiness}");
            //Console.WriteLine("\n\n\n");
            //p3.Hunger = 20;
            //p3.Eat();
            //Console.WriteLine($"{p3.Name} Hunger:{p3.Hunger} Energy: {p3.EnergyLevel}. Happiness: {p3.Happiness}");


            // ----------- 11
            //var p3 = Soceity[2];
            //p3.EnergyLevel = 80;
            //p3.SleepQuality = 80;
            //p3.Sleep();
            //Console.WriteLine($"Name:{p3.Name} Energy: {p3.EnergyLevel}. Sleep Quality: {p3.SleepQuality}");

            //-------------- 16
            //var ages = Soceity.OrderByDescending(a => a.Age);
            //foreach (var p in ages)
            //{
            //    Console.WriteLine(p.ToString());
            //}


            //-------------- 17
            //List<Human> randoms = new();


            //Human p1 = Human.RandomHuman();
            //Human p2 = Human.RandomHuman();
            //Human p3 = Human.RandomHuman();
            //Soceity.Add(p1);
            //Soceity.Add(p2);
            //Soceity.Add(p3);
            //randoms.Add(p1);
            //randoms.Add(p2);
            //randoms.Add(p3);


            //Console.WriteLine(p1.ToString());
            //Console.WriteLine(p2.ToString());
            //Console.WriteLine(p3.ToString());

            //-------------- 18
            //var groups = Soceity.GroupBy(h => h.Gender).ToList();
            //foreach (var h in groups[0])
            //{
            //    Console.WriteLine(h.ToString());
            //}
            //Console.WriteLine("\n\n\n");
            //foreach (var h in groups[1])
            //{
            //    Console.WriteLine(h.ToString());
            //}


            // -------------- 22
            //Soceity[2].FamilyTree(Soceity);
            //Console.WriteLine(Soceity[4].ToString());

            //Soceity[4].GoToSchool();
            //Console.WriteLine(Soceity[4].Skills[0]);



            //----------------- 23
            //foreach (var h in Soceity)
            //{
            //    Console.WriteLine(h.ToString());
            //}
            //adam.Wealth = 230000;

            //adam.IsAlive = false;
            //Soceity[4].IsAlive = false;

            //adam.InheritWealth(Soceity);


            //------------------- 25

            //Random rnd = new Random();
            //var males = Soceity.Where(x => x.Gender == Gender.Male && x.Age > 18 && x.Name != "Adam").ToList();
            //var females = Soceity.Where(x => x.Gender == Gender.Female && x.Age > 18 && x.Name != "Eve").ToList();

            //while (Human.Population < 50)
            //{
            //    int work = rnd.Next(Soceity.Count);
            //    int eats = rnd.Next(Soceity.Count);
            //    int rest = rnd.Next(Soceity.Count);
            //    int edu = rnd.Next(Soceity.Count);
            //    int sleeps = rnd.Next(Soceity.Count);

            //    int father = rnd.Next(males.Count);
            //    int mother = rnd.Next(females.Count);

            //    Soceity.Add(Human.MakeChild(males[father], females[mother]));

            //    Soceity[work].Work();
            //    Soceity[eats].Eat();
            //    Soceity[rest].Rest();
            //    Soceity[edu].GoToSchool();
            //    Soceity[sleeps].Sleep();

            //    if (Human.Population == 10 || Human.Population == 20 || Human.Population == 30 || Human.Population == 40)
            //    {
            //        foreach (var h in Soceity)
            //        {
            //            h.SimulatYear();
            //            if (h.IsAlive == false)
            //            {
            //                h.InheritWealth(Soceity);
            //            }
            //        }
            //    }
            //}

            //var avrageAge = Soceity.Average(x => x.Age);
            //var avrageHappines = Soceity.Average(x => x.Happiness);
            //var populationAvg = Soceity.Average(x => Human.Population);

            //Console.WriteLine(avrageAge);
            //Console.WriteLine(avrageHappines);
            //Console.WriteLine(populationAvg);


            //--------- 26
            //var happiestList = Soceity.OrderByDescending(x => x.Happiness).ToList();
            //var happyP = happiestList[0];
            //Console.WriteLine($"{happyP.Name} {happyP.Happiness}\n\n");

            //foreach (var h in happiestList)
            //{
            //    Console.WriteLine($"{h.Name} {h.Happiness}");

            //}


            //------------ 
            Human.FindByName(Soceity, "Adam");









            //Console.WriteLine(Human.Population);
            //test
            //foreach (var h in Soceity)
            //{
            //    Console.WriteLine(h.ToString());

            //    //if (h.IsAlive == false)
            //    //{
            //    //    Console.WriteLine(h.ToString());
            //    //}
            //}
            //Console.WriteLine(Soceity.Count);





            //var saras = Soceity.Where(x => x.Name == "Sara").ToList();

            //foreach (Human sar in saras)
            //{
            //    Console.WriteLine(sar);
            //}



            //Console.WriteLine("Male humans ===================");
            //foreach (Human h in Soceity)
            //{
            //    if (h.Gender == Gender.Male)
            //    {
            //        Console.WriteLine(h);
            //    }
            //}


            //linq search and filter list / databases 

            //List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //List<int> evenNumbers = new();

            //foreach(int n in numbers)
            //{
            //    if(n % 2 == 0)
            //    {
            //        evenNumbers.Add(n);
            //    }
            //}

            //where = condition      x = random name of varible. can be anything

            //var evennumbers = numbers.Where(x => x % 2 == 0).ToList();

            //foreach(int n in evennumbers)
            //{
            //    Console.WriteLine(n);
            //}

            Console.ReadLine();
        }
    }
}
