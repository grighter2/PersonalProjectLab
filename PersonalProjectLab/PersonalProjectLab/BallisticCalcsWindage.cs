using System;
namespace PersonalProjectLab
{
    public class BallisticCalcsWindage
    {
        public BallisticCalcsWindage()
        {
            decimal Windage(decimal range, decimal windSpeed)
            {
                decimal moa = 0;
                decimal deflection = 0;

                if (range <= 500)
                {
                    moa = (decimal)((range / 100) * windSpeed) / 15;
                }
                else if (range <= 600)
                {
                    moa = (decimal)((range / 100) * windSpeed) / 14;
                }
                else if (range <= 800)
                {
                    moa = (decimal)((range / 100) * windSpeed) / 13;
                }
                else if (range <= 900)
                {
                    moa = (decimal)((range / 100) * windSpeed) / 12;
                }
                else
                {
                    moa = (decimal)((range / 100) * windSpeed) / 11;
                }
                deflection = moa * (range / 100);

                return deflection;
            }

        }
    }
}
