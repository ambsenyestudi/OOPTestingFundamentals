using System.Collections.Generic;
using Xunit;

namespace HelloWorld.Domain.Test
{
    public class PersonGreeterTest
    {
        [Fact]
        public void When_Default_Greeting_Hello_Charles_And_Mary()
        {
            var peopleList = new List<Person>{
                new Person { Name = "Charles" },
                new Person { Name = "Mary"}
            };
            var sut = new PeopleGreeter(peopleList);
            Assert.Equal("Hello Charles and Mary", sut.Greet());
        }

        [Fact]
        public void When_Defined_Greeting_Then_Good_Morning_John_Mary_And_Pamela()
        {
            var peopleList = new List<Person>{
                new Person { Name = "John"  },
                new Person { Name = "Mary"},
                new Person { Name = "Pamela"},
            };
            var sut = new PeopleGreeter(peopleList);
            Assert.Equal("Good Morning John, Mary and Pamela", sut.Greet("Good Morning"));
        }
    }
}
