using System;

namespace Encapsulation
{
    public class Microwave
    {
        private Int32 temp { get; set; } = 0;
        public Int32 setTemp(Int32 setTemp) => setTemp > 0 ? temp = setTemp:temp;
        public Eat warm(Eat eat, Int32 temp)
        {
            if (eat.getTemp() <= eat.getTemp()+setTemp(temp))
            {
                eat.setName("сгорело");
                eat.setTemp(setTemp(temp));
            }
            else
            {
                eat.setTemp(setTemp(temp));
            }

            return eat;
        }
    }
}