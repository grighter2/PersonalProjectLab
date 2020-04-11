using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalProjectLab
{
    public class BallisticCalcsElevation
    {
        public decimal Elevation(int range, int muzzleVelocity, double angle)
        {
            int time = 0;
            int angle3 = 0;
            int inMuzzleVelocity = 0;
            int elevation = 0;
            int elevation2 = 0;
            double elevation3 = 0;

            inMuzzleVelocity = muzzleVelocity * 12;
            double angle2 = Math.Sin(angle);
            angle3 = Convert.ToInt32(angle2);

            time = (range * 3) / muzzleVelocity;
            double timeSquared = Math.Pow(time, 2);
            Convert.ToDecimal(timeSquared);

            elevation = inMuzzleVelocity * time;
            elevation2 = elevation * (angle3);
            elevation3 = elevation2 - (0.5 * 386.09 * timeSquared);
            decimal elevation4 = Convert.ToDecimal(elevation3);
            return elevation4;
        }
    }
}
