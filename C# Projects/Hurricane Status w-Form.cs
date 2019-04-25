using System;
using static System.Console;

namespace Hurricane_Status
{
    class Program
    {
        static void Main(string[] args)
        {

         
            String CAT5;
            String CAT4;
            String CAT3;
            String CAT2;
            String CAT1;
            String CAT0;

            CAT5 = "This is a category 5 Hurricane";
            CAT4 = "This is a category 4 Hurricane";
            CAT3 = " This is a category 3 Hurricane";
            CAT2 = "This is a category 2 Hurricane";
            CAT1 = "This is a category 1 Hurricane";
            CAT0 = "This is a Hurrican't it is not a Hurricante";



            WriteLine("Enter the Windspeed of the Storm:");
            Double windSpeed = Convert.ToDouble(ReadLine());




            if (windSpeed >= 157)
                WriteLine(CAT5);



            else if (windSpeed >= 130)
                WriteLine(CAT4);

            else if (windSpeed >= 111)
                WriteLine(CAT3);

            else if (windSpeed >= 96)
                WriteLine(CAT2);

            else if (windSpeed >= 74)
                WriteLine(CAT1);

            else if (windSpeed <= 74)
                WriteLine(CAT0);

        }
    }
    }

