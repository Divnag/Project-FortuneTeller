using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            Console.WriteLine("Do you want to exit");
            input = Console.ReadLine();
            while (true)
            {
                //Console.WriteLine("Do you want to exit");
                //Console.ReadLine();
            
                switch (input)
                {
                    case "exit":
                       
                        System.Environment.Exit(0);
                        break;

                    default:
                        continue;
                }

                //UI Requirement 1


                //sending message to console asking for user input ,assigning it to a variable and converting it to same case
                Console.WriteLine("Enter the User Firstname");
                string firstName = Console.ReadLine().ToUpper();
                Console.WriteLine("");
                Console.WriteLine("Enter the User Lastname");
                String lastName = Console.ReadLine().ToUpper();
                Console.WriteLine(" ");
                Console.WriteLine("Enter the User age");
                //converting string  to integer
                int age = int.Parse(Console.ReadLine());

                //checking if user input is valid age
                while (age < 0)

                {
                    Console.WriteLine("Enter valid age");
                    age = int.Parse(Console.ReadLine());


                }

                Console.WriteLine("");
                Console.WriteLine("Enter User birth month");
                int birthMonth = int.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Please select your favourite color from 'ROYGBIV'\n If you need help choosing color. Type 'Help'");
                //converting string to lowercase
                String color = Console.ReadLine().ToLower();
                //user asked for help
                if (color == "help")
                {
                    Console.WriteLine("ROYGBIV stands for\nR:Red\nO:Orange\nY:Yellow\nG;Green\nB:Blue\nI:Indigo\nv:Violet\n");
                    Console.WriteLine("Select your color");
                    color = Console.ReadLine().ToLower();

                }
                //wrong color selected
                while ((color != "red") && (color != "green") && (color != "yellow") && (color != "orange") && (color != "blue") && (color != "indigo") && (color != "violet"))
                {
                    Console.WriteLine("Choose the color from ROYGBIV.Type 'Help'");
                    color = Console.ReadLine().ToLower();


                    if (color == "help")
                    {
                        Console.WriteLine("ROYGBIV stands for\nR:Red\nO:Orange\nY:Yellow\nG;Green\nB:Blue\nI:Indigo\nv:Violet\n");
                        Console.WriteLine("Select your color");
                        color = Console.ReadLine().ToLower();

                    }

                }
                Console.WriteLine("");
                Console.WriteLine("enter the number of siblings");
                int sib = int.Parse(Console.ReadLine());


                //Application Logic requirements



                //to decide age even or odd number
                int age1 = age % 2;
                int retireAgeEven = 66;
                int retireAgeOdd = 67;
                int yrsToRetire;
                //calculating years retire
                if (age1 == 0)
                {
                    yrsToRetire = retireAgeEven - age;
                }
                else
                {
                    yrsToRetire = retireAgeOdd - age;
                }


                //deciding vacation home
                string vacation;
                if (sib == 0)
                {
                    vacation = "Myrtle beach";
                }
                else if (sib == 1)
                {
                    vacation = "Big Bear Lake";
                }
                else if (sib == 2)
                {
                    vacation = "Bhama Island";
                }
                else if (sib == 3)
                {
                    vacation = "Panam city beach";
                }
                else if (sib > 3)
                {
                    vacation = "Thousand Island";
                }

                else
                {
                    vacation = "desirable place";
                }



                //Deciding the transportation based on the color
                String transport;

                switch (color)
                {
                    case "red":
                        transport = "Scooter";
                        break;
                    case "orange":
                        transport = "Private Jet";
                        break;
                    case "yellow":
                        transport = "Cruise";
                        break;
                    case "green":
                        transport = "Horse";
                        break;
                    case "blue":
                        transport = "Bike";
                        break;
                    case "indigo":
                        transport = "Bicycle";
                        break;
                    case "violet":
                        transport = "Caravan";
                        break;

                    default:
                        transport = "Youe Mode of Transporation cannot be decided";
                        break;
                }


                //deciding balance amount  based on birthmonth
                String balance;

                if ((birthMonth <= 4) && (birthMonth > 0))
                {
                    balance = "$50,0000";


                }
                else if ((birthMonth <= 8) && (birthMonth >= 5))
                {
                    balance = "$100,0000";

                }
                else if ((birthMonth <= 12) && (birthMonth >= 9))
                {
                    balance = "$200,0000";

                }
                else
                {
                    balance = "$0.00";

                }


                //UI Requirement 2

                Console.WriteLine("\n" + firstName + " " + lastName + " will retire in  " + yrsToRetire + "  years" + "  with " + balance +
                    " in the bank," + "\n" + "a vaction home in " + vacation + " and a " + transport + ".");

            }


        }

    }
}
    


