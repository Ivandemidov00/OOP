using System;

namespace Encapsulation
{
    public class Eat
    {
        public Eat(String name, Int32 maxTemp) => (this.maxTemp, Name) = (maxTemp, name);
        private String Name { get; set; }
        private Int32 Temp { get; set; } = 0;
        private Int32 maxTemp { get; set; }
        public Int32 getTemp()
        {
            return Temp;
        }
        public void setName(String name)
        {
            Name = name;
        }
        public void setTemp(Int32 temp)
        {
            Temp = temp;
        }
        public void getInfo() => Console.WriteLine("Name: {0}, temp: {1}", Name, Temp);


    }
}