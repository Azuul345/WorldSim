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

            Console.WriteLine("Begining of humanity");

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


            Console.WriteLine(Soceity[2].ToString());


            var peopleover10 = Soceity.Where(x => x.Age > 8).ToList();

            foreach (var person in peopleover10)
            {
                Console.WriteLine(person);
            }


            //var saras = Soceity.Where(x => x.Name == "Sara").ToList();

            //foreach (Human sar in saras)
            //{
            //    Console.WriteLine(sar);
            //}











            //Console.WriteLine("All humans in the list");

            //foreach (Human we in Soceity)
            //{
            //    Console.WriteLine(we.ToString());

            //}

            //Console.WriteLine("Male humans ===================");
            //foreach (Human h in Soceity)
            //{
            //    if (h.Gender == Gender.Male)
            //    {
            //        Console.WriteLine(h);
            //    }
            //}

            //Console.WriteLine("Female humans ==================");
            //var females = Soceity.Where(f => f.Gender == Gender.Female).ToList();
            //foreach (var f in females)
            //{
            //    Console.WriteLine(f);

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
