using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace beginner.models.Lasagna
{
    public class Lasagna
    {
        public int ExpectedMinutesInOven()
        {
            return 40;
        }

        public int RemainingMinutes(int passedMinutes)
        {
            return ExpectedMinutesInOven() - passedMinutes;
        }

        public int PreparationTimeInMinutes(int layers)
        {
            return layers * 2;
        }

        public int ElapsedTimeInMinutes(int layers, int passedMinutes)
        {
            return layers * 2 + passedMinutes;
        }
    }
}