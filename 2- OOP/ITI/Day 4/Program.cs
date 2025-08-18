using System;
using System.Net.Http;

namespace Day4
{
    class Program
    {
        public static void MoveCreature(Creature creature)
        {
            creature.Move();
            // + another logic
        }

        public static void MoveCreatures(Creature[] creatures)
        {
            for (int i = 0; i < creatures.Length; i++)
            {
                creatures[i].Move();
            }
        }
        
        static void Main(string[] args)
        {
            // Human human = new Human();
            // human.Move(); // Human is moving..
            // human.Think();

            // Creature creature = new Human();
            // creature.Move(); // Human is moving..

            // Human h = new Human();
            // MoveCreature(h);
            
            // Animal a = new Animal();
            // MoveCreature(a);

            // Creature[] creatures = new Creature[3];
            // creatures[0] = new Creature();
            // creatures[1] = new Human();
            // creatures[2] = new Animal();
            // MoveCreatures(creatures);

            Creature c = new Employee();
            c.Move(); // Employee is moving..
            c.Eat(); // Human is eating..
        }
    }
}