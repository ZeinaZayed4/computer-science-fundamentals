using System;

namespace Day4
{
    abstract class Creature
    {
        public int Age;

        // public virtual void Move()
        // {
        //     Console.WriteLine("Creature is moving..");
        // }

        public abstract void Move();
        
        public virtual void Eat()
        {
            Console.WriteLine("Creature is eating..");
        }

        public virtual void Xyz()
        {
            
        }
    }
}