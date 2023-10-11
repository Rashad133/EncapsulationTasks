using Task1.Model;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Female");
            Dog dog = new Dog("Male","Husky","Pulsar");

            Console.WriteLine($"Date: {dog.BirthDate} Gender:{dog.Gender} Breed: {dog.Breed}  Ad: {dog.Name}");
        }
    }
}