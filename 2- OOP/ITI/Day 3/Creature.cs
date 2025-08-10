using System;

namespace Day3
{
    public class Creature
    {
        public string Name;
        protected int Weight;
        private int _age;

        public Creature()
        {
            
        }

        public Creature(int age)
        {
            _age = age;
        }
        
        public void Move()
        {
            Console.WriteLine("Creature is moving...");
        }

        private void Eat()
        {
            Console.WriteLine("Creature is eating...");
        }
    }
}