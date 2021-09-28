using System;

namespace Encapsulation
{
    public class Microwave
    {
        private Int32 temp = 0;
        public Int32 setTemp(Int32 setTemp) => setTemp > 0 ? temp = setTemp:temp;
        public Eat warm(Eat eat, Int32 temp)
        {
            if (eat.maxTemp <= eat.temp+setTemp(temp))
            {
                eat.Name = "сгорело";
                eat.temp += setTemp(temp);
            }
            else
            {
                eat.temp += setTemp(temp);
            }

            return eat;
        }
    }
}