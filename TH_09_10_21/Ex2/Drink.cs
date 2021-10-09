namespace Ex2
{
    class Drink
    {
        public string Name { get; }
        public double Price { get; }

        public Drink(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
