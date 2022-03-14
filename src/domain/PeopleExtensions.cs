using System.Collections.Generic;
using System.Linq;

namespace HelloWorld.Domain
{
    public static class PeopleExtensions
    {
        public static string ToGreeting(this IEnumerable<Person> peopleList, string greeting)
        {
            var lastPerson = peopleList.Last().Name;
            var restOfPeople = peopleList.Take(peopleList.Count() - 1).Select(x=>x.Name);
            if(restOfPeople.Count() == 1)
            {
                return $"{greeting} {restOfPeople.First()} and {lastPerson}";
            }
            var peoplePart = string.Join(", ", restOfPeople);
            return $"{greeting} {peoplePart} and {lastPerson}";
        }

    }
}
