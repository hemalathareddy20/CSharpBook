using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.Opps
{
    // Base class
    class Vehicle
    {
        public string Brand { get; set; }
        public string Color { get; set; }

        public void Start()
        {
            Console.WriteLine("The vehicle starts.");
        }

        public void Stop()
        {
            Console.WriteLine("The vehicle stops.");
        }
    }

    // Derived class
    /// <summary>
    /// The derived class Car inherits from the Vehicle class using the : Vehicle syntax.
    /// It adds an additional method called Accelerate.
    /// </summary>
    class Car : Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("The car accelerates.");
        }
        
    }

    // Derived class
    class Motorcycle : Vehicle
    {
        public void TwoWheeler()
        {
            Console.WriteLine("The vehicle is a Twowheeler.");
        }
        
    }
    // Derived class
    /// <summary>
    /// cycle class inherit from the motorcycle class and motor class inherit from vehicle
    /// so cycle class can access both the class data
    /// </summary>
    class Cycle : Motorcycle
    {
        public void Break()
        {
            Console.WriteLine("The cycle breaks.");
        }       
    }
    public class Inheritance
    {
        public void InheritanceMethod()
        {
            Car car = new Car();
            car.Brand = "Ford";
            car.Color = "Red";

            car.Start();
            car.Accelerate();
            car.Stop();

            Motorcycle motorcycle = new Motorcycle();
            motorcycle.Brand = "Honda";
            motorcycle.Color = "Blue";

            motorcycle.Start();
            motorcycle.TwoWheeler();
            motorcycle.Stop();

            Cycle cycle = new Cycle();
            cycle.Brand = "Honda";
            cycle.Color = "Black";

            cycle.TwoWheeler();
            cycle.Start();
            cycle.Break();
            
        }
    }
}
