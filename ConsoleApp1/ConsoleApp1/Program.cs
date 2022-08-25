using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

             
            Console.WriteLine("Angle between hours arrow and minutes arrow is: " + CalculateAngle(9, 60));
            Console.Write("Angle between hours arrow and minutes arrow is: " + CalculateAngle(3, 30));

        }
        
        static int  CalculateAngle(double h, double m)
        {
            // validate the input
            if (h < 0 || m < 0 ||
                h > 12 || m > 60)
                Console.Write("Wrong input");

            if (h == 12)
                h = 0;

            if (m == 60)
            {
                m = 0;
                h += 1;
                if (h > 12)
                    h = h - 12;
            }

            // Calculate the angles moved by hour and
            // minute hands with reference to 12:00
            int hourAngle = (int)(0.5 * (h * 60 + m));
            int minuteAngle = (int)(6 * m);

          
            // Find the difference between two angles
            int angle = Math.Abs(hourAngle - minuteAngle);

            // smaller angle of two possible angles
            angle = Math.Min(360 - angle, angle);

            return angle;
        }
    }
}
