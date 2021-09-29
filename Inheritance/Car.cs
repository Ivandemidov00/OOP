using System;

namespace Inheritance
{
    public class Car
    {
        private Int32 speed { get; set; } = 0;
        private String name { get; set; }
        public void Move() => Console.WriteLine("move");
        public void Stop() => Console.WriteLine("stop");
        public virtual void Crash() => Console.WriteLine("Crash");
        
    }
}