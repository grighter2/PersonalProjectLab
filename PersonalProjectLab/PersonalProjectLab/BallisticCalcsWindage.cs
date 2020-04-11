using System;
namespace PersonalProjectLab
{
    public class BallisticCalcsWindage
    {
        public decimal Windage(int range, int windSpeed)
        {
                decimal moa = 0;
                decimal deflection = 0;

                if (range <= 500)
                {
                    moa = ((range / 100) * windSpeed) / 15;
                }
                else if (range <= 600)
                {
                    moa = ((range / 100) * windSpeed) / 14;
                }
                else if (range <= 800)
                {
                    moa = ((range / 100) * windSpeed) / 13;
                }
                else if (range <= 900)
                {
                    moa = ((range / 100) * windSpeed) / 12;
                }
                else
                {
                    moa = ((range / 100) * windSpeed) / 11;
                }
                deflection = moa * (range / 100);

                return deflection;
        }
    }
}
