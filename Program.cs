using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_to_Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
//test
            binary();

        }

        static void binary()
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

            Console.Write("\n\n\n\nDo you want to convert another number?  Type 'Y' if yes ");
            string yes = Console.ReadLine();
            bool loopsy = true;

            while (loopsy)
            {

                if (yes == "y" || yes == "Y")
                {
                    binary();
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
