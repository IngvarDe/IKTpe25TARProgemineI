namespace ListLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List and LINQ");

            //teeme "andmebaasi"
            //ja selleks on vaja luua class nimega Person
            //mis on muutuja all nimega person
            IList<Person> person = new List<Person>()
            {
                new Person() {Id = 1, Name = "Juku", Age = 10},
                new Person() {Id = 2, Name = "Juhan", Age = 11},
                new Person() {Id = 3, Name = "Maali", Age = 9},
                new Person() {Id = 4, Name = "Aksel", Age = 10},
            };

            //nüüd kasutame person muutujat uue muutuja all
            //mille nimeks on persons
            var persons = from p in person
                          select new
                          {
                              Id = p.Id,
                              Name = p.Name,
                              Age = p.Age
                          };

            //kasutame muutujat persons, et näidata konsoolis tulemust
            foreach (var item in persons)
            {
                Console.WriteLine("Id on " + item.Id + " ja nimi on " + item.Name);
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Kasutame LINQ Selecti ehk teine variant");
            //siin koondame kogu info result muutuja sisse
            var result = person
                //Where-ga saab teha konkreetse päringu, et vastab mingitele tingimustele
                .Where(p => p.Id == 1 || p.Age == 9)
                .OrderBy(p => p.Name) //järjestab isikud nime järgi
                .Select(x => new
                {
                    Id = x.Id,
                    Name = x.Name,
                    Age = x.Age
                });

            //kasutame result muutujat ja teeme ta lahti rea kaupa
            //läbi muutuja item
            foreach (var item in result)
            {
                Console.WriteLine("Id on " + item.Id + " ja nimi on " + item.Name);
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Gruppide kaupa sorteerimine");

            var groupBy = person
                .GroupBy(p => p.Age);
            //kuvab gruppide kaupa ja antud juhul paneb vanused gruppidese
            // e tulemuseks on kolm rida andmeid kuna kaks isikut on 9 a
            foreach (var item in groupBy)
            {
                Console.WriteLine("Vanuse grupp on: {0}", item.Key);
            }
        }
    }
}
