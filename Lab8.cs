using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int num;
            string response = "y";
            string[] studentNames = { "Yaya", "Lou", "Jackie", "Kachay","Twin", "Quis", "Tone", "Jack", "Tee", "George", "Kelly", "Kam",
                "Sylvia", "Stephanie","Syerra", "Synthia", "Shannon","Zach","Trey", "Chris" };
            string[] studentHometown = { "Yonkers", "Little Rock", "Jeruselum", "Kansas City", "Trenton", "Quebec City", "Toronto", "Jacksonville",
            "Tampa", "Grand Rapids", "Kileen", "Knoxville", "Singapore", "St. Louis", "Salt Lake City", "San Fransisco", "San Antonio", "Zagazig", "Tampa", "Chicago"};
            string[] studentFoods = { "Yakisoba", "Lasagna", "Jumbo Shrimp", "Kale", "Twizzlers","Quesadillas", "Twix", "Jerk Chicken", "Tea Leaves",
            "Gumbo", "Kimchi", "Kidney Beans", "Sword Fish", "Sauercraut", "Salad", "Spaghetti","Scallops", "Zuchinni", "Tilapia", "Chicken"};

            while (response == "y") //while loop to ask user if they want to continue
            {
                Console.WriteLine("Welcome to our C# Class. Which student would you like to learn more about? (Enter a number 1-20): ");
                input = Console.ReadLine();
                bool valid = int.TryParse(input, out num);
                while (!valid || num < 1 || num > studentNames.Length)
                {
                    Console.WriteLine("That student does not exist. Please try again.");
                    Console.WriteLine("Enter a number 1-20: ");
                    input = Console.ReadLine();
                    valid = int.TryParse(input, out num);
                }
                for (int i = 0; i < studentNames.Length; i++) //for loop 
                {
                    if (num == i + 1) // so that index selects 1 instead of 0...and so on
                    {
                        Console.WriteLine($"Student {num} is {studentNames[i]}");
                        Console.Write($"What would you like to know about {studentNames[i]}? (Enter 'hometown' or 'favorite food'): ");
                        string wantToKnow = Console.ReadLine().ToLower();
                        while (wantToKnow != "hometown" && wantToKnow != "favorite food") {

                            Console.WriteLine("That data does not exist. Please try again (Enter 'hometown' or 'favorite food'): ");
                            wantToKnow = Console.ReadLine().ToLower();
                        }
                        switch (wantToKnow) //switch statement to decide what to do for each option
                        {
                            case "hometown":
                                Console.WriteLine($"{studentNames[i]}'s hometown is: {studentHometown[i]}");
                                break;
                            case "favorite food":
                                Console.WriteLine($"{studentNames[i]}'s age is: { studentFoods[i]}");
                                break;
                            default:
                                Console.WriteLine("That data does not exist. Please try again. (Enter 'hometown' or 'age'): ");

                                break;
                        }
                    }
                    else if (num > studentNames.Length || num < 1) //catches numbers that are out of bounds
                    {
                        Console.WriteLine("That student does not exist ");
                        break;
                    }
                    else {
                    }
                }
                Console.WriteLine("Would you like to continue? (y/n)"); //allows user to end program or continue using
                response = Console.ReadLine().ToLower();
            }

            Console.WriteLine("\nThanks!");
            Console.ReadKey();

        }
    }
}
