namespace CuteAnimal
{
    public class Cat
    {
        private readonly string name;
        private int energy;
        private Feed feed;
        private Mood mood;

        public void Eat();
        public void Sleep();
        public void Meow();
        public void Play();
    }
}