using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car lada = new Lada();
            Lada ladaTwo = new Lada();
            var ladaVar = new Lada();
            lada.Move();
            lada.Stop();
            lada.Crash();
            ladaTwo.Move();
            ladaTwo.Stop();
            ladaTwo.Crash();
            ladaVar.Move();
            
            
        }
    }
}