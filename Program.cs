using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_Binary
{
    internal class Program
    {
         // boolean for newsession
        static bool optionHandler;

        static void Main(string[] args)
        {

            // Main

            mainOption();





        }

        static void mainOption()
        {
            string optionTest;

            Console.WriteLine("\n\t\t\t\tWelcome to the Lanes!");
            Console.WriteLine("\nWhat do you want to convert?");
            Console.WriteLine("Note: only type from 1-3 for option");
            Console.WriteLine("\n(1) 'Binary To Decimal'");
            Console.WriteLine("(2) 'Decimal to Binary'");
            Console.WriteLine("(3) 'Exit'");
            optionTest = Console.ReadLine();

            Console.Clear();

            if (optionTest == "1")
            {
                optionHandler = false;
                binaryToDecimal();
               
            }
            else if (optionTest == "2")
            {
                optionHandler = true;
                decimalToBinary();
                
            }
            else if (optionTest == "3")
            {
                Console.ReadKey();
                Console.WriteLine("Press any key to exit....");
            }
        }

        // BINARY TO DECIMAL

        static void binaryToDecimal()
        {



            string myNum;
            int power = -1;

            
            Console.Write("\n\nEnter the binary number you want to convert to decimal: ");

            myNum = Console.ReadLine();
            string checkpoint = myNum;
            bool myCheckpoint = checkpoint.Any(tsek => "23456789".Contains(tsek));

            double myDecimal = 0;

           if (myCheckpoint)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\nYou have entered an invalid binary!");
                Console.ResetColor();

                Console.WriteLine("\nNote: binary only contains 1s and 0s.");
                binaryToDecimal();
            }


            for (int i = myNum.Length - 1; i >= 0; i--)
            {

                power++;

                if (myNum[i] == '1')
                {
                    myDecimal = myDecimal + Math.Pow(2, power);

                }
                else
                {
                    myDecimal = myDecimal + 0;
                }

            }

            // OUTPUT
            Console.Clear();
            Console.WriteLine("The decimal number is: {0}", myDecimal);

            // New Session

            newSession();

        }

        // DECIMAL TO BINARY

        static void decimalToBinary()
        {

            Console.Write("\n\nEnter the number you want to convert to binary: ");
            string input = Console.ReadLine();
            double myNum;

            while (!double.TryParse(input, out myNum))
            {
                Console.Write("\nPlease enter a valid number: ");
                input = Console.ReadLine();

            }
            string binaryString = "";
            double i;

            for (i = myNum; i >= 1; i = Math.Floor(i / 2))
            {

                if (i % 2 == 0)
                {
                    binaryString = "0" + binaryString;
                }
                else
                {
                    binaryString = "1" + binaryString;
                }
            }

            Console.WriteLine("\n\n{0} in binary is {1}", myNum, binaryString);


            newSession();


        }


        static void newSession()
        {

            if (optionHandler)
            {
                Console.Write("\n\nDo you want to convert another number?  Type 'Y' if yes ");
                string yes = Console.ReadLine();
                bool loopsy = true;

                while (loopsy)
                {

                    if (yes == "y" || yes == "Y")
                    {
                        Console.Clear();
                        decimalToBinary();
                        loopsy = false;
                    }
                    else
                    {
                        Console.Clear();
                        loopsy = false;
                        mainOption();
                    }
                }

                Console.ReadKey();

            }
            else
            {
                Console.Write("\n\n\n\nDo you want to convert another number?  Type 'Y' if yes ");
                string yes = Console.ReadLine();
                bool loopsy = true;

                while (loopsy)
                {

                    if (yes == "y" || yes == "Y")
                    {
                        Console.Clear();
                        binaryToDecimal();
                        loopsy = false;
                    }
                    else
                    {
                        Console.Clear();
                        loopsy = false;
                        mainOption();
                    }
                }

                Console.ReadKey();

            }


        }





    }
}
