using System;

namespace PersonalProjectLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool more = true;
            while(more)
            {
                Console.WriteLine("Here is a simplified ballistic calculator. Please do not use units in your answers to the prompts");
                int range = 0;
                int muzzleVelocity = 0;
                int windSpeed = 0;
                double angle = 0;

                Console.WriteLine("Input Desired Range (in yards)");
                string rangeA = Console.ReadLine();
                range = int.Parse(rangeA);

                Console.WriteLine("Input Muzzle Velocity (in feet/second)");
                string muzzleVelocityA = Console.ReadLine();
                muzzleVelocity = int.Parse(muzzleVelocityA);

                Console.WriteLine("Input Angle Above or Below Horizontal (in radians)");
                string angleA = Console.ReadLine();
                angle = double.Parse(angleA);

                Console.WriteLine("Input Wind Speed (in miles/hour)");
                string windSpeedA = Console.ReadLine();
                windSpeed = int.Parse(windSpeedA);

                BallisticCalcsWindage calcs = new BallisticCalcsWindage();
                decimal deflection = calcs.Windage(range, windSpeed);

                BallisticCalcsElevation calculations = new BallisticCalcsElevation();
                decimal elevation4 = calculations.Elevation(range, muzzleVelocity, angle);

                //display elevation change
                Console.WriteLine("The change in elevation (in inches) is "+elevation4);
                //display windage change
                Console.WriteLine("The drift from wind (in inches) is "+deflection);
                Console.WriteLine("Do you wish to run again? Press 1 to continue, 2 to quit.");
                string again = Console.ReadLine();
                if(again == "2")
                {
                    more = false;
                }
            }

        }
    }
}