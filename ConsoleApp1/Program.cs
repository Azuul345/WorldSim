namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human adam = new("Adam", Gender.Male, "Garden of Eden", true);
            Human eve = new("Eve", Gender.Female, "Garden of Eden", true);

            adam.Age = 35;
            eve.Age = 33;

            Console.WriteLine("Beginning of humanity");

            List<Human> Soceity = new List<Human>();
            Soceity.Add(eve);
            Soceity.Add(adam);
            Soceity.Add(adam.MakeChild(eve));

            Soceity.Add(adam.MakeChild(eve));
            Soceity.Add(adam.MakeChild(eve));
            Soceity.Add(adam.MakeChild(eve));
            Soceity.Add(adam.MakeChild(eve));
            Soceity.Add(adam.MakeChild(eve));
            Soceity.Add(adam.MakeChild(eve));

            Soceity[2].GetOlder();
            Soceity[2].GetOlder();
            Soceity[2].GetOlder();
            Soceity[2].GetOlder();
            Soceity[2].GetOlder();
            Soceity[2].GetOlder();
            Soceity[2].GetOlder();
            Soceity[2].GetOlder();
            Soceity[2].GetOlder();

            Soceity[4].GetOlder();
            Soceity[4].GetOlder();
            Soceity[4].GetOlder();
            Soceity[4].GetOlder();
            Soceity[4].GetOlder();


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
            //var p1 = Human.RandomHuman();
            //var p2 = Human.RandomHuman();
            //var p3 = Human.RandomHuman();
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


            // -------------- 19











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
