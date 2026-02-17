using LINQ.Models;

namespace LINQ
{
    public class PeopleData
    {
        public static readonly List<PeopleList> peoples = new List<PeopleList>
        {
            new PeopleList()
            {
                Id = 1,
                Name = "Moona",
                Age = 31,
                GenderId = Guid.Parse("63a694f3-e80e-4df2-af2e-f35c5d973105")
            },
            new PeopleList()
            {
                Id = 2,
                Name = "Poona",
                Age = 21,
                GenderId = Guid.Parse("bdf2fa86-d8dd-4548-bc98-3f15907b8e55")
            },
            new PeopleList()
            {
                Id = 3,
                Name = "Ron",
                Age = 18,
                GenderId = Guid.Parse("bdf2fa86-d8dd-4548-bc98-3f15907b8e55")
            },
            new PeopleList()
            {
                Id = 4,
                Name = "Anna",
                Age = 20,
                GenderId = Guid.Parse("63a694f3-e80e-4df2-af2e-f35c5d973105")
            },
            new PeopleList()
            {
                Id = 5,
                Name = "Mari",
                Age = 19,
                GenderId = Guid.Parse("63a694f3-e80e-4df2-af2e-f35c5d973105")
            },
            new PeopleList()
            {
                Id = 6,
                Name = "Mari",
                Age = 21,
                GenderId = Guid.Parse("63a694f3-e80e-4df2-af2e-f35c5d973105")
            },
            new PeopleList()
            {
                Id = 7,
                Name = "Bill",
                Age = 21,
                GenderId = Guid.Parse("bdf2fa86-d8dd-4548-bc98-3f15907b8e55")
            },
        };
    }
}
