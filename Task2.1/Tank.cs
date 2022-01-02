using System;
using System.Collections.Generic;
using System.Text;

namespace Task2._1
{
    public class Tank
    {
        public double MaxVolume { get; }
        public double CurrentVolume { get; private set; } = 0;

        public Tank(double maxVolume)
        {
            MaxVolume = maxVolume;
        }

        public void Add(double volume)
        {
            if ((CurrentVolume + volume) > MaxVolume)
            {
                CurrentVolume = MaxVolume;
                throw new TankOverflowException();
            }
            else
            {
                CurrentVolume += volume;
            }
        }

        public void Take(double volume)
        {
            if ((CurrentVolume - volume) < 0)
            {
                CurrentVolume = 0;
                throw new NotEnoughException();
            }
            else
            {
                CurrentVolume -= volume;
            }
        }
    }    
}
