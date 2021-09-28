using System;

namespace CuteAnimal
{
    public class Cat
    {   
        private readonly string name;
        private int energy;
        private Feed feed;
        private Mood mood;

        // Constructor
        public Cat (string name, int energy)
        {
            name = name;
            energy = energy;
        }

        // X
        public void Eat()
        {
            
        }
        
        // X
        public void Sleep()
        {
            Console.WriteLine("How long is the Cat resting?");
            int sleepTime = Convert.ToInt32( Console.ReadLine());
            energy = energy + sleepTime;
        }
        
        // X
        public void Meow()
        {

        }
        
        // X
        public void Play()
        {

        }
        
    }
}