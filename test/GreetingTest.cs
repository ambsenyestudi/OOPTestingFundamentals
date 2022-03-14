using Xunit;

namespace HelloWorld.Domain.Test
{
    public class GreetingTest
    {
        [Fact]
        public void When_Default_Greeting_Hello_Charles()
        {
            var person = new Person();
            person.SetName("Charles");
            var sut = new PersonGreeter(person);
            Assert.Equal("Hello Charles", sut.Greet());
        }

        [Fact]
        public void When_Defined_Greeting_Then_Good_Morning_John()
        {
            var person = new Person();
            person.SetName("John");
            var sut = new PersonGreeter(person, "Good Morning");
            Assert.Equal("Good Morning John", sut.Greet());
        }
    }
}
