using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03

{
    public class StudentGrades

    {
        public void Run()
        { 

        static bool ReadInteger(out int n)

        {

            string input = System.Console.ReadLine();

            n = 0;

            try

            {

                n = Convert.ToInt32(input);

                return true;

            }

            catch (System.Exception ex)

            {

                System.Console.WriteLine("Error in the input format\n\n");

                return false;

            }

        }



        static void Main(string[] args)

        {

            System.Console.WriteLine("Program for simple student grading,By James Payne.");



            const int MAX_STUDENTS = 10;



            int[] arrMark = new int[MAX_STUDENTS];

            string grade = "";



            for (int i = 0; i < MAX_STUDENTS; i++)

            {

                System.Console.Write("Enter {0} Student Mark: ", i + 1);

                ReadInteger(out arrMark[i]);

            }

            System.Console.Write("\n\nNo\tMark\tGrade\n");



            for (int i = 0; i < MAX_STUDENTS; i++)

            {

                if (arrMark[i] > 100)

                    grade = "Error";

                else if (arrMark[i] > 90)

                    grade = "A+";

                else if (arrMark[i] > 70)

                    grade = "B+";

                else if (arrMark[i] > 50)
                    grade = "C+";

                else if (arrMark[i] > 30)

                    grade = "C";

                else

                    grade = "F";

                System.Console.Write("{0}\t{1}\t{2}\n", i + 1, arrMark[i], grade);

            }



        }

    }



}