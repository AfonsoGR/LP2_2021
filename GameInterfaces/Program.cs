using System;

namespace GameInterfaces
{
    class Program : IHasValue
    {
        static void Main(string[] args)
        {
            IHasValue prev = null;
            IHasValue[] stuff = new IHasValue[5];
            stuff[0] = new Building("Flat", 25);
            stuff [1] = new MilitaryUnit (3, 100, 10);

            foreach (IHasValue thing in stuff)
            {
                Console.WriteLine(thing.GetType().Name);
                Console.WriteLine(thing.Equals(prev));
                prev = thing;
            }
        }
    }
}
