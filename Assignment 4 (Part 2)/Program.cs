using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4__Part_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("This program was created for an Airline Reservation System, ");
            Console.WriteLine("the user will select a compartment in the flight where he or she would like to");
            Console.WriteLine("sit, and the app will output the results randomly through simulation!");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Press any key to begin...");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("*                         Welcome to Qatar Airways! :)                        *");
            Console.WriteLine("-------------------------------------------------------------------------------");
            Console.WriteLine("This is our Airline Reservation System, and we will help you find the best seat on our flight!");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");

            string firstName;
            string lastName;

            Console.WriteLine();
            Console.Write("Enter your first name: ");
            firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            lastName = Console.ReadLine();

            Random rand = new Random();
            bool[] seats = new bool[10];
            bool firstClassFull = false;
            bool secondClassFull = false;
            List<int> seatsBooked = new List<int>();
            int firstClass;
            int economyClass;
            int seatOption = 0;

            Console.WriteLine();

            do
            {
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("Hey {0} {1}, in which tier or compartment of the flight ", firstName, lastName);
                Console.WriteLine("you want to sit in?");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("Please type [1] for First Class");
                Console.WriteLine("Please type [2] for Economy Class");
                Console.WriteLine("Please type [3] to exit the order system");
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.Write("Enter the class you prefer (1 to 3): ");
                seatOption = Convert.ToInt32(Console.ReadLine());

                switch (seatOption)
                {
                    case 1:
                        if (seatsBooked.Count == 0)
                        {
                            firstClass = rand.Next(0, 5);
                            seats[firstClass] = true;
                            seatsBooked.Add(firstClass);
                        }
                        else
                        {
                            do
                            {
                                firstClass = rand.Next(0, 5);
                                if (!seatsBooked.Contains(firstClass))
                                {
                                    seats[firstClass] = true;

                                }
                            } while (seatsBooked.Contains(firstClass) && seatsBooked.Count < 5);

                            if (seatsBooked.Count < 6)
                            {
                                seatsBooked.Add(firstClass);
                            }
                        }
                        if (seatsBooked.Count >= 6)
                        {
                            Console.WriteLine();
                            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                            Console.WriteLine("All seats for First Class are full :(");
                            Console.WriteLine("Do you want to transfer into the First Class compartment?");
                            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                            Console.WriteLine("Please type [2] for Economy Class");
                            Console.WriteLine("Please type [3] to exit the order system");
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to select another seat option...");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            Console.WriteLine("Your seat number: {0}", firstClass + 1);
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to select another seat option...");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        if (seatsBooked.Count == 5)
                        {
                            economyClass = rand.Next(5, 10);
                            seats[economyClass] = true;
                            seatsBooked.Add(economyClass);
                        }
                        else
                        {
                            do
                            {
                                economyClass = rand.Next(5, 10);
                                if (!seatsBooked.Contains(economyClass))
                                {
                                    seats[economyClass] = true;

                                }
                            } while (seatsBooked.Contains(economyClass) && seatsBooked.Count < 10);

                            if (seatsBooked.Count < 11)
                            {
                                seatsBooked.Add(economyClass);
                            }
                        }
                        if (seatsBooked.Count >= 11)
                        {
                            Console.WriteLine();
                            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                            Console.WriteLine("All seats for Economy Class are full :(");
                            Console.WriteLine("Do you want to transfer into the First Class compartment?");
                            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                            Console.WriteLine("Please type [1] for First Class");
                            Console.WriteLine("Please type [3] to exit the order system");
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to select another seat option...");
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            Console.WriteLine("Your seat number: {0}", economyClass + 1);
                            Console.WriteLine("-------------------------------------------------------------------------------");
                            Console.WriteLine();
                            Console.WriteLine("Press any key to select another seat option...");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        Console.WriteLine("Next flight leaves in three hours!");
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        Console.WriteLine("Sorry! :( That is an invalid selection");
                        Console.WriteLine("-------------------------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine("Press any key to select a valid seat option...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (seatOption != 3);

            Console.WriteLine();
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("Press any key to exit...");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.ReadKey();
        }
    }
}
