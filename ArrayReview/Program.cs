using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //Do It 1 - top ten vacation spots, print first and last

            string[] vacationSpots = { "Bali", "Dubai", "Barbados", "Paris", "Las Vegas", "Florence", "Milan", "Hong Kong", "Tokyo", "Edinburgh" };

            Console.WriteLine(vacationSpots[0]);
            Console.WriteLine(vacationSpots[9]);


            //Do It 2 - Ages of 3 children you know, print each

            int[] kidsAges = { 8, 6, 1 };

            foreach (int age in kidsAges)
            {
                Console.WriteLine(age);
            }


            //Do It 3 - Declare and initialize a string array with the days of the week as its elements

            string[] daysOfWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };


            //Do It 4 - Declare and initialize an array of 5 student ages using the 'new' keyword
            int[] studentAges = new int[5];
            studentAges[0] = 19;
            studentAges[1] = 22;
            studentAges[2] = 34;
            studentAges[3] = 25;
            studentAges[4] = 28;

            Console.WriteLine(studentAges[3]);

        }
    }
}