using System;
using System.Collections.Generic;
using System.Text;

namespace BMI_Program
{
    class BMIMethods
    {
        /* The following methods: weightConversion(), heightConversion(), BMICalculator(), and BMICategory(),
        * take either height, weight, or both as parameters and convert and return a value(s) or category, according to the specified 
        * formula or if, if-else statements (for the BMICategory() method). */

        /* When the WeightConversion() method is called , then the program will prompt the user to enter an amount
        * of weight in pounds. The number given to the program will be stored to the initialized
        * lbWeight variable (of double data type). The converted weight will be stored as kgWeight
        * and will be calculated by calling the weightConversion method that is created later in the program.
        * The second print statement will output the original weight in pounds, and what it's converted
        * amount in kilograms is.*/
        public static void WeightConversion()
        {
            Console.WriteLine("Enter weight in pounds: ");
            double lbWeight = Convert.ToDouble(Console.ReadLine());
            double kgWeight = lbWeight * 0.45;
            Console.WriteLine(lbWeight + " lbs = " + kgWeight + " kg");
        }

        /* When the HeightConversion() method is called, then the program will prompt the user to enter a height in inches to be
        * converted into centimeters. The number input will be stored to the initialized inchesHeight variable
        * (double data type) and the height in inches will be passed to the heightConversion method (defined later
        * in the program) where the value will be converted from inches to centimeters.*/
        public static void HeightConversion()
        {
            Console.WriteLine("Enter height in inches: ");
            double inchesHeight = Convert.ToDouble(Console.ReadLine());
            double cmHeight = inchesHeight * 2.54;
            Console.WriteLine(inchesHeight + " inches = " + cmHeight + " cm");
        }

        /* When the BMICalculator() method is called, then the program will prompt the user to enter a weight in kilograms and 
        * a height in centimeters, separated by a space. The height and weight input will be stored to the initialized 
        * height and weight variable, both are double data type. The height and weight will be passed as parameters
        * to the BMICalculator method, which will calculate the user's BMI and assign it to the the BMI variable.
        * The BMICategory is determined according to the BMI (which is (re)calculated within this method as well, 
        * according to the same height/weight values. */
        public static void BMICalculator()
        {
            Console.WriteLine("Enter weight in kg: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height in centimeters: ");
            double height = Convert.ToDouble(Console.ReadLine());
            double BMI = (weight / height / height) * 10000;

            string category;

            //Depending on the determined BMI, a category is assigned.
            if (BMI < 18.5)
            {
                category = "Underweight\n";
            }
            else if (BMI >= 18.5 && BMI <= 24.99)
            {
                category = "Normal\n";
            }
            else if (BMI >= 25.0 && BMI <= 29.99)
            {
                category = "Overweight";
            }
            else
                category = "Obese\n";

            Console.Write("\nBMI= " + BMI + " Category= " + category);

        }

        //Final method prints an exit message to the user
        public static void CloseProgram()
        {
            Console.WriteLine("Thank you for using the program. Goodbye!");
        }
    }
}
