using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Eat bread = new Eat() { Name = "bread" ,maxTemp = 45};
            Microwave microwave = new Microwave();
            microwave.warm(bread, 56);
            bread.getInfo();
            Console.WriteLine("Hello World!");
        }
    }
}