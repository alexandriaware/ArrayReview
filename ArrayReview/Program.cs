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

        }
    }
}
