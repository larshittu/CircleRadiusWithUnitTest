using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static int radius = 0;
        static void Main(string[] args)
        {

            Console.WriteLine($"*****Welcome to Prisca Circle automation program, what would you like to do?***** \n\n");
            Circle circle = new Circle(67);//Setting constructor circle values
            
            while (true)
            {                
                UserRequest();

                var actionString = Console.ReadLine();
                while (!InputValidation(actionString))//Validating user action input
                {
                    actionString = Console.ReadLine();
                }

                int action = Convert.ToInt32(actionString);
                UserResult(action);
            }
        }

        //User Result Method
        private static void UserResult(int action)
        {
            int result = 0;
            switch (action)
            {
                case 1:
                    {
                        result = Circle.GetRadius();
                        Console.WriteLine($"The Circle Radius is {result} \n\n");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter new Circle Radius:");
                        string stringlength = Console.ReadLine();
                        while (!InputValidation(stringlength))
                        {
                            stringlength = Console.ReadLine();
                        }
                        radius = Convert.ToInt32(stringlength);
                        Circle.SetRadius(radius);
                        Console.WriteLine($"The new Circle radius is {radius} \n\n");
                        break;
                    }
                case 3:
                    {
                        var circumference = Circle.GetCircumference();
                        Console.WriteLine($"The Circle circumference is {circumference} \n\n");
                        break;
                    }
                case 4:
                    {
                        var area = Circle.GetArea();
                        Console.WriteLine($"The Circle area is {area} \n\n");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Thank you!!!");
                        Environment.Exit(0);
                        break;
                    }
                default:
                    Console.WriteLine("Invalid or Wrong action!! try again with list items.\n\n");
                    break;

            }
        }

        //User question Method
        public static void UserRequest()
        {
            Console.WriteLine("1. Get Radius");
            Console.WriteLine("2. Set Radius");
            Console.WriteLine("3. Get Circumference");
            Console.WriteLine("4. Get Area");
            Console.WriteLine("5. Exit \n");
        }

        public static bool InputValidation(string userInput)//User input validation Method
        {
            try
            {
                var inputValue = Convert.ToInt32(userInput);
                if (inputValue < 1)
                {
                    Console.WriteLine("Invalid user input value, try again:");
                    userInput = Console.ReadLine();

                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid user input value:");
                return false;
            }
        }
    }
}
