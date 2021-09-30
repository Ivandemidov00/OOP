using System;

namespace Inheritance
{
    public sealed class People
    {
        private String name { get; set; }
        private Int32 age { get; set; }
        public People(String Name, Int32 Age) => (name, age) = (Name, Age); 
        public void Hello() => Console.WriteLine("Hello, I'm {0} {1} age", name, age);
    }
}