/* Purpose of Program: This program is designed to calculate a user's body mass index (BMI).
 * There are four options displayed to the user (in a menu-type format) and certain actions
 * will be executed depending on what is selected. The options include: converting pounds
 * into kilogragrams, converting height from inches to centimeters, calculating BMIs and
 * displaying a category based on said value. The final option, if selected, will exit the 
 * program.
 */
using System;

namespace BMI_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /* This while loop will host the program's prompts, variables, and switch statement.
            * This first section of print statements will display the "menu"
            * of options to the user. */
            while (true)
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1: Convert pounds into kilograms");
                Console.WriteLine("2: Convert height in inches to centimeters");
                Console.WriteLine("3: Calculate BMI using weight in kilograms and display category");
                Console.WriteLine("9: Exit program");

                /* Following the print statements, the program will prompt the user to choose one
                * of the above options and enter/input the corresponding integer. The number input
                * will be known as the "selection" variable. 
                */
                Console.WriteLine("Enter your selection: ");
                int selection = Convert.ToInt32(Console.ReadLine());

                //This swtich will take the user's selection as an argument and execute accordingly.
                switch (selection)
                {
                    //If the number 1 is input, the WeightConversion() method will be called.
                    case 1:
                        BMIMethods.WeightConversion();
                        break;
                    //If the number 2 is input, the HeightConversion() method is called.
                    case 2:
                        BMIMethods.HeightConversion();
                        break;

                    //If the number 3 is input, the BMICalculator is called.
                    case 3:
                        BMIMethods.BMICalculator();
                        break;

                    //If the number 9 is input, the program will call a method to close out the program.
                    case 9:
                        BMIMethods.CloseProgram();
                        return;
                }
            }
        }
    }
}
