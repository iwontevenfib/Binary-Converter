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

            string optionTest;

            Console.WriteLine("\t\t\t\tWelcome to the Lanes!");
            Console.Write("\nWhat do you want to convert? type (1) 'Binary To Decimal' | (2) 'Decimal to Binary': ");
            optionTest = Console.ReadLine();

            if (optionTest == "1")
            {
                binaryToDecimal();
                optionHandler = false;
            }
            else if (optionTest == "2")
            {
                decimalToBinary();
                optionHandler = true;
            }




        }

       // BINARY TO DECIMAL

        static void binaryToDecimal()
        {



            string myNum;
            int power = -1;

            Console.WriteLine("\nNote: Binary is only 1's and 0's.");
            Console.Write("Enter the binary number you want to convert to decimal: ");

            myNum = Console.ReadLine();

            double myDecimal = 0;




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
                Console.Write("\n\n\n\nDo you want to convert another number?  Type 'Y' if yes ");
                string yes = Console.ReadLine();
                bool loopsy = true;

                while (loopsy)
                {

                    if (yes == "y" || yes == "Y")
                    {
                        decimalToBinary();
                        loopsy = false;
                    }
                    else
                    {
                        loopsy = false;
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
                        binaryToDecimal();
                        loopsy = false;
                    }
                    else
                    {
                        loopsy = false;
                    }
                }

                Console.ReadKey();

            }


        }





    }
}
