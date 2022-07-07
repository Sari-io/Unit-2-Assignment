using System;

namespace IT213_Douglass_Unit_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // here are my variables
            int number1;
            int number2;
            double grade;
            int month;
            int dayOfWeek;
            //compare the 2 whole numbers 
            Console.WriteLine("Enter first integer: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second integar: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 == number2)
                Console.WriteLine("{0} = {1}", number1, number2);
            if (number1 != number2)
                Console.WriteLine("{0} <> {1}", number1, number2);
            if (number1 == number2)
                Console.WriteLine("{0} < {1}", number1, number2);
            if (number1 == number2)
                Console.WriteLine("{0} > {1}", number1, number2);
            if (number1 == number2)
                Console.WriteLine("{0} <= {1}", number1, number2);
            if (number1 == number2)
                Console.WriteLine("{0} >= {1}", number1, number2);
            // section 2
            //using if statements to display the grade if the grade is equal to or less than 60 its a failing grade otherwise it is passing
            Console.WriteLine("Enter your grade to see if you passed: ");
            grade = Convert.ToInt32(Console.ReadLine());

            if (grade >= 60)
                Console.WriteLine("Congradulations, you passed.");
            else
                Console.WriteLine("Sorry, you failed.");

            // section 3
            // series of if else statements to determine the month entered by user and display
            Console.WriteLine("Enter the number of the month: ");
            month = Convert.ToInt32(Console.ReadLine());

            if (month == 1)
            {
                Console.WriteLine("The month is January.");
            }
            else if (month == 2)
            {
                Console.WriteLine("The month is February.");
            }
            else if (month == 3)
            {
                Console.WriteLine("The month is March.");
            }
            else if (month == 4)
            {
                Console.WriteLine("The month is April.");
            }
            else if (month == 5)
            {
                Console.WriteLine("The month is May.");
            }
            else if (month == 6)
            {
                Console.WriteLine("The month is June.");
            }
            else if (month == 7)
            {
                Console.WriteLine("The month is July.");
            }
            else if (month == 8)
            {
                Console.WriteLine("The month is August.");
            }
            else if (month == 9)
            {
                Console.WriteLine("The month is September.");
            }
            else if (month == 10)
            {
                Console.WriteLine("The month is October.");
            }
            else if (month == 11)
            {
                Console.WriteLine("The month is November.");
            }
            else if (month == 12)
            {
                Console.WriteLine("The month is December.");
            }
            else// write error message if month is invalid
                Console.WriteLine("Invalid month.");
            // Section 4 switch statement to determine which day of the week that is entered and will display.

            Console.WriteLine("Enter the number of the day of the week: ");
            dayOfWeek = Convert.ToInt32(Console.ReadLine());

            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
               // error messsage
                default:
                    Console.WriteLine("Invalid Day.");
                    break;
            }
            //keeps console open
            Console.Read();
            
        }
    }
}
