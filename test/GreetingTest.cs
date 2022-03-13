using Xunit;

namespace HelloWorld.Domain.Test
{
    public class GreetingTest
    {
        [Fact]
        public void When_Person_Name_Charles_Then_Greet()
        {
            Person.Name = "Charles";
            Assert.Equal("Hello world Charles", Greeting.HelloWorld());
        }
        
    }
}
