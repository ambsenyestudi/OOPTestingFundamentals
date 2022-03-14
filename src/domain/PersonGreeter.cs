namespace HelloWorld.Domain
{
    public class PersonGreeter
    {
        private readonly Person _person;
        private readonly string _greeting;

        public PersonGreeter(Person person, string greeting = "Hello")
        {
            _person = person;
            _greeting = greeting;
        }
        public string Greet()
        {
            return ToString();
        }
        public override string ToString()
        {
            return _greeting +" "+ _person.GetName();
        }
    }
}
