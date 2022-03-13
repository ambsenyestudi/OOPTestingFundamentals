using Xunit;

namespace HelloWorld.Domain.Test
{
    public class GreetingTest
    {
        [Fact]
        public void When_Greeting_Then_Hello_World()
        {
            Assert.Equal("Hello world", Greeting.HelloWorld());
        }
    }
}
