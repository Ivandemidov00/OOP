using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Microwave microwave = new Microwave();
            Eat bread = new Eat("bread",45);
            microwave.warm(bread, 56);
            bread.getInfo();
            Console.WriteLine("Hello World!");
        }
    }
}