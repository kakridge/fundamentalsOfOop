namespace FundamentalsOfOop
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public abstract string Speak();
    }
}