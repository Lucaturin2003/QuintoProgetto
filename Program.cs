using System.Diagnostics.CodeAnalysis;

namespace AccessModifier
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        public Vehicle()
        {
            Console.WriteLine("Veicle is being initialized.");
        }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine("Veicle is being initialized " + registrationNumber);
        }
    }

    public class Car: Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car is being initialized");
        }

        public Car(string registrationNumber): base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized " + registrationNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Registration");
        }
    }
}
