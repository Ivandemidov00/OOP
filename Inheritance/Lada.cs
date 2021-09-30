using System;

namespace Inheritance
{
    public class Lada:Car
    {
        public void Move() => Console.WriteLine("Move Lada");
        public new void Stop() => Console.WriteLine("StopnLada");
        
        public override void Crash() => Console.WriteLine("CrashLada");
    }
}