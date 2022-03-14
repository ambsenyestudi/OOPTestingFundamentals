using Xunit;

namespace HelloWorld.Domain.Test
{
    public class GreetingTest
    {
        [Theory]
        [InlineData("Charles")]
        [InlineData("Peter")]
        [InlineData("Ralph")]
        public void When_Default_Greeting_Then_Contains_Name(string name)
        {
            //Arrange
            var person = new Person { Name = name };
            var sut = new PersonGreeter(person);
            //Act
            var greeting = sut.Greet();
            //Assert
            Assert.Contains(name, greeting);
        }

        [Fact]
        public void When_Defined_Greeting_Then_Good_Morning_John()
        {
            //Arrange
            var expectedGreeting = "Good Morning John";
            var personName = "John";
            var person = new Person { Name = personName };
            var sut = new PersonGreeter(person, "Good Morning");
            //Act 
            var greeting = sut.Greet();
            //Assert
            Assert.Equal(expectedGreeting, greeting);
        }
    }
}
