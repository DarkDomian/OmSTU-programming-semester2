namespace Village
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Animal();
            Console.WriteLine(dog);

            dog.Breed = "Australian Shepherd";
            dog.Age = 2;
            dog.Height = 0.78;
            dog.Weight = 29.9;

            Console.WriteLine(dog);

            Animal cat = new Animal("Maine Coon", 4, 8.5, 0.35);
            Console.WriteLine(cat);

            Console.WriteLine("Check the getter work: {0}", dog.Age);
        }
    }
    class Animal
    {
        public string Breed { get; set; }
        public byte Age { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }

        public Animal()
        {
            Breed = "Unknown";
        }

        public Animal(string breed, byte age, double weight, double height)
        {
            Breed = breed;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return string.Format(
                "Animal:\n{0,-10}: {1}\n{2,-10}: {3}\n{4,-10}: {5} kg\n{6,-10}: {7} m\n",
                "Breed", Breed, "Age", Age, "Weight", Weight, "Height", Height
            );
        }
    }
}