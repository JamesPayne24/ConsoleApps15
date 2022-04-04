using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// This app will calculate your BMI and tell you if you are Under/Healthy/Over weight.
    /// </summary>
    /// <author>
    /// James Payne 22027350 v.10
    /// </author>
    public class BMI
    {
        public void Run(string[] args)
        { 
            int Menu;
            double BMI;

            Console.WriteLine("This is an BMI Calculator, By enterting your weight and height it will calculate your bmi");

            Console.WriteLine("1. Metric");
            Console.WriteLine("2. Imperial");
            Console.WriteLine("3. Exit");
            Console.WriteLine("press 1 for metric, 2 for imperial or 3 to exit: ");
            Menu = Convert.ToInt32(Console.ReadLine());

            if (Menu == 1)
            {

                //getheight
                Console.WriteLine("What is your Height? (m)");
                double height = Convert.ToDouble(Console.ReadLine());
                //getweight
                Console.WriteLine("What is your Weight? (kg)");
                double weight = Convert.ToDouble(Console.ReadLine());
                //calcbmi
                double bmi = weight / (height * height);

                bmi = Math.Round(bmi, 2);
                Console.WriteLine("Your Bmi is :" + bmi);

                //display weight health
                if (bmi < 16)
                    Console.WriteLine("You're severly underweight");
                else
                if (bmi <= 18.5)
                    Console.WriteLine("You're underweight");

                else
                if (bmi <= 25)
                    Console.WriteLine("You're normal weight");
                else
                if (bmi <= 30)
                    Console.WriteLine("You're overweight");
                else
                if (bmi <= 35)
                    Console.WriteLine("You're moderately overweight");
                else
                    Console.WriteLine("You're obese");

                Console.WriteLine("If you are Black, Asian or other minority ethnic groups, you may have a higher risk");
                Console.WriteLine("Adults 23.0 or more are at an increased risk");
                Console.WriteLine("Adults 27.5 or more are at high risk");
            }

            if (Menu == 2)
            {
                //getheight
                Console.WriteLine("What is your Height? (inches)");
                double heightI = Convert.ToDouble(Console.ReadLine());
                //getweight
                Console.WriteLine("What is your Weight? (pounds)");
                double weightP = Convert.ToDouble(Console.ReadLine());
                //calcbmi
                double bmi = weightP / (heightI * heightI) * 703;

                bmi = Math.Round(bmi, 2);
                Console.WriteLine("Your Bmi is :" + bmi);

                //display weight health
                if (bmi < 16)
                    Console.WriteLine("You're severly underweight");
                else
                if (bmi <= 17.5)
                    Console.WriteLine("You're underweight");

                else
                if (bmi <= 25)
                    Console.WriteLine("You're normal weight");
                else
                if (bmi <= 30)
                    Console.WriteLine("You're overweight");
                else
                if (bmi <= 35)
                    Console.WriteLine("You're moderately overweight");
                else
                    Console.WriteLine("You're obese");

                Console.WriteLine("If you are Black, Asian or other minority ethnic groups, you may have a higher risk");
                Console.WriteLine("Adults 23.0 or more are at an increased risk");
                Console.WriteLine("Adults 27.5 or more are at high risk");

            }
            else if (Menu == 3)
            {
                Console.WriteLine("end program");

            }
        }

    }
}
