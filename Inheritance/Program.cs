using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            People people = new People("dfgd",90);
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
            people.Hello();
            
            
        }
    }
}