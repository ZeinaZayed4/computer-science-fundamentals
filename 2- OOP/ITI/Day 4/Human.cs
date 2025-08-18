using System;

namespace Day4
{
    class Human : Creature
    {
        public override void Move()
        {
            Console.WriteLine("Human is moving..");
        }

        public override void Eat()
        {
            Console.WriteLine("Human is eating");
        }
        
        public void Think()
        {
            Move(); // Human is moving..
            // base.Move(); // Creature is moving..
            Console.WriteLine("Human is thinking..");
        }

        public new void Xyz()
        {
            
        }
    }
}