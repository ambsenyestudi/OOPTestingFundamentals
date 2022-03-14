using System.Collections.Generic;
using Xunit;

namespace HelloWorld.Domain.Test
{
    public class PersonGreeterTest
    {
        [Fact]
        public void When_Default_Greeting_Hello_Charles_And_Mary()
        {
            //Arrange
            var exectedGreeting = "Hello Charles and Mary";
            var peopleList = new List<Person>{
                new Person { Name = "Charles" },
                new Person { Name = "Mary"}
            };
            var sut = new PeopleGreeter(peopleList);
            //Act
            var result = sut.Greet();
            //Assert
            Assert.Equal(exectedGreeting, result);
        }

        [Fact]
        public void When_Defined_Greeting_Then_Good_Morning_John_Mary_And_Pamela()
        {
            //Arrange
            var exptectedGreeting = "Good Morning John, Mary and Pamela";
            var peopleList = new List<Person>{
                new Person { Name = "John"  },
                new Person { Name = "Mary"},
                new Person { Name = "Pamela"},
            };
            var sut = new PeopleGreeter(peopleList);
            //Act
            var result = sut.Greet("Good Morning");
            //Assert
            Assert.Equal(exptectedGreeting, result);
        }
    }
}
