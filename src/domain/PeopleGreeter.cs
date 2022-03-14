using System.Collections.Generic;

namespace HelloWorld.Domain
{
    public class PeopleGreeter
    {
        private readonly List<Person> _peopleList;

        public PeopleGreeter(List<Person> peopleList)
        {
            _peopleList = peopleList;
        }
        public string Greet(string greeting = "Hello")
        {
            return _peopleList.ToGreeting(greeting);
        }
    }
}
