﻿namespace HelloWorld.Domain
{
    public class Person
    {
        private string _name;
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetName()
        {
            return _name;
        }
    }
}
