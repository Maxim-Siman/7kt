//public abstract class Animal
//{
//    public string Name { get; set; }

//    public abstract void SayHello();
//}
//class Dog : Animal
//{

//    public override void SayHello()
//    {
//        Console.WriteLine($"{Name} сказал привет");
//    }
//}
//class Cat : Animal
//{
//    public override void SayHello()
//    {
//        Console.WriteLine($"{Name} сказал привет");
//    }
//}
//public static class AnimalHelper
//{
//    public static void GreetAnimals(List<Animal> animals, Action<Animal> greetAction)
//    {
//        foreach (var animal in animals)
//        {
//            greetAction(animal);
//        }
//    }
//}
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        var animals = new List<Animal>
//        {
//            new Dog { Name = "asd" },
//            new Cat { Name = "dsa" }
//        };
//        Action<Animal> covariant = (Animal animal) =>
//        {
//            Console.WriteLine("Рычание");
//            animal.SayHello();
//        };
//        Action<Animal> contravariant = (Animal animal) =>
//        {
//            if (animal is Dog)
//            {
//                Console.WriteLine("Лаиние");
//            }
//            else if (animal is Cat)
//            {
//                Console.WriteLine("Мяукание");
//            }
//            animal.SayHello();
//        };
//        AnimalHelper.GreetAnimals(animals, covariant);
//        AnimalHelper.GreetAnimals(animals, contravariant);
//    }
//}

