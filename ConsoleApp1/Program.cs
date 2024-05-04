
using System.Globalization;

namespace PCC0104L.Encapsulation.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog pom = new Dog(25.00);
            pom.Breed = "Pitbull";
            pom.Ror();

            Cat siamese = new Cat(45000);
            siamese.Breed = "Siamese";
            siamese.Meow();

            Car civic = new Car(137);
            civic.Type = "civic";
            civic.Broom();

        }
    }

    public class Dog
    {
        public string Breed { get; set; }

        private double Weight { get; set; }

        public Dog() { }

        public Dog(double weight)
        {
            Weight = weight;
        }

        public Dog(double weight, string breed) : this(weight)
        {
            Breed = breed;
        }

        public void Ror()
        {
            Console.WriteLine($"{Breed} - {Weight} Rorrrr!");
        }
    }

    public class Cat
    {
        public string Breed { get; set; }

        private double Price { get; set; }

        public Cat() { }

        public Cat(double price)
        {
            Price = price;
        }

        public Cat(double price, string breed) : this(price)
        {
            Breed = breed;
        }

        public void Meow()
        {
            Console.WriteLine($"{Breed} - {Price} Arfff!");
        }
    }
    public class Car
    {
        public string Type { get; set; }

        private double Speed { get; set; }

        public Car() { }

        public Car(double speed)
        {
            Speed = speed;
        }

        public Car(double speed, string type) : this(speed)
        {
            Type = type;
        }

        public void Broom()
        {
            Console.WriteLine($"{Type} - {Speed} ngeoww!");
        }
    }
}