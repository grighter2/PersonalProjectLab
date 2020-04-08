using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalProjectLab
{
    class BallisticCalcsElevation
    {
        public decimal Elevation(int range, int muzzleVelocity, double angle)
        {
            int time = 0;
            int time2 = 0;
            double inMuzzleVelocity = 0;
            double elevation = 0;
            double elevation2 = 0;

            inMuzzleVelocity = muzzleVelocity * 12;
            decimal inMuzzleVelocityii = Convert.ToDecimal(inMuzzleVelocity);
            Decimal.ToInt64(inMuzzleVelocityii);
           
            double angle2 = Math.Sin(angle);
            
            time = (range * 3) / muzzleVelocity;
            time2 = time;
            Convert.ToDouble(time2);
            double timeSquared = Math.Pow(time2, 2);
            Convert.ToDecimal(timeSquared);

            Convert.ToDecimal(angle2);
            elevation = ((inMuzzleVelocityii * time) * angle2);
            elevation2 = elevation - (0.5 * 386.09 * timeSquared);
            
            return elevation2;
        }
    }
}
