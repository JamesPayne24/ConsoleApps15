using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter
{
    class DistanceConverter
    {
        public void Run(string[] args)
        {

            int Menu;


            Console.WriteLine("This is a distance conversion application, Please enter youre desired measurement format");

            Console.WriteLine("1. Miles");
            Console.WriteLine("2. Feet");
            Console.WriteLine("3. Metres");
            Console.WriteLine("4. Quit");
            Console.WriteLine("press 1 for Miles, 2 for Feet, 3 for Metres or 4 to quit: ");
            Menu = Convert.ToInt32(Console.ReadLine());

            if (Menu == 1)

            {
                int Miles;
                float Feet, Meters;
                Console.Write("Enter Distance In Miles :");
                Miles = Convert.ToInt32(Console.ReadLine());
                Feet = Miles * 5280;
                Meters = Miles * 1609.34f;
                Console.WriteLine("Distance in Meter :" + Meters);
                Console.WriteLine("Distance in Feet :" + Feet);
            }
            else
            if (Menu == 2)

            {
                int Feet;
                float Miles, Meters;
                Console.Write("Enter Distance In Feet :");
                Feet = Convert.ToInt32(Console.ReadLine());
                Miles = Feet / 5280;
                Meters = Feet * 0.3048f;
                Console.WriteLine("Distance in Meter :" + Meters);
                Console.WriteLine("Distance in Miles :" + Miles);
            }

            else
            if (Menu == 3)

            {
                int Meters;
                float Miles, Feet;
                Console.Write("Enter Distance In Meters :");
                Meters = Convert.ToInt32(Console.ReadLine());
                Miles = Meters * 1609.34f;
                Feet = Meters * 3.28084f;
                Console.WriteLine("Distance in Miles :" + Miles);
                Console.WriteLine("Distance in Feet :" + Feet);
            }
            else if (Menu == 4)
            {
                Console.WriteLine("end program");



            }
        }
    }
}